using MunicipalServicesApp.Advanced_Data_Structures;
using System;
using System.Collections.Generic;

namespace MunicipalServicesApp.PriorityQueue
{
    public class Event
    {
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public int Priority { get; set; }
        public string Category { get; set; }
    }

    internal class PriorityQueue
    {
        // Node class to represent each event in the priority queue
        public class Node
        {
            public Event Data;
            public int Priority;
            public Node Next;

            // Constructor for Node
            public Node(Event data, int priority)
            {
                Data = data;
                Priority = priority;
                Next = null;
            }
        }

        private Node head; // Reference to the head of the priority queue

        /// <summary>
        /// Returns the event at the head of the priority queue
        /// </summary>
        public Event Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The priority queue is empty.");
            }
            return head.Data;
        }

        /// <summary>
        /// Removes the element with the highest priority from the queue
        /// </summary>
        public void Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The priority queue is empty.");
            }
            head = head.Next;
        }

        /// <summary>
        /// Adds an event to the priority queue based on its priority
        /// </summary>
        public void Push(Event data, int priority)
        {
            Guard.AgainstNull(data, nameof(data));
            Guard.AgainstOutOfRange(priority, 0, 10, nameof(priority));

            // Add the event to the priority queue
            Node temp = new Node(data, priority);

            if (head == null || head.Priority > priority)
            {
                temp.Next = head;
                head = temp;
            }
            else
            {
                Node start = head;
                while (start.Next != null && start.Next.Priority <= priority)
                {
                    start = start.Next;
                }

                temp.Next = start.Next;
                start.Next = temp;
            }
        }

        /// <summary>
        /// Checks if the queue is empty
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Returns all events in the priority queue as an enumerable list
        /// </summary>
        public IEnumerable<Event> GetAllEvents()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
