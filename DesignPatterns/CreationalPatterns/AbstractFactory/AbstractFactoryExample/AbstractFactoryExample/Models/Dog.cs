namespace AbstractFactoryExample.Models
{
    using Abstract;

    public class Dog : Pet
    {
        public Dog(string breed, string color, string gender)
            : base(breed, color, gender)
        {
        }
    }
}
