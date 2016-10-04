namespace Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 1 || 12 < value)
                {
                    throw new ArgumentException("Grade out of range");
                }
                else
                {
                    this.grade = value;
                }
            }
        }
    }
}
