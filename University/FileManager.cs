using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UniversityClasses;

namespace University
{
    static class FileManager
    {
        public static void Add<T>(BTree whichTree, object objectToAdd, int objectToAddID, string fileDirectoryPlusName)
        {
            byte[] objectArray = ObjectToByteArray(objectToAdd);
            int tempindex;
            if (whichTree.isEmpty())
                tempindex = -1;
            else
                tempindex = whichTree.getLast();
            // Get a handle to an existing memory mapped file
            using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fileDirectoryPlusName, FileMode.Open, "mmf", (tempindex + 2) * objectArray.Length))
            {
                // Create a view accessor from which to read the data
                using (MemoryMappedViewAccessor mmfReader = mmf.CreateViewAccessor())
                {
                    byte[] buffer = new byte[objectArray.Length];

                    for (int index = 0; ; index++)
                    {
                        if (mmfReader.CanRead)
                        {
                            mmfReader.ReadArray<byte>(index * objectArray.Length, buffer, 0, buffer.Length);
                            T temp = (T)ByteArrayToObject(buffer);
                            if (temp == null)
                            {
                                whichTree.put(objectToAddID, index);
                                mmfReader.WriteArray<byte>(index * objectArray.Length, objectArray, 0, buffer.Length);
                                return;
                            }
                        }
                        else
                            return;
                    }
                }
            }
        }
        public static bool Remove(BTree whichTree, object objectTempToRemove, int objectToRemoveID, string fileDirectoryPlusName)
        {
            int index = whichTree.get(objectToRemoveID);
            if (index != -1)
            {
                byte[] objectArray = ObjectToByteArray(objectTempToRemove);
                byte[] buffer = new byte[objectArray.Length];
                
                using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fileDirectoryPlusName, FileMode.Open))
                {
                    using (MemoryMappedViewAccessor mmfWriter = mmf.CreateViewAccessor())
                    {
                        mmfWriter.WriteArray<byte>(index * buffer.Length, buffer, 0, buffer.Length);
                    }
                }
                whichTree.delete(objectToRemoveID);
                return true;
            }
            return false;
        }

        public static object Load(BTree whichTree, object objectTempToLoad, int objectToLoadID, string fileDirectoryPlusName)
        {
            int index = whichTree.get(objectToLoadID);
            if (index != -1)
            {
                bool Readable;

                objectTempToLoad = LoadObj(objectTempToLoad, fileDirectoryPlusName, index, out Readable);
            }
            else
            {
                objectTempToLoad = null;
            }

            return objectTempToLoad;
        }
        public static object Load(BTree whichTree, object objectTempToLoad, out bool Readable, string fileDirectoryPlusName, int index)
        {
            if(index == -1)
            {
                Readable = false;
                return null;
            }
            objectTempToLoad = LoadObj(objectTempToLoad, fileDirectoryPlusName, index, out Readable);

            return objectTempToLoad;
        }

        private static object LoadObj(object objectTempToLoad, string fileDirectoryPlusName, int index, out bool Readable)
        {
            byte[] buffer = ObjectToByteArray(objectTempToLoad);

            using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fileDirectoryPlusName, FileMode.Open))
            {
                using (MemoryMappedViewAccessor mmfReader = mmf.CreateViewAccessor())
                {
                    Readable = mmfReader.CanRead;
                    if (Readable)
                        mmfReader.ReadArray<byte>(index * buffer.Length, buffer, 0, buffer.Length);
                }
            }
            objectTempToLoad = ByteArrayToObject(buffer);
            return objectTempToLoad;
        }

        public static bool SaveEdited(BTree whichTree, object objectToEdit, int objectToEditID, string fileDirectoryPlusName)
        {
            int index = whichTree.get(objectToEditID);
            if (index == -1)
                return false;

            byte[] buffer = ObjectToByteArray(objectToEdit);

            using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fileDirectoryPlusName, FileMode.Open))
            {
                using (MemoryMappedViewAccessor mmfWriter = mmf.CreateViewAccessor())
                {
                    mmfWriter.WriteArray<byte>(index * buffer.Length, buffer, 0, buffer.Length);
                }
            }

            return true;
        }

        private static byte[] ObjectToByteArray(object objectToGetBytes)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();    // Create new BinaryFormatter
            MemoryStream memoryStream = new MemoryStream();             // Create target memory stream
            binaryFormatter.Serialize(memoryStream, objectToGetBytes);  // Serialize object to stream
            return memoryStream.ToArray();
        }

        public static object ByteArrayToObject(byte[] buffer)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter(); // Create new BinaryFormatter
            MemoryStream memoryStream = new MemoryStream(buffer);    // Convert buffer to memorystream
            try
            {
                return binaryFormatter.Deserialize(memoryStream);        // Deserialize stream to an object
            }
            catch (SerializationException e)
            {
                return null;
            }
        }
    }
}