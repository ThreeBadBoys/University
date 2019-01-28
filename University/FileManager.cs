using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.Serialization.Formatters.Binary;
using UniversityClasses;

namespace University
{
    static class FileManager
    {
        public static void Add<T>(BTree whichTree, object objectToAdd, uint objectToAddID, string fileDirectoryPlusName)
        {
            // Get a handle to an existing memory mapped file
            using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fileDirectoryPlusName, FileMode.Open))
            {
                // Create a view accessor from which to read the data
                using (MemoryMappedViewAccessor mmfReader = mmf.CreateViewAccessor())
                {
                    byte[] buffer = new byte[mmfReader.Capacity];
                    byte[] objectArray = ObjectToByteArray(objectToAdd);

                    int i;
                    for (i = 0; ; i++)
                    {
                        if (!mmfReader.CanRead)
                        {
                            mmfReader.ReadArray<byte>(i * objectArray.Length, buffer, 0, 1);
                            T temp = (T)ByteArrayToObject(buffer);
                            if (temp == null)
                            {
                                whichTree.put(objectToAddID, i);
                                return;
                            }
                        }
                    }
                }
            }
        }





        public static void Remove(BTree whichTree, object objectTempToRemove, uint objectToRemoveID, string fileDirectoryPlusName)
        {
            int index = whichTree.get(objectToRemoveID);

            byte[] buffer = ObjectToByteArray(null);
            byte[] objectArray = ObjectToByteArray(objectTempToRemove);

            using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fileDirectoryPlusName, FileMode.Open))
            {
                using (MemoryMappedViewAccessor mmfWriter = mmf.CreateViewAccessor(index * objectArray.Length, buffer.Length))
                {
                    mmfWriter.WriteArray<byte>(index * objectArray.Length, buffer, 0, 1);
                }
            }
            whichTree.delete(objectToRemoveID);
        }

        public static void Load(BTree whichTree, object objectTempToLoad, uint objectToLoadID, string fileDirectoryPlusName)
        {
            int index = whichTree.get(objectToLoadID);

            byte[] buffer = ObjectToByteArray(objectTempToLoad);

            using (MemoryMappedFile mmf = MemoryMappedFile.CreateFromFile(fileDirectoryPlusName, FileMode.Open))
            {
                using (MemoryMappedViewAccessor mmfReader = mmf.CreateViewAccessor())
                {
                    mmfReader.ReadArray<byte>(index * buffer.Length, buffer, 0, 1);
                }
            }
            objectTempToLoad = ByteArrayToObject(buffer);
        }

        private static byte[] ObjectToByteArray(object objectToGetBytes)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();    // Create new BinaryFormatter
            MemoryStream memoryStream = new MemoryStream();             // Create target memory stream
            binaryFormatter.Serialize(memoryStream, objectToGetBytes);       // Serialize object to stream
            return memoryStream.ToArray();
        }

        public static object ByteArrayToObject(byte[] buffer)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter(); // Create new BinaryFormatter
            MemoryStream memoryStream = new MemoryStream(buffer);    // Convert buffer to memorystream
            return binaryFormatter.Deserialize(memoryStream);        // Deserialize stream to an object
        }
    }
}
