namespace StateExample.Contracts
{
    using Entities;

    internal interface IPersonStateChanger
    {
        void ChangeState(Person person);

        void ReportState();
    }
}
