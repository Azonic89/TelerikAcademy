namespace SinglenPatternExample
{
    using System;

    using Models;

    public class StartUp
    {
        private static void Main()
        {
            Calculate.Instance.ValueOne = 15;
            Calculate.Instance.ValueTwo = 4.3;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());

            Console.WriteLine(new string('-', 30));

            Calculate.Instance.ValueTwo = 10.5;

            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());

            Console.WriteLine(new string('-', 30));

            Calculate.Instance.ValueOne = 3;

            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());

            Console.ReadLine();
        }
    }
}
