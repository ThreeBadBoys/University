using System;
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
        public uint id
        {
            get; set;
        }
        //-----------------------------------------
        //Constructors
        public Manager(string firstName, string lastName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            ulong lastManagerID;

            if (Universal.instance.managerTree != null)
            {
                string lastManagerAddress = Universal.instance.managerTree.getLast();
                if (lastManagerAddress != null)
                {
                    try
                    {
                        FileStream file = File.Open(lastManagerAddress, FileMode.Open);
                        lastManagerID = UInt64.Parse(lastManagerAddress.Substring(4)) + 1;
                    }
                    catch
                    {
                        lastManagerID = UInt64.Parse(lastManagerAddress.Substring(4));
                    }
                }
                else
                {
                    lastManagerID = 9700000000;
                }
            }
            else
            {
                lastManagerID = 9700000000;
            }

            id = lastManagerID;

            FileStream manager = File.Create("mng\\" + lastManagerID);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(manager, this);
            manager.Close();
        }
        public Manager()
        {
            firstName = "admin";
            lastName = "admin";
            password = "1234";
            id = 970000000;
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
                //    //Now Here we have to check the Tree
                //    if (Universal.instance.studentTree == null)
                //     {
                //        BTree newStudent = new BTree();
                //        newStudent.put(student.id + "", "std\\" + student.id);
                //        Universal.instance.studentTree = newStudent;
                //    }
                //   else
                //   {
                //       Universal.instance.studentTree.put(student.id + "", "std\\" + student.id);
                //  }
                //   FileStream file = File.Create("std\\" + student.id);
                //   BinaryFormatter bf = new BinaryFormatter();
                //    bf.Serialize(file, student);
                //   file.Close();

                FileManager.Add<Student>(Universal.instance.studentTree, student, student.id, fileDirectoryPlusName:);
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
                FileManager.Add<Master>(Universal.instance.studentTree, master, master.id, fileDirectoryPlusName:);//TODO
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
                FileManager.Add<Manager>(Universal.instance.studentTree, manager, manager.id, fileDirectoryPlusName:);//TODO
                return true;
            }
            else
            {
                return false;
            }
            //End of Method
        }
        public bool AddCourse(String code, String name, int mstId, String time, String examTime, int val)
        {
            if (isValidName(name) && isNumber(code) && (SearchMaster(mstId) != null))
            {
                //We have to check if master exists
                Master mst = SearchMaster(mstId);
                if (mst != null)
                {
                    Course course = new Course(name.Trim(), Convert.ToInt32(code.Trim()), val, time, examTime, SearchMaster(mstId));
                    //Now Here we have to check the Tree
                    //   if (Universal.instance.courseTree == null)
                    //   {
                    //      BTree newCourse = new BTree();
                    //      newCourse.put(course.code + "", "crs\\" + course.code);
                    //      Universal.instance.studentTree = newCourse;
                    //  }
                    //  else
                    //  {
                    //      Universal.instance.studentTree.put(course.code + "", "crs\\" + course.code);
                    //  }
                    //  mst.lessons.Add(course);
                    // FileStream file = File.Create("crs\\" + course.code);
                    //  BinaryFormatter bf = new BinaryFormatter();
                    //  bf.Serialize(file, course);
                    //  file.Close();
                    FileManager.Add<Course>(Universal.instance.studentTree, course, course.code, fileDirectoryPlusName:);//TODO
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
            Student student = new Student();
            FileManager.Load(Universal.instance.studentTree, student, id, fileDirectoryPlusName:);//TODO
            return student;
            //End of Method
        }
        public static Master SearchMaster(int id)
        {
            Master master = new Master();
            FileManager.Load(Universal.instance.masterTree, master, id, fileDirectoryPlusName:);//TODO
            return master;
            //End of Method
        }
        public static Manager SearchManager(string id)
        {
            Manager manager = new Manager();
            FileManager.Load(Universal.instance.managerTree, manager, id, fileDirectoryPlusName:);//TODO
            return manager;
            //End of Method
        }

        /**
         * This function removes student key in BTree and removes related file
         */
        public bool RemoveStudentFully(uint id)
        {                                                                               //CHECK IT\|/
            if (Universal.instance != null && Universal.instance.studentTree != null && id.Length == 11)// Checking whether we have student or not
            {
                string address = Universal.instance.studentTree.get(id.ToString());
                if (address == null) return false;
                File.Delete(address);
                Universal.instance.studentTree.delete(id.ToString());
                //Student deleted successfully
                FileManager.Remove(Universal.instance.studentTree,, id, fileDirectoryPlusName:);
                return true;
            }
            else
            {
                //Showing Error that the entered id is wrong or threre is no student added
                return false;
            }
            //End of Method
        } }

        public bool RemoveMasterFully(string id)
        {
            if (Universal.instance.firstMst != null && isNumber(id))// Checking whether we have master or not
            {
                if (Universal.instance.firstMst.next != null || Universal.instance.firstMst.nextRow != null)//Checking if we have more than one master 
                {
                    if (Convert.ToUInt64(id) == Universal.instance.firstMst.info.id)  //Means that we wanna delete the first master
                    {
                        RowNode<Master> newfirstRowNode = new RowNode<Master>();
                        newfirstRowNode.info = Universal.instance.firstMst.next.info;
                        newfirstRowNode.next = Universal.instance.firstMst.next.next;
                        newfirstRowNode.nextRow = Universal.instance.firstMst.nextRow;
                        Universal.instance.firstMst = newfirstRowNode;
                        return true;
                    }
                    else if (Convert.ToUInt64(id) == Universal.instance.lastMst.info.id)//Means that we wanna delete the last master
                    {
                        RowNode<Master> newlastRowNode = new RowNode<Master>();
                        if (Universal.instance.lastMst.next != null) // Checking if we have convertable node to RowNode
                        {
                            newlastRowNode.info = Universal.instance.lastMst.next.info;
                            newlastRowNode.next = Universal.instance.lastMst.next.next;
                            Universal.instance.lastMst = newlastRowNode;
                            return true;
                        }
                        else // Here we don't have convertable node to RowNode
                        {
                            RowNode<Master> lastMst = Universal.instance.firstMst;
                            while (lastMst.nextRow != null && lastMst.nextRow.nextRow != null)
                            {
                                lastMst = lastMst.nextRow;
                            }
                            Universal.instance.lastMst = lastMst;
                            return true;
                        }
                    }
                    else // Here we want to delete the masters in which there are at the Middle Nodes
                    {
                        Node<Master> pre;
                        pre = SearchPrevMaster(id);
                        if (pre != null) //if the master exists
                        {
                            if (pre is RowNode<Master>)//Prev is RowNode
                            {
                                RowNode<Master> prev = pre as RowNode<Master>;
                                if (prev.nextRow.info.id == Convert.ToUInt64(id))//Deleting node is nextRowNode
                                {
                                    if (prev.nextRow.next != null)//if the deleting RowNode has nextNode
                                    {
                                        prev.nextRow.info = prev.nextRow.next.info;
                                        prev.nextRow.next = prev.nextRow.next.next;
                                    }
                                    else //deleting RowNode doesn't have nextNode
                                    {
                                        prev.nextRow = prev.nextRow.nextRow;
                                    }
                                }
                                else // Deleting node is nextNode
                                {
                                    prev.next = prev.next.next;
                                }
                            }
                            else //Prev is usual node
                            {
                                pre.next = pre.next.next;
                            }
                            return true;
                        }
                        else // master doesn't exist
                        {
                            return false;
                        }
                    }
                }
                else // We have just one master 
                {
                    Universal.instance.firstMst = Universal.instance.lastMst = null;
                    return true;
                }
            }
            else
            {
                //Showing Error that the insterted id is wrong or threre is no master added
                return false;
            }
            //End of Method
        }
        public bool RemoveManagerFully(string id)
        {
            if (Universal.instance.firstMng != null && isNumber(id))// Checking whether we have manager or not
            {
                if (Universal.instance.firstMng.next != null || Universal.instance.firstMng.nextRow != null)//Checking if we have more than one manager 
                {
                    if (Convert.ToUInt64(id) == Universal.instance.firstMng.info.id)  //Means that we wanna delete the first manager
                    {
                        RowNode<Manager> newfirstRowNode = new RowNode<Manager>();
                        newfirstRowNode.info = Universal.instance.firstMng.next.info;
                        newfirstRowNode.next = Universal.instance.firstMng.next.next;
                        newfirstRowNode.nextRow = Universal.instance.firstMng.nextRow;
                        Universal.instance.firstMng = newfirstRowNode;
                        return true;
                    }
                    else if (Convert.ToUInt64(id) == Universal.instance.lastMng.info.id)//Means that we wanna delete the last manager
                    {
                        RowNode<Manager> newlastRowNode = new RowNode<Manager>();
                        if (Universal.instance.lastMng.next != null) // Checking if we have convertable node to RowNode
                        {
                            newlastRowNode.info = Universal.instance.lastMng.next.info;
                            newlastRowNode.next = Universal.instance.lastMng.next.next;
                            Universal.instance.lastMng = newlastRowNode;
                            return true;
                        }
                        else // Here we don't have convertable node to RowNode
                        {
                            RowNode<Manager> lastMng = Universal.instance.firstMng;
                            while (lastMng.nextRow != null && lastMng.nextRow.nextRow != null)
                            {
                                lastMng = lastMng.nextRow;
                            }
                            Universal.instance.lastMng = lastMng;
                            return true;
                        }
                    }
                    else // Here we want to delete the masters in which there are at the Middle Nodes
                    {
                        Node<Manager> pre;
                        pre = SearchPrevManager(id);
                        if (pre != null) //if the master exists
                        {
                            if (pre is RowNode<Manager>)//Pre is RowNode
                            {
                                RowNode<Manager> prev = pre as RowNode<Manager>;
                                if (prev.nextRow.info.id == Convert.ToUInt64(id))//Deleting node is nextRowNode
                                {
                                    if (prev.nextRow.next != null)//if the deleting RowNode has nextNode
                                    {
                                        prev.nextRow.info = prev.nextRow.next.info;
                                        prev.nextRow.next = prev.nextRow.next.next;
                                    }
                                    else //deleting RowNode doesn't have nextNode
                                    {
                                        prev.nextRow = prev.nextRow.nextRow;
                                    }
                                }
                                else // Deleting node is nextNode
                                {
                                    prev.next = prev.next.next;
                                }
                            }
                            else //Prev is usual node
                            {
                                pre.next = pre.next.next;
                            }
                            return true;
                        }
                        else // master doesn't exist
                        {
                            return false;
                        }
                    }
                }
                else // We have just one master 
                {
                    Universal.instance.firstMng = Universal.instance.lastMng = null;
                    return true;
                }
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
            Universal.instance.isAbleUnitChoice = true;
            //End of Method
        }
        public void DesablingUnitChoice()
        {
            Universal.instance.isAbleUnitChoice = false;
            //End of Method
        }
        public static bool isNumber(string id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] < 48 || id[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isValidName(string name)
        {
            if (name == "") return false;
            return true;
        }
        public bool RemoveStudentsSemester(String id)
        {
            Node<Student> std;
            std = SearchStudent(id);
            if (std != null)
            {
                std.info.choosenLessons.Clear();
                return true;
            }
            return false;
            //End of Method
        }
        public void EndingSemester()
        {
            RowNode<Student> pstd = Universal.instance.firstStd;
            Node<Student> std = pstd;
            while (pstd != null)
            {
              
                if (std.info.choosenLessons != null && std.info.choosenLessons.Count != 0)
                {
                    while (std != null)
                    {

                        for (int i = 0; i < std.info.choosenLessons.Count; i++)
                        {
                            if (std.info.choosenLessons[i].grade > 10)
                            {
                                std.info.passedLessons = std.info.passedLessons == null ? new List<StudentCourse>() : std.info.passedLessons;
                                std.info.passedLessons.Add(std.info.choosenLessons[i]);
                            }
                        }
                        std.info.choosenLessons.Clear();
                        std = std.next;

                    }
                }
                pstd = pstd.nextRow;
            }
            //End of Method
        }
    }

}
