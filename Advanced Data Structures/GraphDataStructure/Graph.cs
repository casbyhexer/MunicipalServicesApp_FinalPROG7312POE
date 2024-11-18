using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures.GraphDataStructure
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjList;  // Adjacency list for storing graph

        public Graph()
        {
            adjList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(ServiceRequest request)
        {
            if (!adjList.ContainsKey(request.RequestId))
            {
                adjList[request.RequestId] = new List<int>();
            }
        }

        public void AddEdge(int requestId1, int requestId2)
        {
            if (adjList.ContainsKey(requestId1) && adjList.ContainsKey(requestId2))
            {
                adjList[requestId1].Add(requestId2);
            }
        }

        public List<int> GetAdjacent(int requestId)
        {
            return adjList.ContainsKey(requestId) ? adjList[requestId] : new List<int>();
        }

        // Get all vertices (keys) in the graph
        public List<ServiceRequest> GetAllVertices()
        {
            List<ServiceRequest> vertices = new List<ServiceRequest>();
            foreach (var key in adjList.Keys)
            {
                // Assuming you have ServiceRequest objects with RequestId as a property
                vertices.Add(new ServiceRequest { RequestId = key });
            }
            return vertices;
        }

        // Display the graph (for testing)
        public void DisplayGraph()
        {
            foreach (var vertex in adjList)
            {
                Console.WriteLine($"Request {vertex.Key}: {string.Join(", ", vertex.Value)}");
            }
        }
    }
}


