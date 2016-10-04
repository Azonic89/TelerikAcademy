namespace Common_Type_System.Models
{
    using System;
    using System.Text;

    public class Person
    {
        private string fullName;
        private int? age;

        public Person(string fullName, int? age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The Name of the person cannot be null!");
                }
                else
                {
                    this.fullName = value;
                }
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0 && value >= 100)
                {
                    throw new ArgumentException("Age cannot be less than 0 or bigger than 100!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine("Full Name: " + this.FullName);

            if (Age == null)
            {
                output.AppendLine("Age: null!!!Not specified");
            }
            else
            {
                output.AppendLine("Age: " + this.Age);
            }
            return output.ToString();
        }
    }
}
