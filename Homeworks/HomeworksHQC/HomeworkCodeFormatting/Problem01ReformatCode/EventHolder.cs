﻿namespace Problem01ReformatCode
{
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private MultiDictionary<string, Event> eventTitle = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> eventDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.eventTitle.Add(title.ToLower(), newEvent);
            this.eventDate.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.eventTitle[title])
            {
                removed++;
                this.eventDate.Remove(eventToRemove);
            }

            this.eventTitle.Remove(title);

            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.eventDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;

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
