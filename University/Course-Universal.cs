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
                        newCourse.put(cousre.code + "", "cou\\" + cousre.code);
                        instance.courseTree = newCourse;
                        bf.Serialize(file, instance);
                        FileStream newFile = File.Create("cou\\" + cousre.code);
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
                    Course cousre = new Course("", 0, 0, "", "0", null);
                    newManager.put(cousre.code + "", "cou\\" + cousre.code);
                    instance.courseTree = newManager;
                    FileStream file = File.Create("UniCourse");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, instance);
                    FileStream newFile = File.Create("cou\\" + cousre.code);
                    BinaryFormatter newbf = new BinaryFormatter();
                    bf.Serialize(newFile, cousre);
                    newFile.Close();
                    file.Close();
                }
            }
        }
        public BTree courseTree;        //Tree of courses
    }
}
