namespace DecoratorExample.Models
{
    using System;

    public class Book : BorrowableItem
    {
        private readonly string author;
        private readonly string title;

        public Book(string author, string title, int copiesCount)
        {
            this.author = author;
            this.title = title;
            this.CopiesCount = copiesCount;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine($" Author: {this.author}");
            Console.WriteLine($" Title: {this.title}");
            Console.WriteLine($" # Copies: {this.CopiesCount}");
        }
    }
}
