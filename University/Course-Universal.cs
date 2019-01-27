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
    class Course_Universal
    {
        public static Course_Universal instance;
        static Course_Universal()
        {
            if (instance == null)
            {
                instance = new Course_Universal();
                if (File.Exists("UniCourse"))
                {
                    //File exists.
                    FileStream file = File.Open("UniCourse", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("UniCourse").Length == 0)
                    {
                        //File is empty.
                        BTree newCourse = new BTree();
                        Course cousre = new Course("",0,0,"","0",null);
                        newCourse.put(cousre.id + "", "mng\\" + cousre.id);
                        instance.managerTree = newCourse;
                        bf.Serialize(file, instance);
                        FileStream newFile = File.Create("mng\\" + cousre.id);
                        BinaryFormatter newbf = new BinaryFormatter();
                        bf.Serialize(newFile, cousre);
                        newFile.Close();
                        file.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance = bf.Deserialize(file) as Course_Universal;
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
                    FileStream file = File.Create("UniCourse");
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
        public BTree courseTree;        //Tree of courses
    }
}
