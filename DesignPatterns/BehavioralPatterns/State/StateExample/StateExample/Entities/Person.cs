namespace StateExample.Entities
{
    using Contracts;

    internal class Person
    {
        public IPersonStateChanger State { get; set; }

        public void Change()
        {
            this.State.ChangeState(this);
        }

        public void ReportState()
        {
            this.State.ReportState();
        }
    }
}
