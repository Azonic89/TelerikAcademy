namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Dog : Animal
    {
        private string dogBreed;

        public Dog(string name, int age, string sex, string dogBreed)
            : base(name, age, sex)
        {
            this.DogBreed = dogBreed;
        }

        public string DogBreed
        {
            get { return this.dogBreed; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Dog breed required");
                }
                else
                {
                    this.dogBreed = value;
                }
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Dog {0} say: bow-wowwww", this.Name);
        }
    }
}
