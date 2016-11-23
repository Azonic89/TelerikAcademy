namespace Print
{
    using Entities;

    public class StartUp
    {
        public static void Main()
        {
            var print = new PrintBoolean();

            print.PrintBoolAsAString(true);
        }
    }
}
