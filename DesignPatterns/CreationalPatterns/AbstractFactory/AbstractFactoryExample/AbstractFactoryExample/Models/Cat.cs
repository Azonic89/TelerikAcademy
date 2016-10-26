namespace AbstractFactoryExample.Models
{
    using Abstract;

    public class Cat : Pet
    {
        public Cat(string breed, string color, string gender) 
            : base(breed, color, gender)
        {
        }
    }
}
