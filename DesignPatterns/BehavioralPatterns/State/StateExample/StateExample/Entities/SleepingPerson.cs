namespace StateExample.Entities
{
    using System;

    using Contracts;

    internal class SleepingPerson : IPersonStateChanger
    {
        public void ChangeState(Person person)
        {
            person.State = new SleepingPerson();
        }

        public void ReportState()
        {
            Console.WriteLine("The Person is Sleeping!!!");
        }
    }
}
