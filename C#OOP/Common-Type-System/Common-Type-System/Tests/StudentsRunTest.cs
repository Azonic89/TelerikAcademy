namespace Common_Type_System.Tests
{
    using Common_Type_System.Models;
    using Enumerations;
    using System;

    public class StudentsRunTest
    {
        public static void Run()
        {
            Student firstStudent = new Student("Stamat", "Petrov", "Stamatov", 6758421, "Drujba 1 building 16", "089*******", "stamat1928@abv.bg", 2,
                SpecialityType.ObjectOrientedProgramming, UniversityType.NewBulgarianUniversity, FacultyType.SoftwareEngineering);
            Student secondStudent = new Student("Mariq", "Zdravkova", "Peeva", 621294, "Bul Bulgaria N56", "088*******", "mara34@gmail.com", 4,
                SpecialityType.Microbiology, UniversityType.Harvard, FacultyType.MedicalSciences);
            Student thirdStudent = new Student("Gosho", "Nedqlkov", "Penev", 531642, "Lozenets str.Tsevtna Gradina N12", "087*******", "gogo89@9gag.com", 3,
                SpecialityType.Law, UniversityType.SofiaUniversity, FacultyType.Journalism);

            Console.WriteLine(new string('*', 40));
            Console.Write("First Student Info!");
            Console.Write(new string('*', 21));
            Console.WriteLine();
            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(new string('*', 40));

            Console.Write("Second Student Info!");
            Console.Write(new string('*', 20));
            Console.WriteLine();
            Console.WriteLine(secondStudent.ToString());
            Console.WriteLine(new string('*', 40));

            Console.Write("Third Student Info!");
            Console.Write(new string('*', 21));
            Console.WriteLine();
            Console.WriteLine(thirdStudent.ToString());
            Console.WriteLine(new string('*', 40));


            Console.WriteLine(new string('*', 40));
            Console.WriteLine("First student equal to third student? {0}", Student.Equals(firstStudent, thirdStudent));
            Console.WriteLine("First student == third student? {0}", firstStudent == thirdStudent); 
            Console.WriteLine("First student != third student? {0}", firstStudent != thirdStudent); 
            Console.WriteLine();

            Student cloned = firstStudent.Clone();
            Console.WriteLine("Cloned Student: ");
            Console.Write(new string('*', 25));
            Console.WriteLine();
            Console.WriteLine(cloned);

            int compareStudents = firstStudent.CompareTo(secondStudent);
            Console.WriteLine("Compare result: " + compareStudents);


        }
    }
}
