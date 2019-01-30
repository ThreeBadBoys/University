using System;
using System.Collections.Generic;
using University;

namespace UniversityClasses
{
    [System.Serializable]
    class Student
    {const string dir = "C:\\Users\\AliNajafi\\Documents\\University\\University\\bin\\Debug\\";
        public string firstName;
        public string lastName;
        public string password;
        public int id;
        public string major;
        public double grade;
        public bool isAbleUnitChoice = false;
        public bool isAbleUnitEdit = false;
        public List<StudentCourse> choosenLessons;
        public List<StudentCourse> passedLessons;
        public Student()
        {
            firstName = "Fuck";
            lastName = "Fuck";
            password = "Fuck";
            major = "Fuck";
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
                Student newStd = new Student();
                int lastStudentIndex = Universal.instance.studentTree.isEmpty() ? -1 : Universal.instance.studentTree.getLast();
                bool Readable;
                FileManager.Load(Universal.instance.studentTree, newStd, out Readable, fileDirectoryPlusName: dir + "stdFile", index:lastStudentIndex);

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
                FileManager.Load(Universal.instance.courseTree, crs, code, fileDirectoryPlusName: dir + "crsFile");

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
                FileManager.Load(Universal.instance.courseTree, crs, code, fileDirectoryPlusName: dir + "crsFile");
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
