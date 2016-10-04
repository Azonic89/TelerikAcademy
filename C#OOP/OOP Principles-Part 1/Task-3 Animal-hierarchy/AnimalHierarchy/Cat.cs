namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Cat : Animal
    {
        private string catBreed;

        public Cat(string name, int age, string sex, string catBreed)
            :base(name, age, sex)
        {
            this.CatBreed = catBreed;
        }

        public string CatBreed
        {
            get { return this.catBreed; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cat breed required");
                }
                else
                {
                    this.catBreed = value;
                }
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Cat {0} say: miaowwww", this.Name);
        }
    }
}
