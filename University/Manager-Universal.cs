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
    class Manager_Universal
    {
        public static Manager_Universal instance;
        static Manager_Universal()
        {
            if (instance == null)
            {
                instance = new Manager_Universal();
                if (File.Exists("UniManager"))
                {
                    //File exists.
                    FileStream file = File.Open("UniManager", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("UniManager").Length == 0)
                    {
                        //File is empty.
                        BTree newManager = new BTree();
                        Manager manager = new Manager();
                        newManager.put(manager.id + "", "mng\\" + manager.id);
                        instance.managerTree = newManager;
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
                        instance = bf.Deserialize(file) as Manager_Universal;
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
                    FileStream file = File.Create("UniManager");
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
        public BTree managerTree;       //Tree of managers
    }
}
