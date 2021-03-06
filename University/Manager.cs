﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using UniversityClasses;
using University;

namespace UniversityClasses
{
    [System.Serializable]
    class Manager
    {
        public bool isAbleUnitChoice = false;       //UnitChoice ability
        public bool isAbleUnitEdit = false;         //UnitEdit ability
        const string dir = "C:\\Users\\AliNajafi\\Documents\\University\\University\\bin\\Debug\\";
        char[] FirstName = new char[20];
        public string firstName
        {
            get
            {
                string temp = "";
                for (int i = 0; i < FirstName.Length; i++)
                {
                    if (FirstName[i] != '\0')
                        temp += FirstName[i];
                    else
                        break;
                }
                return temp;
            }
            set
            {
                int i;
                for (i = 0; i < value.Length; i++)
                {
                    FirstName[i] = value[i];
                }
                FirstName[i] = '\0';
            }
        }

        char[] LastName = new char[20];
        public string lastName
        {
            get
            {
                string temp = "";
                for (int i = 0; i < LastName.Length; i++)
                {
                    if (LastName[i] != '\0')
                        temp += LastName[i];
                    else
                        break;
                }
                return temp;
            }
            set
            {
                int i;
                for (i = 0; i < value.Length; i++)
                {
                    LastName[i] = value[i];
                }
                LastName[i] = '\0';
            }
        }

