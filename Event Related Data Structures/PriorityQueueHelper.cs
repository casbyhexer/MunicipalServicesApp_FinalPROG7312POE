using System;
using System.Collections.Generic;

namespace MunicipalServicesApp.PriorityQueue
{
    // Helper class to manage priority queue operations for events
    internal class PriorityQueueHelper
    {
        // Method to demonstrate adding events to the priority queue and retrieving them
        public static PriorityQueue.Node GetPriorityEventQueue()
        {
            // Initialize the priority queue (empty at first)
            PriorityQueue.Node eventQueue = null;

            // Create some events (can be populated from elsewhere in the app)
            Event event1 = new Event { EventName = "Municipal Meeting", Date = DateTime.Now.AddDays(2), Priority = 2 };
            Event event2 = new Event { EventName = "Holiday Parade", Date = DateTime.Now.AddDays(5), Priority = 3 };
            Event event3 = new Event { EventName = "City Clean-up Day", Date = DateTime.Now.AddDays(1), Priority = 1 }; // High priority

            // Add events to the priority queue
            eventQueue = PriorityQueue.Push(eventQueue, event1, event1.Priority);
            eventQueue = PriorityQueue.Push(eventQueue, event2, event2.Priority);
            eventQueue = PriorityQueue.Push(eventQueue, event3, event3.Priority);

            return eventQueue;
        }

        // Method to get the next event from the priority queue (peek and pop)
        public static List<Event> GetEventsInPriorityOrder(PriorityQueue.Node eventQueue)
        {
            List<Event> events = new List<Event>();

            // Loop through the priority queue to get events in order of priority
            while (!PriorityQueue.IsEmpty(eventQueue))
            {
                // Get the next event and remove it from the queue
                Event nextEvent = PriorityQueue.Peek(eventQueue);
                eventQueue = PriorityQueue.Pop(eventQueue);

                // Add the event to the list
                events.Add(nextEvent);
            }

            return events; // Return the list of events in priority order
        }
    }
}
