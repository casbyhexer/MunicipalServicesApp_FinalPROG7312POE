using MunicipalServicesApp.Event_Related_Data_Structures;
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

            /*try
            {
                // Example: Check for null
                Guard2.AgainstNull(null, "TestParameter");

                // Example: Check for null or empty
                Guard2.AgainstNullOrEmpty("", "TestString");

                // Example: Check for out-of-range
                Guard2.AgainstOutOfRange(15, 1, 10, "TestValue");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }*/
        }
    }
}
