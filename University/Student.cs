using System;
using System.Collections.Generic;
using University;

namespace UniversityClasses
{
    [System.Serializable]
    class Student
    {
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }
        public string password
        {
            get; set;
        }
        public int id
        {
            get; set;
        }
        public string major;
        public double grade;
        public bool isAbleUnitChoice = false;
        public bool isAbleUnitEdit = false;
        public List<StudentCourse> choosenLessons
        {
            get; set;
        }
        public List<StudentCourse> passedLessons
        {
            get; set;
        }
        public Student()
        {

        }
      
        public Student(string firstName, string lastName, string major)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.major = major;
             int lastManagerID;
            //Node lastStudentRow = Universal.instance.lastStd;
            //Node lastStudent = lastStudentRow;

            //this.id = Universal.instance.firstStd == null ? 97000000000 : lastStudent.info.id + 1;

         
            if (Universal.instance.studentTree != null)
            {
                Student newStd = new Student();
                int lastStudentIndex = Universal.instance.studentTree.getLast();
                FileManager.Load(Universal.instance.studentTree, newStd, lastStudentIndex, fileDirectoryPlusName:);//TODO

                if (lastStudentIndex != -1)
                {
                    this.id = newStd.id + 1;
                    this.password = String.Format("%d", this.id);
                }
                else
                {
                    this.id = 97000;
                    this.password = String.Format("%d", this.id);
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
                Node<Course> plsn = Universal.instance.firstCrs;
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
                while (plsn != null)
                {
                    if (plsn.info.code == code)
                    {
                        plsn.info.students.Add(Manager.SearchStudent(this.id.ToString()));
                        choosenLessons = choosenLessons == null ? new List<StudentCourse>() : choosenLessons;
                        StudentCourse lsn = new StudentCourse(plsn.info);
                        this.choosenLessons.Add(lsn);
                        return true;
                    }
                    plsn = plsn.next;
                }
                return false;
            }
            else return false;
            //End of Method
        }

        public bool removeLesson(int code)
        {
            Node<Course> plsn = Universal.instance.firstCrs;
            StudentCourse lsn = null;
            bool crsFound = false;
            while (plsn != null)
            {
                if (plsn.info.code == code)
                {
                    crsFound = true;
                    lsn = new StudentCourse(plsn.info);
                    break;
                }
                plsn = plsn.next;
            }
            if ((isAbleUnitChoice || Universal.instance.isAbleUnitChoice || isAbleUnitEdit || Universal.instance.isAbleUnitEdit) && crsFound && choosenLessons.Contains(lsn))
            {
                plsn.info.students.Remove(Manager.SearchStudent(this.id);
                choosenLessons.Remove(lsn);
                return true;
            }
            else return false;
        }
    }
}
