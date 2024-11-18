using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures.AvlTreeDataStructure
{
    public class AVLTree
    {
        private AVLTreeNode root;

        // Method to insert a new node in the AVL tree
        public void Insert(int requestId, string status, int priority)
        {
            root = Insert(root, requestId, status, priority);
        }

        // Helper method for insert with balancing
        private AVLTreeNode Insert(AVLTreeNode node, int requestId, string status, int priority)
        {
            // Perform standard BST insert
            if (node == null)
                return new AVLTreeNode(requestId, status, priority);

            if (requestId < node.RequestId)
                node.Left = Insert(node.Left, requestId, status, priority);
            else if (requestId > node.RequestId)
                node.Right = Insert(node.Right, requestId, status, priority);
            else
                return node; // Duplicate requestId not allowed

            // Update height of current node
            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            // Get the balance factor and balance the tree
            int balance = GetBalance(node);

            // Left Left case
            if (balance > 1 && requestId < node.Left.RequestId)
                return RightRotate(node);

            // Right Right case
            if (balance < -1 && requestId > node.Right.RequestId)
                return LeftRotate(node);

            // Left Right case
            if (balance > 1 && requestId > node.Left.RequestId)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left case
            if (balance < -1 && requestId < node.Right.RequestId)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node; // Return the (unchanged) node pointer
        }

        // Left rotate subtree rooted with x
        private AVLTreeNode LeftRotate(AVLTreeNode x)
        {
            AVLTreeNode y = x.Right;
            AVLTreeNode T2 = y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            return y; // Return new root
        }

        // Right rotate subtree rooted with y
        private AVLTreeNode RightRotate(AVLTreeNode y)
        {
            AVLTreeNode x = y.Left;
            AVLTreeNode T2 = x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x; // Return new root
        }

        // Get the height of a node
        private int GetHeight(AVLTreeNode node)
        {
            if (node == null)
                return 0;
            return node.Height;
        }

        // Get the balance factor of a node
        private int GetBalance(AVLTreeNode node)
        {
            if (node == null)
                return 0;
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        // In-order traversal to get all nodes in the tree
        public IEnumerable<AVLTreeNode> InOrderTraversal()
        {
            return InOrderTraversal(root);
        }

        private IEnumerable<AVLTreeNode> InOrderTraversal(AVLTreeNode node)
        {
            if (node != null)
            {
                foreach (var n in InOrderTraversal(node.Left))
                    yield return n;
                yield return node;
                foreach (var n in InOrderTraversal(node.Right))
                    yield return n;
            }
        }

        // Method to search for a node in the AVL tree
        public AVLTreeNode Search(int requestId)
        {
            return Search(root, requestId);
        }

        private AVLTreeNode Search(AVLTreeNode node, int requestId)
        {
            if (node == null || node.RequestId == requestId)
                return node;

            if (requestId < node.RequestId)
                return Search(node.Left, requestId);

            return Search(node.Right, requestId);
        }

        // Method to delete a node from the AVL tree
        public void Delete(int requestId)
        {
            root = Delete(root, requestId);
        }

        private AVLTreeNode Delete(AVLTreeNode root, int requestId)
        {
            // Standard BST delete
            if (root == null)
                return root;

            if (requestId < root.RequestId)
                root.Left = Delete(root.Left, requestId);
            else if (requestId > root.RequestId)
                root.Right = Delete(root.Right, requestId);
            else
            {
                // Node with only one child or no child
                if (root.Left == null || root.Right == null)
                {
                    AVLTreeNode temp = root.Left ?? root.Right;
                    if (temp == null)
                    {
                        temp = root;
                        root = null;
                    }
                    else
                        root = temp;
                }
                else
                {
                    // Node with two children: get the inorder successor (smallest in the right subtree)
                    AVLTreeNode temp = MinValueNode(root.Right);
                    root.RequestId = temp.RequestId;
                    root.Status = temp.Status;
                    root.Priority = temp.Priority;

                    root.Right = Delete(root.Right, temp.RequestId);
                }
            }

            // If the tree has only one node, return it
            if (root == null)
                return root;

            // Update height of current node
            root.Height = Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;

            // Get the balance factor of this node to check whether it became unbalanced
            int balance = GetBalance(root);

            // Left Left case
            if (balance > 1 && GetBalance(root.Left) >= 0)
                return RightRotate(root);

            // Right Right case
            if (balance < -1 && GetBalance(root.Right) <= 0)
                return LeftRotate(root);

            // Left Right case
            if (balance > 1 && GetBalance(root.Left) < 0)
            {
                root.Left = LeftRotate(root.Left);
                return RightRotate(root);
            }

            // Right Left case
            if (balance < -1 && GetBalance(root.Right) > 0)
            {
                root.Right = RightRotate(root.Right);
                return LeftRotate(root);
            }

            return root;
        }

        // Method to find the node with the minimum value (used during deletion)
        private AVLTreeNode MinValueNode(AVLTreeNode node)
        {
            AVLTreeNode current = node;
            while (current.Left != null)
                current = current.Left;
            return current;
        }
    }

}
