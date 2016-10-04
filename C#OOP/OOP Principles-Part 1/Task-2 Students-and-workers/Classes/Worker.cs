namespace Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Week salary cannot be zero or negative");
                }
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Work hours per day cannot be zero or negative");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public decimal MoneyPerHour()
        {
            int workHoursPerWeek = (5 * this.workHoursPerDay);
            decimal moneyPerHour = this.workHoursPerDay / workHoursPerWeek;

            return moneyPerHour;
        }
    }
}
