namespace DecoratorExample
{
    using System;

    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var book = new Book("Roy Osherove", "The Art Of Unit Testing", 12);
            book.Display();

            var video = new Video("Mary Lambert", "It", 23, 92);
            video.Display();

            Console.WriteLine("\nMaking video borrowable:");

            var borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Stamat Hinknov");
            borrowableVideo.BorrowItem("Gosho Peshev");

            borrowableVideo.Display();
        }
    }
}
