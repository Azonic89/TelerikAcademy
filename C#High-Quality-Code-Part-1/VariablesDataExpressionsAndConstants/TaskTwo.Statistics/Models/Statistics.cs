namespace TaskTwo.Statistics.Models
{
    using System.Linq;

    using Contracts;

    public class Statistics
    {
        private const char ConsoleSeparatorCharacter = '-';
        private const int ConsoleSeparatorRepearCount = 50;
        private readonly IPrinter consolePrinter;

        public Statistics()
        {
            this.consolePrinter = new ConsolePrinter();
        }

        public void PrintStatistics(double[] statistics)
        {
            var maxValue = statistics.Max().ToString("0.00");
            var minValue = statistics.Min().ToString("0.00");
            var avgValue = statistics.Average().ToString("0.00");

            var separator = new string(ConsoleSeparatorCharacter, ConsoleSeparatorRepearCount);

            this.consolePrinter.Print("The statistics are showing the following result");
            this.consolePrinter.Print(separator);

            this.consolePrinter.Print($"Maximum value is {maxValue}");
            this.consolePrinter.Print($"Minimum value is {minValue}");
            this.consolePrinter.Print($"The Average value is {avgValue}");
        }
    }
}
