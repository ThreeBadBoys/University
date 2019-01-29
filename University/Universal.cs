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
                if (File.Exists("mng") && File.Exists("mst") && File.Exists("std") && File.Exists("crs"))
                {
                    //File exists.
                    FileStream std = File.Open("std", FileMode.Open);
                    FileStream mst = File.Open("mst", FileMode.Open);
                    FileStream mng = File.Open("mng", FileMode.Open);
                    FileStream crs = File.Open("crs", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("mng").Length == 0)
                    {
                        //File is empty.
                        BTree newManager = new BTree();
                        Manager manager = new Manager();
                        newManager.put(manager.id + "", "mng\\" + manager.id);
                        instance.managerTree = newManager;
                        bf.Serialize(mng, newManager);
                        FileStream newFile = File.Create("mng\\" + manager.id);
                        BinaryFormatter newbf = new BinaryFormatter();
                        bf.Serialize(newFile, manager);
                        newFile.Close();
                        mng.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance.managerTree = bf.Deserialize(mng) as BTree;
                        mng.Close();
                    }
                    if (new FileInfo("std").Length == 0)
                    {
                        //File is empty.
                        BTree newStudent = new BTree();
                        instance.studentTree = newStudent;
                        bf.Serialize(std, newStudent);
                        std.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance.studentTree = bf.Deserialize(std) as BTree;
                        std.Close();
                    }
                    if (new FileInfo("mst").Length == 0)
                    {
                        //File is empty.
                        BTree newMaster = new BTree();
                        instance.masterTree = newMaster;
                        bf.Serialize(mst, newMaster);
                        mst.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance.masterTree = bf.Deserialize(mst) as BTree;
                        mst.Close();
                    }
                    if (new FileInfo("crs").Length == 0)
                    {
                        //File is empty.
                        BTree newCourse = new BTree();
                        instance.courseTree = newCourse;
                        bf.Serialize(crs, newCourse);
                        crs.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance.courseTree = bf.Deserialize(crs) as BTree;
                        crs.Close();
                    }
                }
                else
                {
                    //File not exists
                    BTree newManager = new BTree();
                    BTree newMaster = new BTree();
                    BTree newStudent = new BTree();
                    BTree newCourse = new BTree();
                    Manager manager = new Manager();
                    newManager.put(manager.id + "", "mng\\" + manager.id);
                    instance.managerTree = newManager;
                    instance.masterTree = newMaster;
                    instance.studentTree = newStudent;
                    instance.courseTree = newCourse;
                    FileStream mng = File.Create("mng");
                    FileStream mst = File.Create("mst");
                    FileStream std = File.Create("std");
                    FileStream crs = File.Create("crs");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(mng, newManager);
                    bf.Serialize(mst, newMaster);
                    bf.Serialize(std, newStudent);
                    bf.Serialize(crs, newCourse);
                    FileStream newFile = File.Create("mng\\" + manager.id);
                    BinaryFormatter newbf = new BinaryFormatter();
                    bf.Serialize(newFile, manager);
                    newFile.Close();
                    mng.Close();
                    mst.Close();
                    std.Close();
                    crs.Close();
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