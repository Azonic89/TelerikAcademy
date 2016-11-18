namespace FacadeExample
{
    using Models;

    public class StartUp
    {
        private static void Main()
        {
            var homeVideoSystem = HomeVideoSystem.GetInstance();

            homeVideoSystem.InitHomeSystem();
            homeVideoSystem.Next();
            homeVideoSystem.Next();
            homeVideoSystem.Stop();
        }
    }
}
