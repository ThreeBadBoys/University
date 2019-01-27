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
        public ulong id
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
        public Master(string firstName, string lastName, List<Course> lessons)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.lessons = lessons;
            
            ulong lastMasterID;

            if (Universal.instance.masterTree != null)
            {
                string lastMasterAddress = Universal.instance.masterTree.getLast();
                if(lastMasterAddress != null)
                {
                    try
                    {
                        FileStream file = File.Open(lastMasterAddress, FileMode.Open);
                        lastMasterID = UInt64.Parse(lastMasterAddress.Substring(4)) + 1;
                    }
                    catch
                    {
                        lastMasterID = UInt64.Parse(lastMasterAddress.Substring(4));
                    }
                }
                else
                {
                    lastMasterID = 9700000000;
                }
            }
            else
            {
                lastMasterID = 9700000000;
            }
            id = lastMasterID;
            password = lastMasterID + "";
            
            FileStream master = File.Create("mst\\"+ lastMasterID);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(master, this);
            master.Close();
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


