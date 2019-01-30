using System;
using System.Collections.Generic;
using University;

namespace UniversityClasses
{
    [System.Serializable]
    class Student
    {
        //const string dir = "C:\\Users\\AliNajafi\\Documents\\University\\University\\bin\\Debug\\";
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

        char[] Major = new char[20];
        public string major
        {
            get
            {
                string temp = "";
                for (int i = 0; i < Major.Length; i++)
                {
                    if (Major[i] != '\0')
                        temp += Major[i];
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
                    Major[i] = value[i];
                }
                Major[i] = '\0';
            }
        }

        public double grade;
        public bool isAbleUnitChoice = false;
        public bool isAbleUnitEdit = false;
        public List<StudentCourse> choosenLessons = new List<StudentCourse>(10);
        public List<StudentCourse> passedLessons = new List<StudentCourse>(10);
        public Student()
        {
            firstName = "";
            lastName = "";
            password = "";
            major = "";
    }

        public Student(string firstName, string lastName, string major)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.major = major;
            //Node lastStudentRow = Universal.instance.lastStd;
            //Node lastStudent = lastStudentRow;

            //this.id = Universal.instance.firstStd == null ? 97000000000 : lastStudent.info.id + 1;


            if (Universal.instance.studentTree != null)
            {
                int lastStudentIndex = Universal.instance.studentTree.isEmpty() ? -1 : Universal.instance.studentTree.getLast();
                bool Readable;
                Student newStd = (Student) FileManager.Load(Universal.instance.studentTree, new Student(), out Readable, fileDirectoryPlusName: "stdFile", index:lastStudentIndex);

                if (lastStudentIndex != -1)
                {
                    this.id = newStd.id + 1;
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
                    FileManager.SaveEdited(Universal.instance.studentTree, this, this.id, "stdFile");
                    return 2;
                }
            }
            //End of Method
        }

        public bool addLesson(int code)
        {
            if (isAbleUnitChoice || Universal.instance.isAbleUnitChoice || isAbleUnitEdit || Universal.instance.isAbleUnitEdit)
            {
                Course crs = new Course();
                crs = (Course) FileManager.Load(Universal.instance.courseTree, crs, code, "crsFile");

                if (choosenLessons != null)
                {
                    for (int i = 0; i < choosenLessons.Count; i++)
                    {
                        if (code == this.choosenLessons[i].course.code)
                        {
                            return false;
                        }
                    }
                }


                if (crs.code == code)
                {
                    crs.students.Add(Manager.SearchStudent(id));
                    choosenLessons = choosenLessons == null ? new List<StudentCourse>() : choosenLessons;
                    StudentCourse lsn = new StudentCourse(crs);
                    choosenLessons.Add(lsn);
                    return true;
                }
            }
            return false;
        }
        //End of Method

        public bool removeLesson(int code)
        {
            bool crsFound = false;
            StudentCourse lsn = null;
            int index = Universal.instance.courseTree.get(code);
            if (index != -1) {
                Course crs = new Course();
                FileManager.Load(Universal.instance.courseTree, crs, code, "crsFile");
                crsFound = true;
                lsn = new StudentCourse(crs);

                if ((isAbleUnitChoice || Universal.instance.isAbleUnitChoice || isAbleUnitEdit || Universal.instance.isAbleUnitEdit) && crsFound && choosenLessons.Contains(lsn))
                {
                    crs.students.Remove(Manager.SearchStudent(this.id));
                    choosenLessons.Remove(lsn);
                    return true;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }
    }
}
