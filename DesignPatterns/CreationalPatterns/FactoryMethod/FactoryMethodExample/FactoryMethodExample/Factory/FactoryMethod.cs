namespace FactoryMethodExample.Factory
{
    using Contracts;
    using Models;

    public static class FactoryMethod
    {
        public static IBeer Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new DarkBeer();
                case 1:
                    return new WeisBeer();
                case 2:
                    return new PilsnerBeer();
                default:
                    return null;
            }
        }
    }
}
