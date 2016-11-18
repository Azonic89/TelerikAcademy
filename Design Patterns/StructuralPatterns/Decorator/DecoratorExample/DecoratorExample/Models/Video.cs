namespace DecoratorExample.Models
{
    using System;

    public class Video : BorrowableItem
    {
        private readonly string director;
        private readonly string title;
        private readonly int playTime;

        public Video(string director, string title, int copiesCount, int playTime)
        {
            this.director = director;
            this.title = title;
            this.CopiesCount = copiesCount;
            this.playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine($" Director: {this.director}");
            Console.WriteLine($" Title: {this.title}");
            Console.WriteLine($" # Copies: {this.CopiesCount}");
            Console.WriteLine($" Playtime: {this.playTime}\n");
        }
    }
}
