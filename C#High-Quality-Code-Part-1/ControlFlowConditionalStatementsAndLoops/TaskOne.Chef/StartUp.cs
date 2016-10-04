namespace TaskOne.Chef
{
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var chef = new Chef("Salty Macannon");
            chef.Introduce();

            var carrot = chef.GetCarrot();
            var potato = chef.GetPotato();
            var bowl = chef.GetBowl();

            chef.Cook(potato, carrot, bowl);
        }
    }
}
