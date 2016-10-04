namespace ExtractStudents
{
    using System.Collections.Generic;

    public class ExtractStudnetsRunTest
    {
        public static void Run()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Yolo", "Yolov", "NovaGRP"),
                new Student("Stamat", "Stamatov", "BestGRP"),
                new Student("Tedi", "Gotinkova", "LoosersGRP"),
                new Student("Jeni", "Kalkana", "NovaGRP"),
                new Student("Mariiika", "Marieva", "LonelyGRP"),
                new Student("Gumur", "Ahmedov", "BestGRP"),
                new Student("Salem", "AlQamzi", "BestGRP"),
                new Student("Hamndan", "Hamndanov", "NovaGRP"),
                new Student("Vasko", "Pichov", "NovaGRP"),
                new Student("Arslan", "Kingov", "LoosersGRP")
            };

            ExtractStudnetsMethods.GroupStudentByGroupNameUsingLINQ(students);
            ExtractStudnetsMethods.GroupStudentByGroupNameUsingLambda(students);
        }
    }
}
