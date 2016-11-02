namespace StateExample
{
    using Entities;

    internal class StartUp
    {
        // Sorry for the mega hard coupling had no time to do it better!!!
        private static void Main()
        {
            var person = new Person();

            person.State = new AwakePerson();
            person.ReportState();

            person.State = new SleepingPerson();
            person.ReportState();
        }
    }
}
