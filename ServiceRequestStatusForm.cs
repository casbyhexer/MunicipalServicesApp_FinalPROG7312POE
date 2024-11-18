using MunicipalServicesApp.Advanced_Data_Structures;
using MunicipalServicesApp.Advanced_Data_Structures.AvlTreeDataStructure;
using MunicipalServicesApp.Advanced_Data_Structures.Data_Structures;
using MunicipalServicesApp.Advanced_Data_Structures.GraphDataStructure;
using MunicipalServicesApp.Advanced_Data_Structures.GraphDataStructure.MunicipalServicesApp.Advanced_Data_Structures.GraphDataStructure;
using MunicipalServicesApp.Advanced_Data_Structures.HeapDataStructure;
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
    public partial class ServiceRequestStatusForm : Form
    {
        private BinarySearchTree serviceRequestsTree; // Initialized Binary Search Tree
        private MaxHeap maxHeap; // Initialized Heap
        private Graph graph; // Initialized Graph
        private AVLTree avlTree; // Initialized AVL Tree

        // Declare a reference to the GraphPanel so we can remove it later
        private GraphPanel graphPanel;

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            serviceRequestsTree = new BinarySearchTree();
            maxHeap = new MaxHeap();
            graph = new Graph();
            avlTree = new AVLTree();

        }

        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchAndTrack_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListView()
        {
            // Clear the existing items in the ListView
            listViewServiceRequests.Items.Clear();

            // Iterate through the service requests in in-order (sorted) order
            foreach (var request in serviceRequestsTree.GetInorderEnumerator())
            {
                // Create a new ListViewItem for each service request
                ListViewItem item = new ListViewItem(request.RequestId.ToString()); // Display RequestId in the first column

                // Add the properties as subitems
                item.SubItems.Add(request.Status); // Add Status as the second column
                item.SubItems.Add(request.Priority.ToString()); // Add Priority as the third column

                // Add the item to the ListView
                listViewServiceRequests.Items.Add(item);
            }
        }

        private void btnSearchAndTrack_Click(object sender, EventArgs e)
        {

            // Guard against empty or invalid RequestId input
            string requestIdText = txtSearchAndTrack.Text;
            Guard.AgainstEmptyOrWhitespace(requestIdText, nameof(requestIdText));

            int requestId;
            if (!int.TryParse(requestIdText, out requestId))
            {
                MessageBox.Show("Please enter a valid integer Request ID.");
                return;
            }

            // Guard against invalid RequestId
            Guard.AgainstNegative(requestId, nameof(requestId));

            // Search for the service request
            ServiceRequest request = serviceRequestsTree.Search(requestId);

            if (request != null)
            {
                // Display the found request in the ListView
                listViewServiceRequests.Items.Clear();
                ListViewItem item = new ListViewItem(request.RequestId.ToString());
                item.SubItems.Add(request.Status);
                item.SubItems.Add(request.Priority.ToString());
                listViewServiceRequests.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Request not found.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = new MainMenu();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // Add Requests button
        {
            ServiceRequest request = new ServiceRequest
            {
                RequestId = 1,  // Example RequestId
                Status = "In Progress",
                Priority = 2
            };
            serviceRequestsTree.Add(request);

            // Update the ListView to display all service requests
            UpdateListView();
        }

        private void listViewServiceRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the ListView first
            listViewServiceRequests.Items.Clear();

            // Iterate through the service requests in in-order
            foreach (var request in serviceRequestsTree.GetInorderEnumerator())
            {
                ListViewItem item = new ListViewItem(request.RequestId.ToString());
                item.SubItems.Add(request.Status);
                item.SubItems.Add(request.Priority.ToString());
                listViewServiceRequests.Items.Add(item);
            }
        }

        private void btnAddRequestToHeap_Click(object sender, EventArgs e)
        {
            ServiceRequest request = new ServiceRequest
            {
                RequestId = 1,  // Example RequestId
                Status = "Pending",
                Priority = 5
            };

            // Add the request to the Max-Heap
            maxHeap.Insert(request);

            // Optionally, update the UI or ListView
            UpdateListViewWithMaxHeap();
        }

        private void btnExtractMax_Click(object sender, EventArgs e)
        {
            // Extract the request with the highest priority
            ServiceRequest request = maxHeap.ExtractMax();

            if (request != null)
            {
                MessageBox.Show($"Highest priority request: {request.RequestId}, {request.Status}, {request.Priority}");
            }
            else
            {
                MessageBox.Show("Heap is empty.");
            }
        }

        private void UpdateListViewWithMaxHeap()
        {
            // Clear the existing items in the ListView
            listViewServiceRequests.Items.Clear();

            // Iterate through the requests in the MaxHeap
            // Assuming we have a method to get all requests in the heap (not implemented directly in MaxHeap)
            foreach (var request in maxHeap.GetAllRequests())  // Modify to suit the MaxHeap class if necessary
            {
                // Create a new ListViewItem for each service request
                ListViewItem item = new ListViewItem(request.RequestId.ToString()); // Display RequestId in the first column

                // Add the properties as subitems
                item.SubItems.Add(request.Status); // Add Status as the second column
                item.SubItems.Add(request.Priority.ToString()); // Add Priority as the third column

                // Add the item to the ListView
                listViewServiceRequests.Items.Add(item);
            }
        }

        private void btnAddVertex_Click(object sender, EventArgs e)
        {
            ServiceRequest request = new ServiceRequest
            {
                RequestId = int.Parse(txtSearchAndTrack.Text),  // Get RequestId from a TextBox (e.g., txtRequestId)
                Status = txtSearchAndTrack.Text,                   // Get Status from a TextBox (e.g., txtStatus)
                Priority = int.Parse(txtSearchAndTrack.Text)     // Get Priority from a TextBox (e.g., txtPriority)
            };

            // Add the request as a vertex to the graph
            graph.AddVertex(request);
        }

        private void btnDisplayGraph_Click(object sender, EventArgs e)
        {
            // Create a new GraphPanel and set its location and size
            graphPanel = new GraphPanel(graph);  // Pass the Graph object to the panel

            // Set the location of the graph panel next to the "Display Graph" button
            graphPanel.Location = new Point(btnDisplayGraph.Location.X + btnDisplayGraph.Width + 10, btnDisplayGraph.Location.Y);

            // Set the size to make it smaller (for a more compact display)
            graphPanel.Size = new Size(300, 300);

            // Add the GraphPanel to the form's controls
            this.Controls.Add(graphPanel);

            // Invalidate the panel to trigger a repaint
            graphPanel.Invalidate();
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            int requestId1 = int.Parse(txtSearchAndTrack.Text);  // Get RequestId1 from a TextBox (e.g., txtRequestId1)
            int requestId2 = int.Parse(txtSearchAndTrack.Text);  // Get RequestId2 from a TextBox (e.g., txtRequestId2)

            // Add an edge between two requests (dependencies)
            graph.AddEdge(requestId1, requestId2);

        }

        private void btnCloseGraph_Click(object sender, EventArgs e)
        {
            // Remove the GraphPanel from the form's controls
            if (graphPanel != null)
            {
                this.Controls.Remove(graphPanel);  // Remove the GraphPanel from the form
                graphPanel.Dispose();  // Dispose of the GraphPanel to free up resources
                graphPanel = null;  // Clear the reference
            }
        }

        private void btnInsertRequest_Click(object sender, EventArgs e)
        {
            // Validates input
            if (int.TryParse(txtRequestId.Text, out int requestId) && int.TryParse(txtPriority.Text, out int priority))
            {
                string status = txtStatus.Text;

                // Insert into AVL tree
                avlTree.Insert(requestId, status, priority);

                // Update ListView with AVL tree data
                UpdateListViewFromAVL();
            }
            else
            {
                MessageBox.Show("Please enter valid RequestId and Priority values.");
            }
        }

        private void btnSearchRequest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRequestId.Text, out int requestId))
            {
                var node = avlTree.Search(requestId);
                if (node != null)
                {
                    MessageBox.Show($"Found Request - ID: {node.RequestId}, Status: {node.Status}, Priority: {node.Priority}");
                }
                else
                {
                    MessageBox.Show("Request not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid RequestId.");
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRequestId.Text, out int requestId))
            {
                avlTree.Delete(requestId);
                UpdateListViewFromAVL();
            }
            else
            {
                MessageBox.Show("Please enter a valid RequestId.");
            }
        }

        // Update the ListView with requests from AVL Tree
        private void UpdateListViewFromAVL()
        {
            listViewServiceRequests.Items.Clear();
            foreach (var node in avlTree.InOrderTraversal())
            {
                ListViewItem item = new ListViewItem(node.RequestId.ToString());
                item.SubItems.Add(node.Status);
                item.SubItems.Add(node.Priority.ToString());
                listViewServiceRequests.Items.Add(item);
            }
        }
    }
}
