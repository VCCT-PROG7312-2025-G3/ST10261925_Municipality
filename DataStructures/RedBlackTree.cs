using System;
using System.Collections.Generic;
using Municipality.Models;

namespace Municipality.DataStructures
{
    //this is simplified red-black tree implementation for demonstration 

   public class RedBlackTree
    {
     private enum Color { Red, Black }

        private class Node
        {
        public ServiceRequest Value;
            public Node Left, Right, Parent;
                  public Color Color;
           public Node(ServiceRequest v)
            {
                    Value = v; Color = Color.Red;
            }
        }

        private Node root;

        private void RotateLeft(Node x)
        {
          var y = x.Right;
            x.Right = y.Left;
                if (y.Left != null) y.Left.Parent = x;
            y.Parent = x.Parent;
         if (x.Parent == null) root = y;
            else if (x == x.Parent.Left) x.Parent.Left = y;
          else x.Parent.Right = y;
            y.Left = x; x.Parent = y;
        }

        private void RotateRight(Node x)
        {
            var y = x.Left;
              x.Left = y.Right;
            if (y.Right != null) y.Right.Parent = x;
               y.Parent = x.Parent;
          if (x.Parent == null) root = y;
            else if (x == x.Parent.Right) x.Parent.Right = y;
           else x.Parent.Left = y;
             y.Right = x; x.Parent = y;
        }

        public void Insert(ServiceRequest v)
        {
          var node = new Node(v);
            Node y = null;
            var x = root;
          while (x != null)
            {
                y = x;
                int cmp = string.Compare(node.Value.Id, x.Value.Id, StringComparison.Ordinal);
                if (cmp < 0) x = x.Left; else x = x.Right;
            }
           node.Parent = y;
                if (y == null) root = node;
            else if (string.Compare(node.Value.Id, y.Value.Id, StringComparison.Ordinal) < 0) y.Left = node;
             else y.Right = node;
                    InsertFixup(node);
        }
        private void InsertFixup(Node h)
        {
           while (h.Parent != null && h.Parent.Color == Color.Red)
            {
                if (h.Parent == h.Parent.Parent.Left)
                {
                var y = h.Parent.Parent.Right;
                    if (y != null && y.Color == Color.Red)
                    {
             h.Parent.Color = Color.Black; y.Color = Color.Black; h.Parent.Parent.Color = Color.Red; h = h.Parent.Parent;
                    }
                     else
                    {
                if (h == h.Parent.Right) { h = h.Parent; RotateLeft(h); }
                        h.Parent.Color = Color.Black; h.Parent.Parent.Color = Color.Red; RotateRight(h.Parent.Parent);
                    }
             }
                else
                {
             var y = h.Parent.Parent.Left;
                    if (y != null && y.Color == Color.Red)
                    {
              h.Parent.Color = Color.Black; y.Color = Color.Black; h.Parent.Parent.Color = Color.Red; h = h.Parent.Parent;
                    }
                    else
                    {
                  if (h == h.Parent.Left) { h = h.Parent; RotateRight(h); }
                        h.Parent.Color = Color.Black; h.Parent.Parent.Color = Color.Red; RotateLeft(h.Parent.Parent);
                }
                }
            }
          root.Color = Color.Black;
        }

        public ServiceRequest Search(string id)
        {
            var g = root;
            while (g != null)
            {
                int cmp = string.Compare(id, g.Value.Id, StringComparison.Ordinal);if (cmp == 0) return g.Value;g = (cmp < 0) ? g.Left : g.Right;
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
            if (node == null) return; InOrder(node.Left, list);list.Add(node.Value);
           InOrder(node.Right, list);
        }
    }
}

      
