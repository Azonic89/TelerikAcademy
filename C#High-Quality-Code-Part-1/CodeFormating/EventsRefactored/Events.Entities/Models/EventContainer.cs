namespace Events.Entities.Models
{
    using System;

    using Wintellect.PowerCollections;

    public class EventContainer
    {
        private readonly MultiDictionary<string, Event> findByTitle = new MultiDictionary<string, Event>(true);

        private readonly OrderedBag<Event> orderByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            var newEvent = new Event(date, title, location);
            this.findByTitle.Add(title.ToLower(), newEvent);
            this.orderByDate.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            var title = titleToDelete.ToLower();
            var removed = 0;

            foreach (var eventToRemove in this.findByTitle[title])
            {
                removed++;
                this.orderByDate.Remove(eventToRemove);
            }

            this.findByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            var eventsToShow = this.orderByDate.RangeFrom(
                new Event(date, string.Empty, string.Empty),
                true);
            var showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
