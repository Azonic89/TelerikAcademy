namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string sex;

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name required");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Animal age cannot be zero or negative");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Sex
        {
            get { return this.sex; }
            set
            {
                if (value == null || (value != "male" && value != "female"))
                {
                    throw new ArgumentNullException("Animal sex cannot be null or different from male or female!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }

        public abstract void Sound();
        
        public static double CalculateAverageAge(Animal[] animal)
        {
            double sum = 0;

            foreach (var element in animal)
            {
                sum += element.Age;
            }

            double result = sum / animal.Length;
            return result;
        }
    }
}
