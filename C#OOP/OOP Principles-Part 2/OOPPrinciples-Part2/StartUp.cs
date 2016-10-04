namespace OOPPrinciples_Part2
{
    using BankAccounts;
    using RangeExceptions;
    using Shapes;

    public class StartUp
    {
        static void Main()
        {
            ShapesRunTest.Run();
            BankAccountsRunTest.Run();
            RangeExceptionsTest.Run();
        }
    }
}
