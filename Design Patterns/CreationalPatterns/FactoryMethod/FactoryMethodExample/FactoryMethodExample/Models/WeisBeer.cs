namespace FactoryMethodExample.Models
{
    using Contracts;

    public class WeisBeer : IBeer
    {
        public string BeerFunctionality()
        {
            return $"Nice Cold Weis Beer";
        }
    }
}
