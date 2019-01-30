using System;
using System.Collections.Generic;
using University;

namespace UniversityClasses
{
    [System.Serializable]
    class Master
    {
        const string dir = "";
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

        public List<Course> lessons = new List<Course>(10);
        //-------------------------------
        public Master()
        {
            this.firstName = "";
            this.lastName = "";
            this.password = "";
        }

        public Master(string firstName, string lastName, List<Course> lessons)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            for (int i = 0; i < lessons.Count; i++)
            {
                this.lessons[i] = lessons[i];
            }
         

            if (Universal.instance.masterTree != null)
            {
                int lastMasterIndex = Universal.instance.masterTree.isEmpty() ? -1 : Universal.instance.masterTree.getLast();
                bool Readable;
                Master newMst = (Master)FileManager.Load(Universal.instance.masterTree, new Master(), out Readable, fileDirectoryPlusName: dir + "mstFile", index: lastMasterIndex);

                if (lastMasterIndex != -1)
                {
                    this.id = newMst.id + 1;
                    this.password = String.Format("{0}", this.id);
                }
                else
                {
                    this.id = 97000;
                    this.password = String.Format("{0}", this.id);
                }
            }

        }
        public int EditPassword(string currentPassWord, string newPassword, string newPasswordAgain)
        {
            if (currentPassWord != this.password)
            {
                // Have To Show Error
                return 0;
            }
            else
            {
                if (newPassword != newPasswordAgain)
                {
                    // Have To Show Error
                    return 1;
                }
                else
                {
                    this.password = newPassword;
                    FileManager.SaveEdited(Universal.instance.masterTree, this, this.id, fileDirectoryPlusName: dir + "mstFile");
                    return 2;
                }
            }
            //End of Method
        }
        public bool insertingGrade(int id, double grade, int code)
        {
            Student std = Manager.SearchStudent(id);
            bool found = false;
            int i;
            for (i = 0; i < std.choosenLessons.Count; i++)
            {
                if (std.choosenLessons[i].course.code == code)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                std.choosenLessons[i].grade = grade;
                return true;
            }
            return false;
        }
    }
}


