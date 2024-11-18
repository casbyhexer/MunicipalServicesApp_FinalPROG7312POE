using MunicipalServicesApp.PriorityQueue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalServicesApp
{
    public partial class LocalEvents_AnnoucementsForm : Form
    {
        // SortedDictionary to store event information
        private SortedDictionary<string, List<Event>> eventsByCategory;

        // HashSet for unique categories
        private HashSet<string> uniqueCategories;

        // HashSet for unique event dates
        private HashSet<DateTime> uniqueEventDates;


        public LocalEvents_AnnoucementsForm()
        {
            InitializeComponent();

            // Initializes HashSets for unique categories and dates
            uniqueCategories = new HashSet<string>();
            uniqueEventDates = new HashSet<DateTime>();

            // Initializes eventsByCategory as an empty SortedDictionary
            eventsByCategory = new SortedDictionary<string, List<Event>>();

            // Calls method to populate sets with data
            PopulateUniqueCategoriesAndDates();
        }

        private void PopulateUniqueCategoriesAndDates()
        {
            foreach (var categoryEvents in eventsByCategory)
            {
                foreach (var eventItem in categoryEvents.Value)
                {
                    // Adds unique categories
                    uniqueCategories.Add(eventItem.Category);

                    // Adds unique dates
                    uniqueEventDates.Add(eventItem.Date);
                }
            }
        }


        private void lblLocation_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) // Events List View
        {
            // This is the event handler for the ListView's event.
            // What happens when an item is selected happens here.

            if (eventsListView.SelectedItems.Count > 0)
            {
                // This gets the selected event
                var selectedItem = eventsListView.SelectedItems[0];
                string eventName = selectedItem.SubItems[0].Text;
                string eventDate = selectedItem.SubItems[1].Text;
                string eventCategory = selectedItem.SubItems[2].Text;
                string eventPriority = selectedItem.SubItems[3].Text;

                MessageBox.Show($"Event Name: {eventName}\nEvent Date: {eventDate}\nCategory: {eventCategory}\nPriority: {eventPriority}");
            }
        }

        private void LocalEventsAndAnnouncements_Load(object sender, EventArgs e)
        {
            PopulateEventsList(); // Calls method to populate events when the form loads
            PopulateCategoryComboBox(); // Populates the ComboBox with categories

        }

        private void PopulateEventsList()
        {
            try
            {
                // Initialize the SortedDictionary to store events by category
                eventsByCategory = new SortedDictionary<string, List<Event>>();

                // Clear existing items in the ListView
                eventsListView.Items.Clear();

                // Retrieve events from the priority queue
                var eventQueue = PriorityQueue.PriorityQueue.GetEventQueue();

                if (eventQueue == null || PriorityQueue.PriorityQueue.IsEmpty(eventQueue))
                {
                    MessageBox.Show("No events to display. The priority queue is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                while (!PriorityQueue.PriorityQueue.IsEmpty(eventQueue))
                {
                    // Safely retrieve the next event
                    Event nextEvent = PriorityQueue.PriorityQueue.Peek(eventQueue);

                    if (nextEvent == null)
                    {
                        // Skip if the event is null (unexpected case)
                        eventQueue = PriorityQueue.PriorityQueue.Pop(eventQueue);
                        continue;
                    }

                    eventQueue = PriorityQueue.PriorityQueue.Pop(eventQueue);

                    // Add the event to the ListView
                    var listItem = new ListViewItem(new string[]
                    {
                nextEvent.EventName,
                nextEvent.Date.ToShortDateString(),
                nextEvent.Category,
                nextEvent.Priority.ToString()
                    });
                    eventsListView.Items.Add(listItem);

                    // Add the event to the SortedDictionary
                    if (!eventsByCategory.ContainsKey(nextEvent.Category))
                    {
                        eventsByCategory[nextEvent.Category] = new List<Event>();
                    }

                    eventsByCategory[nextEvent.Category].Add(nextEvent);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and log the error
                MessageBox.Show($"An error occurred while populating events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateCategoryComboBox()
        {
            categoryComboBox.Items.Clear(); // Clears existing items

            // Loops through the keys (categories) in the SortedDictionary
            foreach (var category in eventsByCategory.Keys)
            {
                categoryComboBox.Items.Add(category); // Adds each category to the ComboBox
            }

            if (categoryComboBox.Items.Count > 0)
            {
                categoryComboBox.SelectedIndex = 0; // Sets default selected index
            }
        }

        private void DisplayEventsByCategory(string category)
        {
            eventsListView.Items.Clear(); // This method clears the ListView before adding new items

            if (eventsByCategory.ContainsKey(category))
            {
                foreach (var ev in eventsByCategory[category])
                {
                    var listItem = new ListViewItem(new string[]
                    {
                ev.EventName,
                ev.Date.ToShortDateString(),
                ev.Category,
                ev.Priority.ToString()
                    });

                    eventsListView.Items.Add(listItem);
                }
            }
            else
            {
                MessageBox.Show("No events found for the selected category.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = datePicker.Value;

            // Filter events based on the selected date
            var filteredEvents = PriorityQueueManager.FilterEventsByDate(selectedDate);
            DisplayFilteredEvents(filteredEvents);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Back Button
        {
            MainMenu mainForm = new MainMenu();
            mainForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e) // Search Button
        {
            string searchTerm = searchTextBox.Text.Trim().ToLower();

            // Filters events based on the search term
            var filteredEvents = PriorityQueueManager.SearchEvents(searchTerm);
            DisplayFilteredEvents(filteredEvents);
        }

        private void DisplayFilteredEvents(IEnumerable<Event> events)
        {
            eventsListView.Items.Clear(); // Clears the current list

            foreach (var ev in events)
            {
                var listItem = new ListViewItem(new string[]
                {
            ev.EventName,
            ev.Date.ToShortDateString(),
            ev.Category,
            ev.Priority.ToString()
                });

                eventsListView.Items.Add(listItem);
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            DisplayEventsByCategory(selectedCategory);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // Recommendation Feature Text Box
        {
            string userInput = RecommendationTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(userInput))
            {
                RecommendSimilarEvents(userInput);
            }
        }

        private void RecommendSimilarEvents(string searchTerm)
        {
            var recommendedEvents = new List<Event>();

            foreach (var category in eventsByCategory.Keys)
            {
                foreach (var ev in eventsByCategory[category])
                {
                    if (ev.EventName.ToLower().Contains(searchTerm.ToLower()))
                    {
                        recommendedEvents.Add(ev);
                    }
                }
            }

            DisplayRecommendations(recommendedEvents);
        }

        private void DisplayRecommendations(IEnumerable<Event> recommendedEvents)
        {
            RecommendationTextBox.Clear();
            foreach (var ev in recommendedEvents)
            {
                RecommendationTextBox.AppendText($"Event: {ev.EventName} - Date: {ev.Date.ToShortDateString()} - Category: {ev.Category}\n");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocalEvents_AnnoucementsForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

