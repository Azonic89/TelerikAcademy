using System;
using Methods.OtherInfo;
using Methods.Students;
using Methods.Utils;

namespace Methods
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(CalculationHelpers.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(CalculationHelpers.DigitToWord(5));

            Console.WriteLine(CalculationHelpers.FindMaximumValue(5, -1, 3, 2, 14, 2, 3));

            ConsoleWriter.PrintAsNumber(1.3, "f");
            ConsoleWriter.PrintAsNumber(0.75, "%");
            ConsoleWriter.PrintAsNumber(2.30, "r");

            bool horizontal;
            bool vertical;
            Console.WriteLine(CalculationHelpers.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            var peterOtherInfo = new PersonalInformation("From Paris, born on 10.10.2010");
            Student peter = new Student("Pesho", "Peshov", peterOtherInfo);

            var stellaOtherInfo = new PersonalInformation("From Vraca, gamer, high results, born at 03.11.1993");
            Student stella = new Student("Stella", "Peshova", stellaOtherInfo);

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
