namespace VisitorExample.Entities
{
    using System;

    using Abstract;
    using Contracts;

    internal class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            if (employee != null)
            {
                employee.Income *= 1.10;
                Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income}");
            }
        }
    }
}
