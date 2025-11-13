using System;
using System.Collections.Generic;
using System.Linq;
using Municipality.Models;

namespace Municipality.DataStructures
{
    ///graph using adjacency list 

    public class Graph
    {
     private Dictionary<string, List<(string neighbor, int weight)>> adj = new Dictionary<string, List<(string, int)>>();
            public void AddNode(string id)
        {
            if (!adj.ContainsKey(id)) adj[id] = new List<(string, int)>();
        }
      public void AddEdge(string a, string b, int weight = 1)
        {
            AddNode(a); AddNode(b);
           adj[a].Add((b, weight));
          adj[b].Add((a, weight));
        }
       public IEnumerable<string> Nodes => adj.Keys;

        public IEnumerable<string> BFS(string start)
        {
            var visited = new HashSet<string>();
            var k = new Queue<string>();
          var order = new List<string>();
            if (!adj.ContainsKey(start)) return order;
         k.Enqueue(start); visited.Add(start);
            while (k.Count > 0)
            {
                var v = k.Dequeue();
             order.Add(v);
                foreach (var n in adj[v])
                {
                if (!visited.Contains(n.neighbor)) { visited.Add(n.neighbor); k.Enqueue(n.neighbor); }
                }
            }
            return order;
        }





        public IEnumerable<string> DFS(string start)
        {
           var visited = new HashSet<string>();
            var order = new List<string>();
         var stack = new Stack<string>();
            if (!adj.ContainsKey(start)) return order;
         stack.Push(start);
            while (stack.Count > 0)
            {
                var v = stack.Pop();
            if (visited.Contains(v)) continue;
                visited.Add(v);
              order.Add(v);
                foreach (var n in adj[v]) if (!visited.Contains(n.neighbor)) stack.Push(n.neighbor);
            }
            return order;
        }




        // algorithm for MST
        public IEnumerable<(string a, string b, int w)> MinimumSpanningTree(string start)
        {
            var result = new List<(string, string, int)>();
            var inTree = new HashSet<string>();
            var candidateEdges = new List<(string from, string to, int w)>();
            if (!adj.ContainsKey(start)) return result;
            inTree.Add(start);
            foreach (var e in adj[start]) candidateEdges.Add((start, e.neighbor, e.weight));
            while (candidateEdges.Count > 0)
            {
                // pick smallest weight edge
                var minEdgeIndex = 0;
                for (int i = 1; i < candidateEdges.Count; i++)
                {
                    if (candidateEdges[i].w < candidateEdges[minEdgeIndex].w) minEdgeIndex = i;
                }
             var edge = candidateEdges[minEdgeIndex];
                candidateEdges.RemoveAt(minEdgeIndex);
            if (inTree.Contains(edge.to)) continue;
                inTree.Add(edge.to);
             result.Add((edge.from, edge.to, edge.w));
                foreach (var ne in adj[edge.to]) if (!inTree.Contains(ne.neighbor)) candidateEdges.Add((edge.to, ne.neighbor, ne.weight));
            }
            return result;
        }

      public IEnumerable<(string neighbor, int weight)> getNeighbors(string node)
        {
          if (!adj.ContainsKey(node)) return Enumerable.Empty<(string, int)>();
                 return adj[node];
        }

            public bool Contains(string id) => adj.ContainsKey(id);
    }
}

        