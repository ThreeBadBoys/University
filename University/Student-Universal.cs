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
    class Student_Universal
    {

        public static Student_Universal instance;
        static Student_Universal()
        {
            if (instance == null)
            {
                instance = new Student_Universal();
                if (File.Exists("UniStudent"))
                {
                    //File exists.
                    FileStream file = File.Open("UniStudent", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("UniStudent").Length == 0)
                    {

                        //File is empty.
                        BTree newStudent = new BTree();
                        Student student = new Student("Ali","Najafi","SoftWare");
                        newStudent.put(student.id + "", "std\\" + student.id);
                        instance.studentTree = newStudent;
                        bf.Serialize(file, instance);
                        FileStream newFile = File.Create("std\\" + student.id);
                        BinaryFormatter newbf = new BinaryFormatter();
                        bf.Serialize(newFile, student);
                        newFile.Close();
                        file.Close();
                    }
                    else
                    {
                        //File was already created.
                        instance = bf.Deserialize(file) as Student_Universal;
                        file.Close();
                    }
                }
                else
                {
                    //File not exists
                    BTree newStudent = new BTree();
                    Student student = new Student("Ali", "Najafi", "SoftWare");
                    newStudent.put(student.id + "", "std\\" + student.id);
                    instance.studentTree = newStudent;
                    FileStream file = File.Create("UniStudent");
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, instance);
                    FileStream newFile = File.Create("std\\" + student.id);
                    BinaryFormatter newbf = new BinaryFormatter();
                    bf.Serialize(newFile, student);
                    newFile.Close();
                    file.Close();
                }
            }
        }
        public BTree studentTree;       //Tree of students
    }
}
