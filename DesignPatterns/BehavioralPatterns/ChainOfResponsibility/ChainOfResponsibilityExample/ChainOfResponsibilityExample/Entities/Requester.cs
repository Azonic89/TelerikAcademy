namespace ChainOfResponsibilityExample.Entities
{
    internal class Requester
    {
        public Requester(int number, double amount)
        {
            this.Number = number;
            this.Amount = amount;
        }

        public int Number { get; set; }

        public double Amount { get; set; }
    }
}
