namespace StudenDB.ConsoleClient
{
    using System;
    using System.Linq;

    using Data;

    public class StartUp
    {
        private static void Main()
        {
            // FIX YOUR CONNECTION STRING

            var context = new StudentContext();
            context.Database.Initialize(true);

            PrintStudents(context);
            PrintCourses(context);
            PrintHomeworks(context);
        }

        private static void PrintStudents(StudentContext forumSystemContext)
        {
            Console.WriteLine("\rStudents: ");
            foreach (var student in forumSystemContext.Students.Include("Courses"))
            {
                Console.WriteLine($" - {student.Name} -> present in {student.Courses.Count()} course(s).");
            }
        }

        private static void PrintCourses(StudentContext forumSystemContext)
        {
            Console.WriteLine("\nCourses: ");
            foreach (var course in forumSystemContext.Courses.Include("Homeworks"))
            {
                Console.WriteLine($" - {course.Description} -> has {course.Homeworks.Count()} homework(s).");
            }
        }

        private static void PrintHomeworks(StudentContext forumSystemContext)
        {
            Console.WriteLine("\nHomeworks: ");
            foreach (var homework in forumSystemContext.Homeworks.Include("Materials").Where(h => !h.StudentId.HasValue))
            {
                Console.WriteLine($" - {homework.Content} ({homework.Course.Description}) -> has {homework.Materials.Count()} material(s).");

                foreach (var material in homework.Materials)
                {
                    Console.WriteLine($"    - {material.Type} ({material.Homework.Content}) - {material.DownloadUrl}");
                }

                Console.WriteLine();
            }
        }
    }
}