        char[] Password = new char[20];
        public string password
        {
            get
            {
                string temp = "";
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Password[i] != '\0')
                        temp += Password[i];
                    else
                        break;
                }
                return temp;
            }
            set
            {
                int i;
                for (i = 0; i < value.Length; i++)
                {
                    Password[i] = value[i];
                }
                Password[i] = '\0';
            }
        }

        public int id;
        //-----------------------------------------
        //Constructors
        public Manager(string firstName, string lastName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;

            if (Universal.instance.managerTree != null)
            {
                int lastManagerIndex = Universal.instance.managerTree.isEmpty() ? -1 : Universal.instance.managerTree.getLast();
                bool Readable;
                Manager newMng = (Manager)FileManager.Load(Universal.instance.managerTree, new Manager(), out Readable, fileDirectoryPlusName: dir + "mngFile", index: lastManagerIndex);

                if (lastManagerIndex != -1)
                    this.id = newMng.id + 1;
                else
                    this.id = 97000;
            }
        }
        public Manager()
        {
            firstName = "admin";
            lastName = "admin";
            this.password = "1234";
            id = 97000;
        }
        //-----------------------------------------
        //functions
        public int EditPassword(string currentPassWord, string newPassword, string newPasswordAgain)
        {
            if (currentPassWord != this.password)
            {
                // Have To Show Error for current password
                return 0;
            }
            else
            {
                if (newPassword != newPasswordAgain)
                {
                    // Have To Show Error for confirmation password
                    return 1;
                }
                else
                {
                    this.password = newPassword;
                    FileManager.SaveEdited(Universal.instance.managerTree, this, this.id, fileDirectoryPlusName: dir + "mngFile");
                    return 2;
                }
            }

            //End of Method
        }
        public bool SignUpStudent(string firstName, string lastName, string major)
        {
            if (isValidName(firstName) && isValidName(lastName))
            {
                Student student = new Student(firstName.Trim(), lastName.Trim(), major);
                FileManager.Add<Student>(Universal.instance.studentTree, student, student.id, fileDirectoryPlusName: dir + "stdFile");
                Universal.instance.SaveTree("stdTree", Universal.instance.studentTree);
                return true;
            }
            else
            {
                return false;
            }
            //End of Method
        }
        public bool SignUpMaster(string firstName, string lastName, List<Course> lessons)
        {
            if (isValidName(firstName) && isValidName(lastName))
            {
                Master master = new Master(firstName, lastName, lessons);
                //Now Here we have to check the Tree
                //    if (Universal.instance.masterTree == null)
                //    {
                //        BTree newMaster = new BTree();
                //         newMaster.put(master.id + "", "mst\\" + master.id);
                //        Universal.instance.studentTree = newMaster;
                //     }
                //    else
                //     {
                //         Universal.instance.studentTree.put(master.id + "", "mst\\" + master.id);
                //    }
                //     FileStream file = File.Create("mst\\" + master.id);
                //     BinaryFormatter bf = new BinaryFormatter();
                //    bf.Serialize(file, master);
                //    file.Close();
                FileManager.Add<Master>(Universal.instance.masterTree, master, master.id, fileDirectoryPlusName:dir + "mstFile");
                Universal.instance.SaveTree("mstTree", Universal.instance.masterTree);
                return true;
            }
            else
            {
                return false;
            }
            //End of Method
        }
        public bool SignUpManager(string firstName, string lastName, string password)
        {
            if (isValidName(firstName) && isValidName(lastName))
            {
                Manager manager = new Manager(firstName.Trim(), lastName.Trim(), password);
                //Now Here we have to check the Tree
                //   if (Universal.instance.managerTree == null)
                //  {
                //      BTree newMaster = new BTree();
                //      newMaster.put(manager.id + "", "mng\\" + manager.id);
                //       Universal.instance.studentTree = newMaster;
                //   }
                //   else
                //   {
                //       Universal.instance.studentTree.put(manager.id + "", "mng\\" + manager.id);
                //   }
                //   FileStream file = File.Create("mng\\" + manager.id);
                //   BinaryFormatter bf = new BinaryFormatter();
                //   bf.Serialize(file, manager);
                //   file.Close();
                FileManager.Add<Manager>(Universal.instance.managerTree, manager, manager.id, fileDirectoryPlusName:dir + "stdFile");
                Universal.instance.SaveTree("mngTree", Universal.instance.managerTree);
                return true;
            }
            else
            {
                return false;
            }
            //End of Method
        }
        public bool AddCourse(int code, String name, int mstId, String time, String examTime, int val)
        {
            if (isValidName(name) && ((Math.Log10(code) + 1) >= 5 && (SearchMaster(mstId) != null)))
            {
                //We have to check if master exists
                Master mst = SearchMaster(mstId);
                if (mst != null)
                {
                    Course course = new Course(name.Trim(), Convert.ToInt32(code), val, time, examTime, mst);
                    FileManager.Add<Course>(Universal.instance.courseTree, course, course.code, fileDirectoryPlusName:dir+ "crsFile");
                    Universal.instance.SaveTree("crsTree", Universal.instance.courseTree);
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
            //End of Method
        }

        public static Student SearchStudent(int id)
        {
            Student student = (Student) FileManager.Load(Universal.instance.studentTree, new Student(), id, fileDirectoryPlusName:dir + "stdFile");
            return student;
            //End of Method
        }
        public static Master SearchMaster(int id)
        {
            Master master = (Master) FileManager.Load(Universal.instance.masterTree, new Master(), id, fileDirectoryPlusName:dir + "mstFile");
            return master;
            //End of Method
        }
        public static Manager SearchManager(int id)
        {
            Manager manager = (Manager) FileManager.Load(Universal.instance.managerTree, new Manager(), id, fileDirectoryPlusName:dir + "mngFile");
            return manager == null ? new Manager() : manager;
            //End of Method
        }

        /**
         * This function removes student key in BTree and removes related file
         */
        public bool RemoveStudentFully(int id)
        {                                                                               //CHECK IT\|/
            if (Universal.instance != null && Universal.instance.studentTree != null)// Checking whether we have student or not
            {
                return FileManager.Remove(Universal.instance.studentTree, new Student(), id, fileDirectoryPlusName:dir + "stdFile");
                //Student deleted successfully
            }
            else
            {
                //Showing Error that the entered id is wrong or threre is no student added
                return false;
            }
            //End of Method
        }


        public bool RemoveMasterFully(int id)
        {
            if (Universal.instance != null && Universal.instance.masterTree != null && ((Math.Log10((int)id)) + 1) == 5)// Checking whether we have master or not
            {
                return FileManager.Remove(Universal.instance.masterTree, new Master(), id, fileDirectoryPlusName: "mstFile");
                //Master deleted successfully
            }

            return false;
        }
        public bool RemoveManagerFully(int id)
        {
            if (Universal.instance != null && Universal.instance.managerTree != null && ((Math.Log10((int)id)) + 1) == 5)// Checking whether we have manager or not
            {
                return FileManager.Remove(Universal.instance.managerTree, new Manager(), id, fileDirectoryPlusName: "mngFile");
                //Master deleted successfully
            }
            else
            {
                //Showing Error that the insterted id is wrong or threre is no manager added
                return false;
            }
            //End of Method
        }
        public void EnablingUnitChoice()
        {
           isAbleUnitChoice = true;
            //End of Method
        }
        public void DesablingUnitChoice()
        {
           isAbleUnitChoice = false;
            //End of Method
        }
      
        public bool isValidName(string name)
        {
            if (name == "") return false;
            return true;
        }
        public bool RemoveStudentsSemester(int id)
        {
            Student std = SearchStudent(id);
            if (std != null)
            {
                std.choosenLessons.Clear();
                return true;
            }
            return false;
            //End of Method
        }
        public void EndingSemester()
        {
            for (int index = 0; ; index++)

            {
                Student std = new Student();
                bool Readable = false;
                std = (Student) FileManager.Load(Universal.instance.studentTree, std, out Readable, fileDirectoryPlusName:dir + "stdFile", index:index);
                if (!Readable)
                    break;
                for (int i = 0; i < std.choosenLessons.Count; i++)
                {
                    if (std.choosenLessons[i].grade > 10)
                    {
                        std.passedLessons = std.passedLessons == null ? new List<StudentCourse>() : std.passedLessons;
                        std.passedLessons.Add(std.choosenLessons[i]);
                    }
                }
                std.choosenLessons.Clear();
            }
            //End of Method
        }
    }

}
