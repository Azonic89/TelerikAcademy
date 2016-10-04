namespace StudentsInfo
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string telephone;
        private string email;
        private List<int> marks;
        private Group groupNumber;

        public Student(string firstname, string lastname, string fn, string telephone, string email, List<int> marks, Group groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Fn = fn;
            this.Telephone = telephone;
            this.Email = email;
            this.marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set{ this.firstName = value; }                        
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last Name cannot be a null Value!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Fn
        {
            get { return this.fn; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Faculty number cannot be a null Value!");
                }
                else
                {
                    this.fn = value;
                }
            }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Telephone cannot be a null Value!");
                }
                else
                {
                    this.telephone = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Email cannot be a null Value!");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }
        }

        public Group GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                this.groupNumber = value;
            }
        }
    }
}
