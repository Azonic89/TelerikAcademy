namespace FactoryMethodExample.Models
{
    using Contracts;

    public class DarkBeer : IBeer
    {
        public string BeerFunctionality()
        {
            return $"Nice Cold Dark Beer";
        }
    }
}
