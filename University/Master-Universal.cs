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
                        Master master = new Manager();
                        newMaster.put(manager.id + "", "mng\\" + manager.id);
                        instance.managerTree = newMaster;
                        bf.Serialize(file, instance);
                        FileStream newFile = File.Create("mng\\" + manager.id);
                        BinaryFormatter newbf = new BinaryFormatter();
                        bf.Serialize(newFile, manager);
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
                    BTree newManager = new BTree();
                    Manager manager = new Manager();
                    newManager.put(manager.id + "", "mng\\" + manager.id);
                    instance.managerTree = newManager;
                    FileStream file = File.Create("UniMaster");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, instance);
                    FileStream newFile = File.Create("mng\\" + manager.id);
                    BinaryFormatter newbf = new BinaryFormatter();
                    bf.Serialize(newFile, manager);
                    newFile.Close();
                    file.Close();
                }
            }
        }
        public BTree masterTree;        //Tree of masters

    }
}
