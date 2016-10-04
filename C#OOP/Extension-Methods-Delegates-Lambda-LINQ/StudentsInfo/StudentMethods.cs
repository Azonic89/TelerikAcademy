namespace StudentsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentMethods
    {
        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.Write("Name: {0} {1} \nFN: {2} \nTelephone: {3} \nMail: {4} \nGroup: {5} \nMarks: "
                    , student.FirstName, student.LastName, student.Fn, student.Telephone, student.Email, student.GroupNumber.GroupNumber);
                
                foreach (var mark in student.Marks)
                {
                    Console.WriteLine("{0}", mark);
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine(new string('*', 40));
        }

        public static void SelectStudentsByGroupNumberWithLINQ(List<Student> array)
        {
            var students =
                from student in array
                where student.GroupNumber.GroupNumber == 2
                select student;

            Console.WriteLine("Students from group number 2 are: (Using LINQ query) ");
            Print(students);
        }

        public static void SelectStudentsByGroupNumberWithLambda(List<Student> array)
        {
            var students = array.Where(x => (x.GroupNumber.GroupNumber == 2)).OrderBy(x => x.FirstName);

            Console.WriteLine("Students from group number 2 are: (Using Lambda expressions) ");
            Print(students);
        }

        public static void ExtractStudentsByEmail(List<Student> array)
        {
            var students =
                from student in array
                where student.Email.EndsWith("yahoo.com")
                select student;

            Console.WriteLine("Students with email yahoo.com: ");
            Print(students);
        }

        public static void ExtractStudentswithPhoneInSofia(List<Student> array)
        {
            var students =
                from student in array
                where student.Telephone.StartsWith("02")
                select student;

            Console.WriteLine("Students with telephone numbers from Sofia: ");
            Print(students);
        }

        public static void ExtractStudentsWithExcellentGrade(List<Student> array)
        {
            var excellentMark = 6;

            var students =
                from student in array
                where student.Marks.Contains(excellentMark)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            Console.WriteLine("Students with at least one excellent grade: ");

            foreach (var student in students)
            {
                Console.WriteLine("Full name: " + student.FullName);
                Console.Write("Marks: ");

                foreach (var item in student.Marks)
                {
                    Console.Write("{0} ", item);
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine(new string('*', 40));
        }

        public static void ExtractStudentsWithTwoPoorMarks(List<Student> array)
        {
            var failMark = 2;
            var timesFound = 2;

            var students =
                from student in array
                where student.Marks.Count(x => x == failMark) == timesFound
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            Console.WriteLine("Students with exaclty two poor grades: ");

            foreach (var student in students)
            {
                Console.WriteLine("Full Name: {0}", student.FullName);
                Console.Write("Marks: ");

                foreach (var mark in student.Marks)
                {
                    Console.Write("{0}", mark);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine(new string('*', 40));
        }

        public static void ExtractStudentsMarks(List<Student> array)
        {
            var students =
                from student in array
                where student.Fn.EndsWith("06")
                select student;

            Console.WriteLine("Students marks enrolled in 2006: ");
            Print(students);
        }

        public static void ExtractStudentsFromMathematicsDepartment(List<Student> array)
        {
            var students =
                from student in array
                where student.GroupNumber.DepartmentName == "Mathematics"
                select student;

            Console.WriteLine("Students from \"Mathematics\" department: ");
            Print(students);
        }
    }
}
