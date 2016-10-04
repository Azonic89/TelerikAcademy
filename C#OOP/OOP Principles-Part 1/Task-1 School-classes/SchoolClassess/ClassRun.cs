namespace SchoolClassess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClassRun
    {
        public static void Testing()
        {
            Students cukiStudent = new Students("Kristiyan", "Cuklev", 12);
            cukiStudent.AddComment("Plamen is a good student");

            Students koceStudent = new Students("Kon", "Simeonov", 2);
            koceStudent.AddComment("Pesho is a bad student");

            Students ivaStudent = new Students("Iva", "Ivanova", 7);
            ivaStudent.AddComment("Iva is poor student");

            Discipline informatics = new Discipline("Informatics", 2, 2);
            informatics.AddComment("I like Informatics");

            Discipline physics = new Discipline("Physics", 8, 4);
            Discipline chemistry = new Discipline("Chemistry", 3, 2);
            Discipline economy = new Discipline("Economy", 1, 1);

            Teachers donchoTeacher = new Teachers("Dokata", "Minkov", new List<Discipline>() { informatics, physics, chemistry });
            donchoTeacher.AddComment("Maria Dimitrova is a great teacher");

            Teachers goshoTeacher = new Teachers("Gosho", "Goshov", new List<Discipline>() { economy });
            Class firstClass = new Class(new List<Students>() { cukiStudent, koceStudent }, new List<Teachers>() { donchoTeacher }, "A");
            Class secondClass = new Class(new List<Students>() { ivaStudent }, new List<Teachers>() { goshoTeacher }, "B");

            School school = new School(new List<Class>() { firstClass, secondClass }, "Telerik Academy");
            school.PrintSchoolName();
            firstClass.ToString();
            secondClass.ToString();

            // Show comments
            cukiStudent.PrintComment();
            koceStudent.PrintComment();
            ivaStudent.PrintComment();
            informatics.PrintComment();
            donchoTeacher.PrintComment();
        }
    }
}
