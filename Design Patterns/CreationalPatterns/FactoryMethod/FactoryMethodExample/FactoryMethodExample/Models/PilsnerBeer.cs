namespace FactoryMethodExample.Models
{
    using Contracts;

    public class PilsnerBeer : IBeer 
    {
        public string BeerFunctionality()
        {
            return $"Nice Cold Pilsner Beer";
        }
    }
}
