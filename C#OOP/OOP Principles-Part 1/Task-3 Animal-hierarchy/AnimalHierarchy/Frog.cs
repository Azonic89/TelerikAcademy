namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Frog : Animal
    {
        private string frogBreed;

        public Frog(string name, int age, string sex, string frogBreed)
            : base(name, age, sex)
        {
            this.FrogBreed = frogBreed;
        }

        public string FrogBreed
        {
            get { return this.frogBreed; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Frog breed required");
                }
                else
                {
                    this.frogBreed = value;
                }
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Frog {0} say: rrrrrrrrr", this.Name);
        }
    }
}
