namespace AbstractFactoryExample
{
    using System;
    using Models;
    using Models.Factories;

    public class StartUp
    {
        private static void Main()
        {
            var petService = new PetWalkingService(new PetShop());

            Console.WriteLine(petService.WalkDog());

            Console.WriteLine(new string('*', 30));
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();

            Console.WriteLine(petService.WalkCat());
        }
    }
}
