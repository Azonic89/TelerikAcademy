namespace ChainOfResponsibilityExample
{
    using Entities;

    internal class StartUp
    {
        private static void Main()
        {
            LoyalCitizen captain = new CaptainOfTheGuard();
            LoyalCitizen kingsRightHand = new RightHand();
            LoyalCitizen king = new King();

            captain.SetSuccessor(kingsRightHand);
            kingsRightHand.SetSuccessor(king);

            var purchase = new Requester(2034, 350.00);
            captain.ProcessRequest(purchase);

            purchase = new Requester(2035, 32590.10);
            captain.ProcessRequest(purchase);

            purchase = new Requester(2036, 122100.00);
            captain.ProcessRequest(purchase);
        }
    }
}
