using MunicipalServicesApp.PriorityQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeScreen());

            /*// Get a priority queue filled with events
            PriorityQueue.Node eventQueue = PriorityQueueHelper.GetPriorityEventQueue();

            // Retrieve events in priority order
            List<Event> eventsInOrder = PriorityQueueHelper.GetEventsInPriorityOrder(eventQueue);

            // Display the events
            Console.WriteLine("Events in Priority Order:");
            foreach (var ev in eventsInOrder)
            {
                Console.WriteLine($"Event: {ev.EventName}, Priority: {ev.Priority}, Date: {ev.Date.ToShortDateString()}");
            }

            Console.ReadLine();*/
        }
    }
}
