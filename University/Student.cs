using System.Collections.Generic;

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
        public ulong id
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
            Node lastStudentRow = Universal.instance.lastStd;
            Node lastStudent = lastStudentRow;
          
            this.id = Universal.instance.firstStd == null ? 97000000000 : lastStudent.info.id + 1;

            this.password = lastStudent == null ? "9700" : (lastStudent.info.id + 1).ToString();


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
                plsn.info.students.Remove(Manager.SearchStudent(this.id.ToString()));
                choosenLessons.Remove(lsn);
                return true;
            }
            else return false;
        }
    }
}
