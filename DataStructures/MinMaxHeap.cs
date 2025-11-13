using System;
using System.Collections.Generic;
using Municipality.Models;

namespace Municipality.DataStructures
{
    // this is  a simple min heap priority from lower value equals higher priority
    public class MinHeap
    {
      private List<ServiceRequest> data = new List<ServiceRequest>();
         public int Count => data.Count;
             public void Add(ServiceRequest item)
      {
          data.Add(item);
           HeapifyUp(data.Count - 1);
        }

      public ServiceRequest Pop()
        {
          if (data.Count == 0) return null;
            var root = data[0];
         var last = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            if (data.Count > 0)
            {
             data[0] = last;
                HeapifyDown(0);
            }
            return root;
        }
      public IEnumerable<ServiceRequest> AsSortedList()
        {
            // code for returning items ordered by priority without modifying heap
          var copy = new List<ServiceRequest>(data);
            var result = new List<ServiceRequest>();
          var heap = new MinHeap();
            foreach (var i in copy) heap.Add(i);
         while (heap.Count > 0) result.Add(heap.Pop());
            return result;
        }

        private void HeapifyUp(int idx)
        {
         while (idx > 0)
            {
                int parent = (idx - 1) / 2;
             if (data[idx].Priority >= data[parent].Priority) break;
                  Swap(idx, parent);
              idx = parent;
            }
        }
        



        private void HeapifyDown(int idx)
        {
            int last = data.Count - 1;
            while (true)
            {
             int left = idx * 2 + 1;
                int right = idx * 2 + 2;
            int smallest = idx;
                 if (left <= last && data[left].Priority < data[smallest].Priority) smallest = left;
                if (right <= last && data[right].Priority < data[smallest].Priority) smallest = right;
                     if (smallest == idx) break;
                Swap(idx, smallest);
              idx = smallest;
            }
        }

        private void Swap(int a, int b)
        {
      var t = data[a]; data[a] = data[b]; data[b] = t;
        }
    }
}
       