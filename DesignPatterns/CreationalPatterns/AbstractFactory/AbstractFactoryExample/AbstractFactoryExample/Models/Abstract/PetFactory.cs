namespace AbstractFactoryExample.Models.Abstract
{
    public abstract class PetFactory
    {
        protected PetFactory()
        {
        }

        public abstract Dog GetDog();

        public abstract Cat GetCat();
    }
}
