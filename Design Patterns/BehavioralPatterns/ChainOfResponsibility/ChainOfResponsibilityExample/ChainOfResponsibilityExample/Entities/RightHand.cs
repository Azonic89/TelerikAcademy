namespace ChainOfResponsibilityExample.Entities
{
    using System;

    internal class RightHand : LoyalCitizen
    {
        public override void ProcessRequest(Requester request)
        {
            if (request.Amount < 25000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request #{request.Number}");
            }
            else if (this.Successor != null)
            {
                this.Successor.ProcessRequest(request);
            }
        }
    }
}
