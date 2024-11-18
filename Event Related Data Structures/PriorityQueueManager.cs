using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.PriorityQueue
{
    internal class PriorityQueueManager
    {
        // Instance of PriorityQueue to manage events
        private static PriorityQueue eventQueue = new PriorityQueue();

        /// <summary>
        /// Retrieves the current PriorityQueue instance
        /// </summary>
        public static PriorityQueue GetEventQueue()
        {
            return eventQueue;
        }

        /// <summary>
        /// Adds an event to the priority queue
        /// </summary>
        public static void AddEvent(Event eventData, int priority)
        {
            if (eventData == null)
            {
                throw new ArgumentNullException(nameof(eventData), "Event data cannot be null.");
            }

            eventQueue.Push(eventData, priority);
        }

        /// <summary>
        /// Retrieves all events in the queue as an enumerable list
        /// </summary>
        public static IEnumerable<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();

            // Use a temporary queue to iterate without modifying the original queue
            var tempQueue = new PriorityQueue();
            foreach (var ev in eventQueue.GetAllEvents())
            {
                events.Add(ev);
                tempQueue.Push(ev, ev.Priority); // Rebuild the temporary queue to preserve original order
            }

            return events;
        }

        /// <summary>
        /// Searches for events matching a specific search term
        /// </summary>
        public static IEnumerable<Event> SearchEvents(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return Enumerable.Empty<Event>(); // Return empty if search term is invalid
            }

            var allEvents = GetAllEvents(); // Retrieve all events
            return allEvents.Where(ev => ev.EventName.ToLower().Contains(searchTerm.ToLower()));
        }
    }
}

