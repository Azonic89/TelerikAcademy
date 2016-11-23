namespace Events.Entities.Models
{
    using System;
    using System.Text;

    public class Event : IComparable
    {   
        private readonly string title;
        private readonly string location;

        private DateTime date;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            var other = obj as Event;
            var compareByDate = this.date.CompareTo(other.date);
            var compatreByyTitle = this.title.CompareTo(other.title);

            var compareByLocation = this.location.CompareTo(other.location);
            if (compareByDate == 0)
            {
                return compatreByyTitle == 0 ? compareByLocation : compatreByyTitle;
            }
            else
            {
                return compareByDate;
            }
        }

        public override string ToString()
        {
            var toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));

            toString.Append(" | " + this.title);

            if (!string.IsNullOrEmpty(this.location))
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
