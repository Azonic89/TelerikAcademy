namespace VisitorExample.Entities
{
    using System;

    using Abstract;
    using Contracts;

    internal class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            if (employee != null)
            {
                employee.VacationDays += 3;
                Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}");
            }
        }
    }
}
