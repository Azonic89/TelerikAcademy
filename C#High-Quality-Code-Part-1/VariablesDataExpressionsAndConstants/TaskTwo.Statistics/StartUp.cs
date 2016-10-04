namespace TaskTwo.Statistics
{
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var statisctic = new double[] { 7.826, 2.57, 4.032, 90.40, 77.66, 99.679, 0.902, -35.5678043 };
            var statViewer = new Statistics();

            statViewer.PrintStatistics(statisctic);
        }
    }
}
