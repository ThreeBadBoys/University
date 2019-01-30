using System.Collections.Generic;

namespace UniversityClasses
{
    [System.Serializable]
    class Course
    {
        public string name
        {
            get; set;
        }
        public int code
        {
            get; set;
        }
        public Master master;
        public string time
        {
            get; set;

        }
        public string examTime
        {
            get; set;
        }
        public int val
        {
            get; set;
        }
        public List<Student> students
        {
            get; set;
        }
        public Course(string name, int code, int val, string time, string examTime, Master master)
        {
            this.name = name;
            this.code = code;
            this.val = val;
            this.time = time;
            this.examTime = examTime;
            this.master = master;
            students = new List<Student>();
        }

        public Course()
        {
        }
    }
}
