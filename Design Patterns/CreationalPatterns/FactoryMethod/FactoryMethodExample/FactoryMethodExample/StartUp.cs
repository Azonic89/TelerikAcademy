namespace FactoryMethodExample
{
    using System;

    using Factory;

    public class StartUp
    {
        private static void Main()
        {
            for (var i = 0; i <= 3; i++)
            {
                var type = FactoryMethod.Get(i);
                if (type != null)
                {
                    Console.WriteLine("This is this BEER: " + type.BeerFunctionality());
                }
            }
        }
    }
}
