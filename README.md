# MunicipalServicesApp

# Table of Contents
- Overview	
- Features	
- Requirements	
- How to Compile the Application	
- How to Run the Application	
- How to Use the Application	
- How Advanced Data Structures are used	
- Troubleshooting	

# Overview

C# was used to create the Windows Form Application for Municipal Services. By offering an easy-to-use interface, it is intended to simplify municipal services for people. Users of the app can: 
•	Report Issues: File and monitor reports of neighbourhood issues.
•	View Local Events & Announcements: View events with search, filtering, and suggestion features. 
•	Check the Status of Service Requests: Use advanced data structures to successfully arrange and retrieve service requests.

The application manages service requests and offers flexible reliable operations using advanced data structures like heaps, graphs, AVL trees, and binary search trees. The Municipal Services Application compilation, operation, and usage instructions are given in this README. A straightforward and effective method of managing service requests with advanced data structures

# Features
1.	Welcome Screen: View Main Menu Button

2.	Main Menu Form: Go through the many sections, such as:
•	Report Issues 
•	Announcements & Local Events
•	Service Requests Status 
•	To exit the app, press the "Exit" button.

3.	Report Issues Form:
•	By entering a description, location, category, and preference, users can record local issues.
•	Offers the ability to connect media for more thorough reports.

4.	Announcements & Local Events Form:
•	Displays an events list.
•	Sort events by date or category.
•	Search capabilities that offer suggestions according to search trends.

5.	Event Related Data Structures: Sorted list, priority queue

6.	Service Request Status Form:
•	Shows the service requests that have been filed in an ordered manner.
•	Users can read a request's details by clicking on it or adding a request.

7.	Advanced Data Structures:
•	Trees: Arrange and retrieve service requests (AVL, BST) 
•	Add Service Requests in the (AVL Tree): There are text boxes to insert the Priority, Status, and RequestId. To include a new service request in the AVL Tree, press the button btnInsertRequest. The service request will appear in the ListView after being added to the AVL Tree.
•	Use a RequestId then Search for Service Requests (AVL Tree): Button: btnSearchRequest will use its RequestId to look for the service request in the AVL Tree. The detected request details (ID, Status, and Priority) will be displayed in a MessageBox.
•	Delete Service Requests (AVL Tree): Click Delete after entering the request's RequestId. Button: btnDeleteRequest will update the ListView and remove the request from the AVL Tree.
•	Max-Heap Operations: Use the Add Request to Heap button to add requests with a higher priority to the Max-Heap. Extract Max: Pull the most important request out of the heap and displays it in a message box.
•	Graph Visualization: The program enables the service requests to be seen as a graph. Button: btnDisplayGraph will show a graph with dependencies represented by edges and requests represented by nodes. The button labeled "btnCloseGraph" eliminates the form's graph display.
•	Graph Operations: Add Edge: btnAddEdge creates an edge (dependence) between two vertices (service requests). In the graph, requests can be represented as nodes and added as vertices.

# Requirements
•	Operating System: Windows 7 or later
•	Framework: .NET Framework 4.7.2 or later 
•	Development Environment: Visual Studio 2019 or later
•	Languages: C#

# How to Compile the Application
First, set up Visual Studio. 
•	Go to https://visualstudio.microsoft.com/ to download and install Visual Studio. 
•	Make sure you choose the.NET Desktop Development workload during installation.

Step 2: Download or Clone the Project 
•	Use the following commands to clone this repository: git clone https://github.com/YourUsername/Municipal-Services-App.git OR download and unzip the repository from a ZIP file. 

Step 3: Launch Visual Studio and open the project. 
•	Launch Visual Studio. 
•	Choose File > Open > Solution/Project. 
•	Go to the folder where the repository was extracted or cloned. 
•	Launch the file MunicipalServicesApp.sln. 

Step 4: If required, restore the NuGet packages. 
•	Click Restore if Visual Studio asks you to restore NuGet packages. 

Step 5: Build the Project 
•	Select Build > Build Solution in Visual Studio (or use Ctrl+Shift+B). 
•	Verify that the build finishes successfully.

Step 6: Check Dependencies
Verify that the project accurately references each dependency:
•	Graph, AVLTree, MaxHeap, and BinarySearchTree should all be correctly defined and included in the project.
•	Verify that each file has the required namespaces included at the top.

# How to Run the Application
Step 1: Launch the application.
•	Press F5 or click the Start button (green play symbol) in Visual Studio. 
•	The Welcome Screen then clicking the view Main Menu button will appear when the application launches.

Step 2: Use the Main Menu to navigate
To access various features, use the Main Menu:
•	Report Issues
•	Announcements & Local Events
•	Service Request Status
•	Exit: Ends the program.

# How to Use the Application
1.	Report Issues: 
From the Main Menu, select "Report Issues".
•	Enter the problem details in the form: 
o	Location: Indicate where the problem is. 
o	Category: From the dropdown, choose a category. 
o	Description: Give a thorough explanation. 
o	Priority: Indicate how important the problem is. 
o	Attach Media: To add important media, click the "Attach File" button. 
o	Click Submit to submit this issue. 
•	The problem will be noted and recorded in the area titled "Service Request Status."

2.	Announcements & Local Events:
Then select "Local Events & Announcements." 
•	Filter Events: 
o	To filter events by category, utilize the Category ComboBox. 
o	To filter events based on a certain date, use the Date Picker. 
•	Search for Events: 
o	Click the Search button after entering a keyword in the search bar.
o	The recommendation area will provide events that are suggested based on your search history.
•	View Event Info:
o	To access comprehensive details, click on any event in the list.

3.	Service Request Status
Then, select "Service Request Status."
•	ListView Display:
o	Look into the service requests' order.
o	Individual requests are represented by nodes.
•	Track Requests:
o	To view information about a request, click on a node in the ListView.
o	ID-based search requests:
o	To find it, type a Request ID into the search window and select the Seach & Track Request option.

4.	Exit
•	To end the application, click the Exit button on the Main Menu.

# How Advanced Data Structures are used
1. BinarySearchTree: 
•	For service requests, this offers a basic Binary Search Tree.
•	Allows in-order traverse, insert, and search.

2. AVLTree:
•	A binary search tree that balances itself.
•	Uses rotations to implement insert, search, remove, and rebalance.

3. MaxHeap:
•	Uses a Max-Heap to prioritize requests and manage them.
•	Enables maximum operations for inserting and extracting.

4. Graph:
•	Shows a structure with dependencies represented by the edges and service requests at the vertices.
•	Allows the addition of edges (dependencies) and vertices (requests).

5. ServiceRequest:
•	Uses properties like RequestId, Status, and Priority to represent a service request.

# Troubleshooting
Build Errors: 
•	Make sure the.NET Desktop Development workload is installed. 
Runtime errors: 
•	Confirm that all needed fields contain valid input. 


