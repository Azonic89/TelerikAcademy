namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Classes;

    class Startup
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student("Plamen", "Georgiev", 12),
                new Student("Ivan", "Ivanov", 1),
                new Student("Gosho", "Goshov", 1),
                new Student("Katrin", "Dimitrova", 3),
                new Student("Pesho", "Peshov", 9),
                new Student("Maria", "Borisova", 5),
                new Student("Gabriela", "Marinova", 3),
                new Student("Petko", "Petkov", 8),
                new Student("Kiril", "Kirilov", 8),
                new Student("Dimitar", "Dimitrov", 4)
            };

            // List of 10 workers
            List<Worker> workersList = new List<Worker>()
            {
                new Worker("Kosta", "Kostov", 555, 4),
                new Worker("Krum", "Krumov", 900, 12),
                new Worker("Mira", "Stamenova", 100, 40),
                new Worker("Petka", "Petkanova", 1021, 50),
                new Worker("Stefan", "Stefanov", 200, 21),
                new Worker("Jordan", "Jordanov", 111, 10),
                new Worker("Nikolay", "Georgiev", 1000, 9),
                new Worker("Stamat", "Stamatov", 11, 11),
                new Worker("Goran", "Goranov", 88, 8),
                new Worker("Samuil", "Samuilov", 1111, 11)
            };

            // Call methods
            StudentsWorkersRUN.SortStudentBygrade(studentsList);
            StudentsWorkersRUN.SortWorkerByMoneyPerHours(workersList);

            // Merge studentsList and workersList
            List<Human> mergeList = new List<Human>();
            mergeList.AddRange(studentsList);
            mergeList.AddRange(workersList);

            // Call method
            StudentsWorkersRUN.SortMergedList(mergeList);
        }
    }
}
