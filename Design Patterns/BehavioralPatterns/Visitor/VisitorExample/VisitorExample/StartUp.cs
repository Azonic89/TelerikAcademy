namespace VisitorExample
{
    using Entities;

    internal class StartUp
    {
        // Sorry for this coupling had no time!!!
        private static void Main()
        {            
            var employees = new Employees();
            employees.Attach(new Clerk());
            employees.Attach(new Director());
            employees.Attach(new President());

            // Visited Employess
            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());
        }
    }
}
