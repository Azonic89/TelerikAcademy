namespace FacadeExample.Models
{
    using System;

    /// <summary>
    /// Facade
    /// </summary>
    public class HomeVideoSystem
    {
        private static HomeVideoSystem instance;
        private readonly Database database = new Database();
        private readonly Player player = new Player();
        private readonly RemoteController remoteController = new RemoteController();

        private HomeVideoSystem()
        {
            this.SeedDatabase();
        }

        public static HomeVideoSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new HomeVideoSystem();
            }

            return instance;
        }
   
        public void DisplayAvailableMedia()
        {
            var allMedia = this.database.GetAvailableMedia();

            foreach (var entity in allMedia)
            {
                Console.WriteLine($"{entity.Title} - {entity.FileExtention} minutes");
            }
        }

        public void InitHomeSystem()
        {
            Console.WriteLine();
            Console.WriteLine(string.Empty.PadLeft(50, '|'));
            Console.WriteLine();
            this.remoteController.DimLights(24);
            this.remoteController.MoveCurtains(17);
            this.remoteController.HideTable();
            Console.WriteLine();
            Console.WriteLine(string.Empty.PadLeft(50, '|'));
            Console.WriteLine();
            this.LoadMedia();
            Console.WriteLine();
            Console.WriteLine(string.Empty.PadLeft(50, '|'));
            Console.WriteLine();
            this.player.Play();
        }

        public void Next()
        {
            this.player.Next();
            this.player.Play();
        }

        public void Previous()
        {
            this.player.Previous();
            this.player.Play();
        }

        public void Stop()
        {
            this.player.Stop();
        }

        private void SeedDatabase()
        {
            this.database.Add(new MediaEntity
            {
                Title = "The Matrix",
                FileExtention = "avi",
                Duration = 220,
                Content = new byte[200]
            });

            this.database.Add(new MediaEntity
            {
                Title = "The Shawshank Redemption",
                FileExtention = "mkv",
                Duration = 170,
                Content = new byte[200]
            });

            this.database.Add(new MediaEntity
            {
                Title = "Star Wars Full Saga",
                FileExtention = "avi",
                Duration = 600,
                Content = new byte[200]
            });

            this.database.Add(new MediaEntity
            {
                Title = "The American Gangster",
                FileExtention = "avi",
                Duration = 160,
                Content = new byte[200]
            });

            this.database.Add(new MediaEntity
            {
                Title = "The next three days",
                FileExtention = "mpeg",
                Duration = 160,
                Content = new byte[200]
            });
        }

        private void LoadMedia()
        {
            var allMedia = this.database.GetAvailableMedia();

            foreach (var entity in allMedia)
            {
                this.player.Load(entity);
            }
        }        
    }
}
