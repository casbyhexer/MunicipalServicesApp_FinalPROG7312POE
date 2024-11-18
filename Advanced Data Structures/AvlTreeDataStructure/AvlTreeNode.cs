using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures.AvlTreeDataStructure
{
    public class AVLTreeNode
    {
        public int RequestId { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public AVLTreeNode Left { get; set; }
        public AVLTreeNode Right { get; set; }
        public int Height { get; set; }

        public AVLTreeNode(int requestId, string status, int priority)
        {
            RequestId = requestId;
            Status = status;
            Priority = priority;
            Height = 1; // Height starts at 1
        }
    }

}
