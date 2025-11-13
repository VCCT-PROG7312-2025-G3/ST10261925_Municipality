
using System;
using System.Collections.Generic;
using Municipality.Models;

namespace Municipality.DataStructures
{
    // this code is the simple BST keyed service request id
    public class BinarySearchTree
    {
   private class Node
     {
         public ServiceRequest Value;
          public Node Left;
            public Node Right;
        }
        private Node root;

        public void Insert(ServiceRequest req)
        {
       root = Insert(root, req);
        }
        private Node Insert(Node node, ServiceRequest req)
        {
            if (node == null)
            {
           
        return new Node { Value = req };
            }
            int cmp = string.Compare(req.Id, node.Value.Id, StringComparison.Ordinal);
          if (cmp < 0) node.Left = Insert(node.Left, req);
            else if (cmp > 0) node.Right = Insert(node.Right, req);
          else node.Value = req; // replace
            return node;
        }

      public ServiceRequest Search(String id)
        {
          var n = root;
           while (n != null)
            {
             int cmp = string.Compare(id, n.Value.Id, StringComparison.Ordinal);
             if (cmp == 0) return n.Value;
                    if (cmp < 0) n = n.Left; else n = n.Right;
            }
          return null;
        }
        public IEnumerable<ServiceRequest> InOrder()
        {
            var list = new List<ServiceRequest>();
          InOrder(root, list);
            return list;
        }
     private void InOrder(Node node, List<ServiceRequest> list)
        {
            if (node == null) return;
             InOrder(node.Left, list);
            list.Add(node.Value);
           InOrder(node.Right, list);
        }
        public IEnumerable<ServiceRequest> LevelOrder()
        {
             var list = new List<ServiceRequest>();
            PreOrder(root, list);
          return list;

        }
       public IEnumerable<ServiceRequest> PreOrder()
        {
            var list = new List<ServiceRequest>();
        PreOrder(root, list);
           return list;
        }

            private void PreOrder(Node node, List<ServiceRequest> list)
        {
          if (node == null) return;
                list.Add(node.Value);
           PreOrder(node.Left, list);
               PreOrder(node.Right, list);
        }

     public IEnumerable<ServiceRequest> PostOrder()
        {
            var list = new List<ServiceRequest>();
              PostOrder(root, list);
         return list;
        }
     private void PostOrder(Node node, List<ServiceRequest> list)
        {
           if (node == null) return;
              PostOrder(node.Left, list);
          PostOrder(node.Right, list);
            list.Add(node.Value);
        }

    }
}
    
