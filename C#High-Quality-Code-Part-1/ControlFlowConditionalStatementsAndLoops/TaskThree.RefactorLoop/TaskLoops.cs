namespace TaskThree.RefactorLoop
{
    using System;

    public class TaskLoops
    {
        internal static void RunLoop(int[] arrayToSearch, int expectedValue)
        {
            var expectedValueIsFound = false;
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(arrayToSearch[i]);

                expectedValueIsFound = CheckIfConditionsAreMet(i, expectedValue, arrayToSearch[i]);
                if (expectedValueIsFound)
                {
                    break;
                }
            }

            if (expectedValueIsFound)
            {
                Console.WriteLine("Value Found");
            }
        }

        internal static void Main()
        {
        }

        private static bool CheckIfConditionsAreMet(int index, int expectedValue, int arrayValue)
        {
            var conditionsAreMet = index % 10 == 0 && arrayValue == expectedValue;

            return conditionsAreMet;
        }
    }
}
