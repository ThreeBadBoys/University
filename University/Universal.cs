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
                if (File.Exists("mng"))
                {
                    //File exists.
                    FileStream mng = File.Open("mng", FileMode.Open);
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
                }
                else
                {
                    //File not exists
                    BTree newManager = new BTree();
                    Manager manager = new Manager();
                    newManager.put(manager.id + "", "mng\\" + manager.id);
                    instance.managerTree = newManager;
                    FileStream mng = File.Create("mng");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(mng, newManager);
                    FileStream newFile = File.Create("mng\\" + manager.id);
                    BinaryFormatter newbf = new BinaryFormatter();
                    bf.Serialize(newFile, manager);
                    newFile.Close();
                    mng.Close();
                }
                if (File.Exists("mst"))
                {
                    //File exists.
                    FileStream mst = File.Open("mst", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
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
                }
                else
                {
                    //File not exists
                    BTree newMaster = new BTree();
                    instance.masterTree = newMaster;
                    FileStream mst = File.Create("mst");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(mst, newMaster);
                    mst.Close();
                }
                if (File.Exists("std"))
                {
                    //File exists.
                    FileStream std = File.Open("std", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
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
                }
                else
                {
                    //File not exists
                    BTree newStudent = new BTree();
                    instance.studentTree = newStudent;
                    FileStream std = File.Create("std");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(std, newStudent);
                    std.Close();
                }
                if (File.Exists("crs"))
                {
                    //File exists.
                    FileStream crs = File.Open("crs", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
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
                    BTree newCourse = new BTree();
                    instance.courseTree = newCourse;
                    FileStream crs = File.Create("crs");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(crs, newCourse);
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