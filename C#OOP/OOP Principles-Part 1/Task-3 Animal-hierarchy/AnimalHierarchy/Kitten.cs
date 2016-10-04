namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Kitten : Cat
    {
        public Kitten(string name, int age, string sex, string gender)
            : base(name, age, "female", gender)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Kitten {0} say: miauuuu", this.Name);
        }
    }
}
