namespace ChainOfResponsibilityExample.Entities
{
    using System;

    internal class King : LoyalCitizen
    {
        public override void ProcessRequest(Requester request)
        {
            if (request.Amount < 100000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request #{request.Number}");
            }
            else
            {
                Console.WriteLine($"Request #{request.Number} requires a heroic meeting in the Great Palace Hall!");
            }
        }
    }
}
