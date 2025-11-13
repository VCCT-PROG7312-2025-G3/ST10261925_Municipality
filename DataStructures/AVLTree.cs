using System;
using System.Collections.Generic;
using Municipality.Models;

namespace Municipality.DataStructures
{
    // avl tree keyed by the service request id
    public class AVLTree
    {
        private class Node
        {
             public ServiceRequest Value;
           public Node Left;
             public Node Right;
           public int Height;
        }

        private Node root;
         private int Height(Node n) => n?.Height ?? 0;
            private int BalanceFactor(Node n) => (n == null) ? 0 : Height(n.Left) - Height(n.Right);
       private void UpdateHeight(Node n) => n.Height = Math.Max(Height(n.Left), Height(n.Right)) + 1;
            private Node RotateRight(Node y)
        {
            var x = y.Left;
           var T2 = x.Right;
             x.Right = y;
          y.Left = T2;
          UpdateHeight(y);
            UpdateHeight(x);
             return x;
        }
      private Node RotateLeft(Node x)
        {
              var y = x.Right;
            var T2 = y.Left;
         y.Left = x;
            x.Right = T2;
          UpdateHeight(x);
               UpdateHeight(y);
            return x;
        }

        public void Insert(ServiceRequest req)
        {
            root = Insert(root, req);
        }

        private Node Insert(Node node, ServiceRequest req)
        {
      if (node == null) return new Node { Value = req, Height = 1 };
             int cmp = string.Compare(req.Id, node.Value.Id, StringComparison.Ordinal);
          if (cmp < 0) node.Left = Insert(node.Left, req);
              else if (cmp > 0) node.Right = Insert(node.Right, req);
          else { node.Value = req; return node; }
            UpdateHeight(node);
            int balance = BalanceFactor(node);
            // code for left left
           if (balance > 1 && string.Compare(req.Id, node.Left.Value.Id, StringComparison.Ordinal) < 0)
                return RotateRight(node);
            // code for right right 
              if (balance < -1 && string.Compare(req.Id, node.Right.Value.Id, StringComparison.Ordinal) > 0)
                return RotateLeft(node);
            // code for left right
      if (balance > 1 && string.Compare(req.Id, node.Left.Value.Id, StringComparison.Ordinal) > 0)
            {
              node.Left = RotateLeft(node.Left);
                  return RotateRight(node);
            }
            // code for right left 
        if (balance < -1 && string.Compare(req.Id, node.Right.Value.Id, StringComparison.Ordinal) < 0)
            {
       node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }
            return node;
        }



            public ServiceRequest Search(string id)
        {
          var c = root;
            while (c != null)
            {
            int cmp = string.Compare(id, c.Value.Id, StringComparison.Ordinal);
             if (cmp == 0) return c.Value;
            c = (cmp < 0) ? c.Left : c.Right;
            }
          return null;
        }

     public IEnumerable<ServiceRequest> InOrder()
        {
           var list = new List<ServiceRequest>(); InOrder(root, list); return list;
        }
       private void InOrder(Node node, List<ServiceRequest> list)
        {
           if (node == null) return; InOrder(node.Left, list);
             list.Add(node.Value);
          InOrder(node.Right, list);
        }
    } }  
    
