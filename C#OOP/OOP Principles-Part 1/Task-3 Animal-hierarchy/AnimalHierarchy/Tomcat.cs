namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string sex, string breed)
            :base(name, age, "male", breed)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Tomcat {0} say: miauuuuu", this.Name);
        }
    }
}
