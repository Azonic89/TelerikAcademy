namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Startup
    {
        static void Main()
        {
            Dog[] dogs = new Dog[]
            {
                new Dog("Balkan", 2, "male", "ulichna"),
                new Dog("Pesho", 2, "male", "pincher"),
                new Dog("Rexy", 1, "male", "Deutscher Schäferhund")
            };

            Cat[] cats = new Cat[]
            {
                new Cat("Maca", 3, "female", "siamka"),
                new Cat("Pena", 2, "female", "persiika"),
                new Cat("Minka", 1, "female", "siamka")
            };

            Tomcat tom = new Tomcat("Tom", 2, "male", "wow");
            Kitten kitty = new Kitten("Asya", 2, "female", "Little kitty");

            Frog[] frogs = new Frog[]
            {
                new Frog("Jabcho", 3, "male", "Green frog"),
                new Frog("Pesho", 2, "male", "Red frog"),
                new Frog("Minka", 1, "female", "Pink frog")
            };

            Console.WriteLine("Average age of dogs are: " + Dog.CalculateAverageAge(dogs));
            dogs[0].Sound();
            dogs[1].Sound();
            dogs[2].Sound();

            Console.WriteLine();
            
            Console.WriteLine("Average age of cats are: " + Cat.CalculateAverageAge(cats));
            cats[0].Sound();
            cats[1].Sound();
            cats[2].Sound();

            Console.WriteLine();

            Console.WriteLine("Average age of frogs are: " + Frog.CalculateAverageAge(frogs));
            frogs[0].Sound();
            frogs[1].Sound();
            frogs[2].Sound();

            Console.WriteLine();
        }
    }
}
