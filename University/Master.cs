using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
    [System.Serializable]
    class Master
    {
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }
        public ulong id
        {

            get; set;
        }
        public string password
        {
            get; set;
        }
        public List<Node<Course>> lessons
        {
            get; set;
        }
        //-------------------------------
        public Master(string firstName, string lastName, List<Node<Course>> lessons)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Node<Master> lastMasterRow = Universal.instance.lastMst;
            Node<Master> lastMaster = lastMasterRow;

            if (Universal.instance.firstMst != null)
            {
                while (lastMaster.next != null)
                {
                    lastMaster = lastMaster.next;
                }
            }
            id = Universal.instance.firstMst == null ? 97000000000 : (lastMaster.info.id + 1);
            password = lastMaster == null ? "97000000000" : (lastMaster.info.id + 1).ToString();
            this.lessons = lessons;
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
        public bool insertingGrade(string id, double grade, int code)
        {
            Node<Student> std = Manager.SearchStudent(id);
            bool found = false;
            int i;
            for (i = 0; i < std.info.choosenLessons.Count; i++)
            {
                if (std.info.choosenLessons[i].course.code == code)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                std.info.choosenLessons[i].grade = grade;
                return true;
            }
            return false;
        }
    }
}


