using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures.Data_Structures
{
    public class BinarySearchTree
    {
        private BinaryTreeNode<ServiceRequest> root;

        // Adds a new ServiceRequest to the tree
        public void Add(ServiceRequest request)
        {
            root = AddNode(root, request);
        }

        // Helper method to add nodes recursively
        private BinaryTreeNode<ServiceRequest> AddNode(BinaryTreeNode<ServiceRequest> node, ServiceRequest request)
        {
            if (node == null)
            {
                return new BinaryTreeNode<ServiceRequest>(request);
            }

            if (request.CompareTo(node.Value) < 0) // RequestId < Node's RequestId -> go to left
            {
                node.Left = AddNode(node.Left, request);
            }
            else if (request.CompareTo(node.Value) > 0) // RequestId > Node's RequestId -> go to right
            {
                node.Right = AddNode(node.Right, request);
            }

            return node;
        }

        // Search for a ServiceRequest by RequestId
        public ServiceRequest Search(int requestId)
        {
            return SearchNode(root, requestId);
        }

        // Helper method to search recursively
        private ServiceRequest SearchNode(BinaryTreeNode<ServiceRequest> node, int requestId)
        {
            if (node == null) return null;

            if (node.Value.RequestId == requestId)
                return node.Value;
            else if (requestId < node.Value.RequestId)
                return SearchNode(node.Left, requestId);
            else
                return SearchNode(node.Right, requestId);
        }

        // In-order traversal to get all ServiceRequests in sorted order
        public IEnumerable<ServiceRequest> GetInorderEnumerator()
        {
            List<ServiceRequest> result = new List<ServiceRequest>();
            InorderTraversal(root, result);
            return result;
        }

        // Recursive helper method to perform in-order traversal
        private void InorderTraversal(BinaryTreeNode<ServiceRequest> node, List<ServiceRequest> result)
        {
            if (node != null)
            {
                InorderTraversal(node.Left, result);
                result.Add(node.Value); // Add the node's value (ServiceRequest)
                InorderTraversal(node.Right, result);
            }
        }

    }

}
