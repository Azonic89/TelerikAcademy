namespace Students
{
    using System;
    using System.Linq;

    public class FindStudentUsingLINQ
    {
        public static void FirstBeforeLast(Students[] array)
        {
            var students =
                from student in array
                where student.FirstName.CompareTo(student.LastName) == 1
                select student;

            foreach (var student in students)
            {
                Console.WriteLine("First name before Last name alphabetically: {0} {1}", student.FirstName, student.LastName);
            }            
        }

        public static void AgeRange(Students[] array)
        {
            var students =
                from student in array
                where (student.Age >= 18 && student.Age <= 24)
                select student;

            Console.WriteLine("Students between the age of 18 and 24 are: ");

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }

        public static void SortStudentsUsingLambda(Students [] array)
        {
            var students = array.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName);

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Sorting students using Lambda expressions: ");

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }

        public static void SortStudnetsUsingLINQ(Students [] array)
        {
            var students =
                from student in array
                orderby student.FirstName descending, student.LastName
                select student;

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Sorting Students using LINQ: ");
            
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
