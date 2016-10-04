namespace ExtractStudents
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string groupName;

        public Student(string firstName, string lastName, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupName = groupName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string GroupName
        {
            get { return this.groupName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.groupName = value;
                }
            }
        }
    }
}
