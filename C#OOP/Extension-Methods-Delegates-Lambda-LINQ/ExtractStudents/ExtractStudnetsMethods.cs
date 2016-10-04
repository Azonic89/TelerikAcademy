namespace ExtractStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractStudnetsMethods
    {
        public static void Print(IEnumerable<IEnumerable<Student>> array)
        {
            foreach (var group in array)
            {
                foreach (var student in group)
                {
                    Console.WriteLine("Full name: {0} {1} \nGroup name: {2}", student.FirstName, student.LastName, student.GroupName);
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('*', 40));
        }

        public static void GroupStudentByGroupNameUsingLINQ(List<Student> array)
        {
            var students =
                from student in array
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            Console.WriteLine("Print students grouped by GroupName: (Using LINQ query) ");
            Print(students);
        }

        public static void GroupStudentByGroupNameUsingLambda(List<Student> array)
        {
            var students = array.GroupBy(x => x.GroupName).OrderBy(y => y.Key);

            Console.WriteLine("Print students grouped by GroupName: (Using Lambda expression) ");
            Print(students);
        }
    }
}
