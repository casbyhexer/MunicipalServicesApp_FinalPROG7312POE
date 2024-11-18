using System;
using System.Collections.Generic;

namespace MunicipalServicesApp.PriorityQueue
{
    // Helper class to manage priority queue operations for events
    internal class PriorityQueueHelper
    {
        // Method to demonstrate adding events to the priority queue and retrieving them
        public static PriorityQueue GetPriorityEventQueue()
        {
            // Initialize the priority queue
            PriorityQueue eventQueue = new PriorityQueue();

            // Create some events (can be populated from elsewhere in the app)
            Event event1 = new Event { EventName = "Municipal Meeting", Date = DateTime.Now.AddDays(2), Priority = 2, Category = "Community" };
            Event event2 = new Event { EventName = "Holiday Parade", Date = DateTime.Now.AddDays(5), Priority = 3, Category = "Festivity" };
            Event event3 = new Event { EventName = "City Clean-up Day", Date = DateTime.Now.AddDays(1), Priority = 1, Category = "Community" }; // High priority

            // Add events to the priority queue using the Push method
            eventQueue.Push(event1, event1.Priority);
            eventQueue.Push(event2, event2.Priority);
            eventQueue.Push(event3, event3.Priority);

            return eventQueue; // Return the populated priority queue
        }

        // Method to get the next event from the priority queue (peek and pop)
        public static List<Event> GetEventsInPriorityOrder(PriorityQueue eventQueue)
        {
            List<Event> events = new List<Event>();

            // Loop through the priority queue to get events in order of priority
            while (!eventQueue.IsEmpty())
            {
                // Get the next event and remove it from the queue
                Event nextEvent = eventQueue.Peek();
                eventQueue.Pop();

                // Add the event to the list
                events.Add(nextEvent);
            }

            return events; // Return the list of events in priority order
        }
    }
}
