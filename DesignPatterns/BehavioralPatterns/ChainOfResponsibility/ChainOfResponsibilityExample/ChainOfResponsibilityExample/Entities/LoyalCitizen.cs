namespace ChainOfResponsibilityExample.Entities
{
    internal abstract class LoyalCitizen
    {
        protected LoyalCitizen Successor { get; set; }

        public void SetSuccessor(LoyalCitizen successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Requester request);
    }
}
