using System;
using System.Collections.Generic;
using System.Linq;

namespace MySql.Models
{
    public class Library
    {
        private readonly Book[] books =
        {
            new Book()
            {
                Title = "Best Book One",
                Author = "Amazing Author",
                PublishDate = new DateTime(2005, 7, 22),
                Isbn = "9062024060"
            },
            new Book()
            {
                Title = "Best Book Two",
                Author = "Another Amazing Author",
                PublishDate = new DateTime(2000, 10, 10),
                Isbn = "979783305"
            },
            new Book()
            {
                Title = "Best Book Three",
                Author = "The One and Only",
                PublishDate = new DateTime(2013, 12, 17),
                Isbn = "1449910416"
            },
            new Book()
            {
                Title = "Best Book One",
                Author = "Charles Dickens",
                PublishDate = new DateTime(2012, 5, 17),
                Isbn = "1448682681"
            }
        };

        public ICollection<Book> Books
        {
            get
            {
                return this.books.ToList();
            }
        }
    }
}
