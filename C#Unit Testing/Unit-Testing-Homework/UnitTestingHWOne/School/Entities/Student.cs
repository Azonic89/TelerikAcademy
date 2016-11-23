namespace School.Entities
{
    using System;

    public class Student
    {
        private const int MinValidID = 10000;
        private const int MaxValidID = 99999;

        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < Student.MinValidID || value > Student.MaxValidID)
                {
                    throw new InvalidOperationException(string.Format("Student ID must be between {0} and {1}!", Student.MinValidID, Student.MaxValidID));
                }

                this.id = value;
            }
        }

        public void AttendCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null!");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null!");
            }

            course.RemoveStudent(this);
        }
    }
}
