namespace School.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private string name;
        private ICollection<Course> courses;
        private ICollection<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("School Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get { return new List<Course>(this.courses); }
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

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException("This student alreaedy exists in the current school.");
            }

            if (this.Students.Any(s => s.Id == student.Id))
            {
                throw new InvalidOperationException("Already a student with the same ID!");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null!");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("No such student exists in the school at the moment!");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null!");
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course already exists within the school!");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null!");
            }

            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("There is no such course!");
            }

            this.courses.Remove(course);
        }
    }
}
