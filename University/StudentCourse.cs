using System.Collections.Generic;

namespace UniversityClasses
{
    [System.Serializable]
    class StudentCourse
    {
        public double grade
        {
            get; set;
        }
        public Course course;
        public StudentCourse(Course course)
        {
            this.course = course;
        }
    }
}
