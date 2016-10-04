namespace School.Entities
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentCount = 30;

        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get { return new List<Student>(this.students); }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null!");
            }

            if (this.Students.Count + 1 > Course.MaxStudentCount)
            {
                throw new ArgumentOutOfRangeException("Student course cannot be more than 30 members!");
            }

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException("Cannot add and already existing student to the course!");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be Null!");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("This student is already attending this course!");
            }

            this.students.Remove(student);
        }
    }
}
