﻿using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using University;
namespace UniversityClasses
{
    [System.Serializable]
    class Universal
    {
        public static Universal instance;
        const string dir = "";
        /**
         * Initializes main file and BTrees.
         */
        public Universal()
        {
            if (instance == null)
            {
                instance = this;
                if (!File.Exists(dir + "mngFile"))
                {
                    FileStream mngFile = File.Create(dir + "mngFile");
                    mngFile.Close();
                }
                if (File.Exists("mngTree"))
                {
                    //Tree File exists.
                    FileStream mngTreeFile = File.Open("mngTree", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("mngTree").Length == 0)
                    {
                        //Tree File is empty.
                        BTree mngTree = new BTree();
                        Manager manager = new Manager();
                        mngTree.put(manager.id, 0);
                        instance.managerTree = mngTree;
                        bf.Serialize(mngTreeFile, mngTree);
                        FileManager.Add<Manager>(mngTree, new Manager(),manager.id, fileDirectoryPlusName: dir + "mngFile");
                                                                                                                                   // FileStream newFile = File.Create("mng\\" + manager.id);
                                                                                                                                                        // BinaryFormatter newbf = new BinaryFormatter();
                                                                                                                                                    //bf.Serialize(newFile, manager);
                                                                                                                                                    // newFile.Close();
                        mngTreeFile.Close();
                    }
                    else
                    {
                        //Tree File was already created.
                        instance.managerTree = bf.Deserialize(mngTreeFile) as BTree;
                        mngTreeFile.Close();
                    }
                }
                else
                {
                    //Tree File not exists
                    BTree mngTree = new BTree();
                    Manager manager = new Manager();
                    mngTree.put(manager.id, 0);
                    instance.managerTree = mngTree;
                    FileStream mngTreeFile = File.Create("mngTree");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(mngTreeFile, mngTree);
                    FileManager.Add<Manager>(mngTree, new Manager(), manager.id, fileDirectoryPlusName: dir + "mngFile");                                                                                                                            //FileStream newFile = File.Create("mng\\" + manager.id);
                                                                                                                                                                                                                                                     //BinaryFormatter newbf = new BinaryFormatter();
                                                                                                                                                                                                                                                     //bf.Serialize(newFile, manager);
                                                                                                                                                                                                                                                     //newFile.Close();
                    mngTreeFile.Close();
                }

                if (!File.Exists("mstFile"))
                {
                    FileStream mstFile = File.Create("mstFile");
                    mstFile.Close();
                }
                if (File.Exists("mstTree"))
                {
                    //Tree File exists.
                    FileStream mstTreeFile = File.Open("mstTree", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("mstTree").Length == 0)
                    {
                        //Tree File is empty.
                        BTree mstTree = new BTree();
                        instance.masterTree = mstTree;
                        bf.Serialize(mstTreeFile, mstTree);
                        mstTreeFile.Close();
                    }
                    else
                    {
                        //Tree File was already created.
                        instance.masterTree = bf.Deserialize(mstTreeFile) as BTree;
                        mstTreeFile.Close();
                    }
                }
                else
                {
                    //Tree File not exists
                    BTree mstTree = new BTree();
                    instance.masterTree = mstTree;
                    FileStream mstFile = File.Create("mstTree");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(mstFile, mstTree);
                    mstFile.Close();
                }

                if (!File.Exists("stdFile"))
                {
                    FileStream stdFile = File.Create("stdFile");
                    stdFile.Close();
                }
                if (File.Exists("stdTree"))
                {
                    //Tree File exists.
                    FileStream stdTreeFile = File.Open("stdTree", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("stdTree").Length == 0)
                    {
                        //Tree File is empty.
                        BTree stdTree = new BTree();
                        instance.studentTree = stdTree;
                        bf.Serialize(stdTreeFile, stdTree);
                        stdTreeFile.Close();
                    }
                    else
                    {
                        //Tree File was already created.
                        instance.studentTree = bf.Deserialize(stdTreeFile) as BTree;
                        stdTreeFile.Close();
                    }
                }
                else
                {
                    //Tree File not exists
                    BTree stdTree = new BTree();
                    instance.studentTree = stdTree;
                    FileStream stdTreeFile = File.Create("stdTree");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stdTreeFile, stdTree);
                    stdTreeFile.Close();
                }

                if (!File.Exists("crsFile"))
                {
                    FileStream crsFile = File.Create("crsFile");
                    crsFile.Close();
                }
                if (File.Exists("crsTree"))
                {
                    //File exists.
                    FileStream crsFile = File.Open("crsTree", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("crsTree").Length == 0)
                    {
                        //File is empty.
                        BTree crsTree = new BTree();
                        instance.courseTree = crsTree;
                        bf.Serialize(crsFile, crsTree);
                        crsFile.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance.courseTree = bf.Deserialize(crsFile) as BTree;
                        crsFile.Close();
                    }
                }
                else
                {
                    //File not exists
                    BTree crsTree = new BTree();
                    instance.courseTree = crsTree;
                    FileStream crsTreeFile = File.Create("crsTree");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(crsTreeFile, crsTree);
                    crsTreeFile.Close();
                }
                
            }
        }

        public void SaveTree(string treeFileName, BTree whichTree)
        {
            FileStream file = File.Open(treeFileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(file, whichTree);

            file.Close();
        }

        public BTree studentTree;       //Tree of students
        public BTree masterTree;        //Tree of masters
        public BTree managerTree;       //Tree of managers
        public BTree courseTree;        //Tree of courses

        public bool isAbleUnitChoice = false;       //UnitChoice ability
        public bool isAbleUnitEdit = false;         //UnitEdit ability
    }
}