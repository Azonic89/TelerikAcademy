namespace Students
{
    using System;

    public class StudentsRunTest
    {
        public static void Run()
        {
            Console.WriteLine("Students Test!");
            
            Students[] students =
            {
                new Students("Stamat", "Sedevov", 44),
                new Students("Vasiliakis", "Penevski", 27),
                new Students("Gosho", "Peshov", 24),
                new Students("Pesho", "Todorv", 19),
                new Students("Ivan", "Pinkov", 20),
                new Students("Halavir", "Halaviror", 30),
                new Students("Chukundur", "Prutoc", 21),
                new Students("Joro", "Jorkov", 39)
            };
                   
            FindStudentUsingLINQ.FirstBeforeLast(students);
            FindStudentUsingLINQ.AgeRange(students);
            FindStudentUsingLINQ.SortStudentsUsingLambda(students);
            FindStudentUsingLINQ.SortStudnetsUsingLINQ(students);
        }
    }
}
