using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Advanced_Data_Structures.HeapDataStructure
{
    public class MaxHeap
    {
        private List<ServiceRequest> heap;

        public MaxHeap()
        {
            heap = new List<ServiceRequest>();
        }

        public void Insert(ServiceRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);  // Maintain heap property
        }

        public ServiceRequest ExtractMax()
        {
            if (heap.Count == 0)
                return null;

            // Swap the root with the last element
            ServiceRequest maxRequest = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            // Restore heap property by heapifying down from the root
            HeapifyDown(0);

            return maxRequest;
        }

        // Get all requests sorted by priority (high to low)
        public List<ServiceRequest> GetAllRequests()
        {
            // Return the heap sorted by Priority in descending order
            return heap.OrderByDescending(r => r.Priority).ToList();
        }

        private void HeapifyUp(int index)
        {
            while (index > 0 && heap[Parent(index)].Priority < heap[index].Priority)
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        private void HeapifyDown(int index)
        {
            int leftChild = LeftChild(index);
            int rightChild = RightChild(index);
            int largest = index;

            if (leftChild < heap.Count && heap[leftChild].Priority > heap[largest].Priority)
                largest = leftChild;

            if (rightChild < heap.Count && heap[rightChild].Priority > heap[largest].Priority)
                largest = rightChild;

            if (largest != index)
            {
                Swap(index, largest);
                HeapifyDown(largest);
            }
        }

        private void Swap(int i, int j)
        {
            ServiceRequest temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        private int Parent(int index) => (index - 1) / 2;
        private int LeftChild(int index) => 2 * index + 1;
        private int RightChild(int index) => 2 * index + 2;

        public ServiceRequest GetMax() => heap.Count > 0 ? heap[0] : null;
        public bool IsEmpty() => heap.Count == 0;
    }


}
