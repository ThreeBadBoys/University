using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UniversityClasses;
namespace University
{
    [System.Serializable]
    class Master_Universal
    {
        public static Master_Universal instance;

        static Master_Universal()
        {
            if (instance == null)
            {
                instance = new Master_Universal();
                if (File.Exists("UniMaster"))
                {
                    //File exists.
                    FileStream file = File.Open("UniMaster", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("UniMaster").Length == 0)
                    {
                        //File is empty.
                        BTree newMaster = new BTree();
                        Master master = new Master("Ali", "Najafi", new List<Course>());
                        newMaster.put(master.id + "", "mst\\" + master.id);
                        instance.masterTree = newMaster;
                        bf.Serialize(file, instance);
                        FileStream newFile = File.Create("mst\\" + master.id);
                        BinaryFormatter newbf = new BinaryFormatter();
                        bf.Serialize(newFile, master);
                        newFile.Close();
                        file.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance = bf.Deserialize(file) as Master_Universal;
                        file.Close();
                    }
                }
                else
                {
                    //File not exists
                    BTree newMater = new BTree();
                    Master master = new Master("Sajad", "Mogayyad", new List<Course>());
                    newMater.put(master.id + "", "mst\\" + master.id);
                    instance.masterTree = newMater;
                    FileStream file = File.Create("UniMaster");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, instance);
                    FileStream newFile = File.Create("mst\\" + master.id);
                    BinaryFormatter newbf = new BinaryFormatter();
                    bf.Serialize(newFile, master);
                    newFile.Close();
                    file.Close();
                }
            }
        }
        public BTree masterTree;        //Tree of masters

    }
}
