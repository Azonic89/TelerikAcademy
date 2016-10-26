namespace AbstractFactoryExample.Models
{
    using System;

    using Abstract;

    public class PetWalkingService
    {
        private readonly PetFactory factory;

        public PetWalkingService(PetFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            this.factory = factory;
        }

        public Dog WalkDog()
        {
            return this.factory.GetDog();
        }

        public Cat WalkCat()
        {
            return this.factory.GetCat();
        }
    }
}
