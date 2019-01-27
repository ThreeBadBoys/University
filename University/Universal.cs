﻿using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UniversityClasses
{
    [System.Serializable]
    class Universal
    {
        public static Universal instance;

        /**
         * Initializes main file and BTrees.
         */
        static Universal()
        {
            if (instance == null)
            {
                instance = new Universal();
                if (File.Exists("Uni"))
                {
                    //File exists.
                    FileStream file = File.Open("Uni", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("Uni").Length == 0)
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
                        instance = bf.Deserialize(file) as Universal;
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
                    FileStream file = File.Create("Uni");
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

        public BTree studentTree;       //Tree of students
        public BTree masterTree;        //Tree of masters
        public BTree managerTree;       //Tree of managers
        public BTree courseTree;        //Tree of courses

        public bool isAbleUnitChoice = false;       //UnitChoice ability
        public bool isAbleUnitEdit = false;         //UnitEdit ability
    }
}