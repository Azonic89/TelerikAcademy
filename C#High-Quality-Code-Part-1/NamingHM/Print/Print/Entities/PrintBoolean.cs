namespace Print.Entities
{
    using System;

    internal class PrintBoolean
    {
        internal void PrintBoolAsAString(bool value)
        {
            var booleanString = value.ToString();

            Console.WriteLine(booleanString);
        }
    }
}
