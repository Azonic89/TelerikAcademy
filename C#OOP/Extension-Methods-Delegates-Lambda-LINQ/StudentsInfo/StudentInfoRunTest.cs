namespace StudentsInfo
{
    using System.Collections.Generic;

    public class StudentInfoRunTest
    {
        public static void Run()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Yolo", "Yolov", "103189", "0286332", "yolo@yahoo.com", new List<int> {6, 3, 4, 2, 3}, new Group(2, "Computing")),
                new Student("Stamat", "Sedov", "115106", "5551223", "stamat@gmail.com", new List<int> {3, 2, 2, 6, 3}, new Group(2, "Physics")),
                new Student("Penka", "Goshova", "106106", "0044213", "penka@mail.com", new List<int> {5, 2 ,2, 4, 4}, new Group(13, "Mathematics")),
                new Student("Mitka", "Mitkova", "222213", "0223267", "mitka@gmail.com", new List<int> {6, 6, 6, 2, 2}, new Group(14, "Physics")),
                new Student("Mariiiika", "Marova", "333606", "088088333", "mariiika@abv.bg", new List<int> {2, 2, 2, 6, 6}, new Group(9, "Biology")),
                new Student("Krumio", "Krumov", "122289", "0686636", "krumio@abv.bg", new List<int> {2, 3, 3, 2, 3}, new Group(13, "Biology")),
                new Student("Petko", "Yalov", "111106", "0101223", "petko@yahoo.com", new List<int> {6, 6, 6, 6, 6}, new Group(1, "Physics")),
                new Student("Ivanichka", "Ivova", "206206", "0555222", "ivanichka@mail.com", new List<int> {5, 5, 5, 5, 5}, new Group(6, "Physics")),
                new Student("Gumur", "Papa", "189189", "03338834", "gumur@gmail.com", new List<int> {3, 6, 6, 3, 2}, new Group(16, "Physics")),
                new Student("Sedev", "Sedefov", "322300", "088088222", "sedev@yahoo.com", new List<int> {2, 3, 2, 6, 3}, new Group(2, "Mathematics"))
            };

            StudentMethods.SelectStudentsByGroupNumberWithLINQ(students);
            StudentMethods.SelectStudentsByGroupNumberWithLambda(students);
            StudentMethods.ExtractStudentsByEmail(students);
            StudentMethods.ExtractStudentswithPhoneInSofia(students);
            StudentMethods.ExtractStudentsWithExcellentGrade(students);
            StudentMethods.ExtractStudentsWithTwoPoorMarks(students);
            StudentMethods.ExtractStudentsMarks(students);
            StudentMethods.ExtractStudentsFromMathematicsDepartment(students);
        }
    }
}
