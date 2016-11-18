namespace AbstractFactoryExample.Models.Factories
{
    using Abstract;

    public class PetShop : PetFactory
    {
        public override Dog GetDog()
        {
            return new Dog("Shi-Tzy", "White", "Female");
        }

        public override Cat GetCat()
        {
            return new Cat("Muayyy", "Black", "Female");
        }
    }
}
