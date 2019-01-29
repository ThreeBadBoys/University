using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using University;
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
        public int id
        {

            get; set;
        }
        public string password
        {
            get; set;
        }
        public List<Course> lessons
        {
            get; set;
        }
        //-------------------------------
        public Master()
        {

        }

        public Master(string firstName, string lastName, List<Course> lessons)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.lessons = lessons;
         

            if (Universal.instance.masterTree != null)
            {
                Master newStd = new Master();
                int lastMasterIndex = Universal.instance.masterTree.getLast();
                FileManager.Load(Universal.instance.masterTree, newStd, lastMasterIndex, fileDirectoryPlusName:);//TODO

                if (lastMasterIndex != -1)
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


