namespace Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsWorkersRUN
    {
        public static void SortStudentBygrade(List<Student> studentsList)
        {
            var sortedList =
                from stud in studentsList
                orderby stud.Grade ascending
                select stud;

            Console.WriteLine("--------------- STUDENTS ---------------");

            foreach (var element in sortedList)
            {
                Console.WriteLine("Full name: {0}, Grade: {1}", element.FirstName + " " + element.LastName,
                    element.Grade);
            }

            Console.WriteLine();
        }

        public static void SortWorkerByMoneyPerHours(List<Worker> workersList)
        {
            var sortedList = workersList.OrderByDescending(x => x.MoneyPerHour());

            Console.WriteLine("--------------- WORKERS ---------------");

            foreach (var element in sortedList)
            {
                Console.WriteLine("Full name: {0}", element.FirstName + " " + element.LastName);
                Console.WriteLine("Week salary: {0}", element.WeekSalary);
                Console.WriteLine("Work hours per day: {0}", element.WorkHoursPerDay);
                Console.WriteLine("Money per hours: {0}", element.MoneyPerHour());
                Console.WriteLine();
            }
        }

        public static void SortMergedList(List<Human> mergedList)
        {
            var sortedList =
                from merge in mergedList
                orderby merge.FirstName, merge.LastName
                select merge;

            Console.WriteLine("--------------- MERGED LIST ---------------");

            foreach (var element in sortedList)
            {
                Console.WriteLine("First name: {0}, Last name: {1}", element.FirstName, element.LastName);
            }
        }


    }
}
