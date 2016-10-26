namespace MySql
{
    using System;
    using Data.MySqlClient;

    using Models;

    public class StartUp
    {
        private static readonly Library bookLibrary = new Library();
        // Server connection string
        private static MySqlConnection mySqlConnection = new MySqlConnection();

        public static void Main()
        {
            // You must change Pw value (Password) in Settings.settings

            try
            {
                ConnectToDatabase();

                AddBooks();
                FindBooksByName("Best Book");
                ListingAllBooks();
                DeleteAllRecords();
            }
            finally
            {
                DisconnectFromDatabase();
            }
        }

        private static void AddBooks()
        {
            Console.WriteLine("Adding books: ");

            var mySqlCommand = new MySqlCommand(@"INSERT INTO Books (Title, Author, PublishDate, ISBN)
                                                           VALUES (@title, @author, @publishDate, @isbn)", mySqlConnection);

            foreach (var book in bookLibrary.Books)
            {
                var title = book.Title;
                var author = book.Author;
                var publishDate = book.PublishDate;
                var isbn = book.Isbn;

                mySqlCommand.Parameters.AddWithValue("@title", title);
                mySqlCommand.Parameters.AddWithValue("@author", author);
                mySqlCommand.Parameters.AddWithValue("@publishDate", publishDate);
                mySqlCommand.Parameters.AddWithValue("@isbn", isbn);

                var queryResult = mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Parameters.Clear();

                Console.WriteLine($"    ({queryResult} row(s) affected)");
            }
        }

        private static void FindBooksByName(string substring)
        {
            Console.WriteLine($"\nFinding books by name '{substring}':");

            var mySqlCommand = new MySqlCommand(@"SELECT Title, Author, PublishDate, ISBN
                                                           FROM Books
                                                           WHERE LOCATE(@substring, Title)", mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@substring", substring);

            using (var reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var title = reader["Title"].ToString();
                    var author = reader["Author"].ToString();
                    var publishDate = (DateTime)reader["PublishDate"];
                    var isbn = reader["ISBN"].ToString();

                    var book = new Book()
                    {
                        Title = title,
                        Author = author,
                        PublishDate = publishDate,
                        Isbn = isbn
                    };

                    Console.WriteLine(book);
                }
            }
        }

        private static void ListingAllBooks()
        {
            Console.WriteLine("Listing all books: ");

            var mySqlCommand = new MySqlCommand(@"SELECT Title, Author, PublishDate, ISBN
                                                           FROM Books", mySqlConnection);

            using (var reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var title = reader["Title"].ToString();
                    var author = reader["Author"].ToString();
                    var publishDate = (DateTime)reader["PublishDate"];
                    var isbn = reader["ISBN"].ToString();

                    var book = new Book()
                    {
                        Title = title,
                        Author = author,
                        PublishDate = publishDate,
                        Isbn = isbn
                    };

                    Console.WriteLine(book);
                }
            }
        }

        private static void DeleteAllRecords()
        {
            Console.WriteLine("Deleting all books: ");

            var mySqlCommand = new MySqlCommand(@"DELETE FROM Books
                                                           WHERE BookId > 0", mySqlConnection);

            var queryResult = mySqlCommand.ExecuteNonQuery();

            Console.WriteLine($"    ({queryResult} row(s) affected)\n");
        }

        private static void ConnectToDatabase()
        {
            mySqlConnection = new MySqlConnection();
            mySqlConnection.Open();
        }

        private static void DisconnectFromDatabase()
        {
            mySqlConnection?.Close();
        }
    }
}