namespace StateExample.Entities
{
    using System;

    using Contracts;

    internal class AwakePerson : IPersonStateChanger
    {
        public void ChangeState(Person person)
        {
            person.State = new AwakePerson();
        }

        public void ReportState()
        {
            Console.WriteLine("The Person is Awake!!!");
        }
    }
}
