namespace AbstractFactoryExample.Models.Factories
{
    using Abstract;

    public class AnotherPetShop : PetFactory
    {
        public override Dog GetDog()
        {
            return new Dog("Golden Retriever", "Brown", "Male");
        }

        public override Cat GetCat()
        {
            return new Cat("Angolian", "Pink", "Female");
        }
    }
}
