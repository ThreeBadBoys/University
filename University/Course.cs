using System.Collections.Generic;

namespace UniversityClasses
{
    [System.Serializable]
    class Course
    {
        public int code;
        public Master master = new Master();
        public int val;

        char[] Name = new char[20];
        public string name
        {
            get
            {
                string temp = "";
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name[i] != '\0')
                        temp += Name[i];
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
                    Name[i] = value[i];
                }
                Name[i] = '\0';
            }
        }

        char[] Time = new char[20];
        public string time
        {
            get
            {
                string temp = "";
                for (int i = 0; i < Time.Length; i++)
                {
                    if (Time[i] != '\0')
                        temp += Time[i];
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
                    Time[i] = value[i];
                }
                Time[i] = '\0';
            }
        }

        char[] ExamTime = new char[20];
        public string examTime
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ExamTime.Length; i++)
                {
                    if (ExamTime[i] != '\0')
                        temp += ExamTime[i];
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
                    ExamTime[i] = value[i];
                }
                ExamTime[i] = '\0';
            }
        }

        public List<Student> students = new List<Student>(45);

        public Course(string name, int code, int val, string time, string examTime, Master master)
        {
            this.name = name;
            this.code = code;
            this.val = val;
            this.time = time;
            this.examTime = examTime;
            this.master = master;
        }

        public Course()
        {
            this.name = "";
            this.time = "";
            this.examTime = "";
        }
    }
}
