using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Municipality.Data;
using Municipality.DataStructures;
using Municipality.Models;

namespace Municipality
{
    public partial class ServiceRequestStatusForm:Form
    {
        // avl tree for the indexing for the ID
        private MinHeap heap = new MinHeap();
             private Graph graph = new Graph ();
         private AVLTree bst = new AVLTree();
        
      
        public ServiceRequestStatusForm()
        {
            InitializeComponent ();
            this.WindowState = FormWindowState.Maximized;

            // code for the wire buttons
                this.btnTrackById.Click += BtnTrackById_Click;
            this.btnShowHeap.Click += BtnShowHeap_Click;
                  this.btnRunHeap.Click += BtnRunHeap_Click;
            this.btnRunDFS.Click += BtnRunDFS_Click;
                this.btnShowMST.Click += BtnShowMST_Click;
            this.Load += ServiceRequestStatusForm_Load;
                 this.pnlGraph.Paint += PnlGraph_Paint;

        }

        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        
        {
            // load sample data from repository into data structures and grid
         foreach (var r in ServiceRequestRepository.GetAll())
            {
                bst.Insert(r); // AVL insert
             heap.Add(r);
                 graph.AddNode(r.Id);
            }
            foreach (var item in bst.InOrder())
            {
                Console.WriteLine(item.Id);
            }
         var ids = ServiceRequestRepository.GetAll().Select(x => x.Id).ToList();
            for (int i = 0; i < ids.Count - 1; i++)
          {
                    graph.AddEdge(ids[i], ids[i + 1], i + 1);
            }

             PopulateGrid();
                 PopulateTreeView();

        }

        private void PopulateGrid() 
        { 
            dataGridView1.Rows.Clear();
            foreach (var r in ServiceRequestRepository.GetAll())
            {
                dataGridView1.Rows.Add(r.Id, r.Description, r.Status, r.Priority, r.CreatedAt);
            }
        }
        private void PopulateTreeView()
        {
            tvStructure.Nodes.Clear();
         var nodes = bst.InOrder();
            TreeNode root = null;
              foreach (var r in nodes)
            {
             if (root == null) { root = new TreeNode(r.Id + " - " + r.Status); tvStructure.Nodes.Add(root); }
                else root.Nodes.Add(new TreeNode(r.Id + " - " + r.Status));
            }
        }


        private void BtnTrackById_Click(object sender, EventArgs e) 
        { 
            var id = tbSearchId.Text.Trim();
            if (string.IsNullOrEmpty(id)) { MessageBox.Show("please enter an ID to search."); return; }
     var found = ServiceRequestRepository.GetById(id);
            
      if (found == null) { MessageBox.Show("the equest wass not found."); return; }
           
       foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == id) { row.Selected = true; dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; break; }
            }
           MessageBox.Show($"Found: {found.Id} - {found.Description}");
        }

        private void BtnShowHeap_Click(object sender, EventArgs e) 
        {
         LstHeap.Items.Clear();
            foreach (var item in heap.AsSortedList()) LstHeap.Items.Add($"{item.Id} (P:{item.Priority})");
        }
        
        private void BtnRunHeap_Click(object sender, EventArgs e)
        {
            // this code is demo to show heap pop order
            var copy = new MinHeap();
       foreach (var r in ServiceRequestRepository.GetAll()) copy.Add(r);
            var sb = new System.Text.StringBuilder();
                 while (copy.Count > 0) { var it = copy.Pop(); sb.AppendLine($"{it.Id} - P:{it.Priority}"); }
          MessageBox.Show(sb.ToString(), "heap Order");
        }

        private void BtnRunDFS_Click(object sender, EventArgs e) 
        {
            // this code runs the DFS from first node
            var first = ServiceRequestRepository.GetAll().FirstOrDefault();
            if (first == null) return;
            var order = graph.DFS(first.Id);
            MessageBox.Show("DFS order: " + string.Join(", ", order));
        }
        
        private List <(string a, string b, int w)> lastMst = new List<(string, string, int)>();

        private void BtnShowMST_Click(Object sender, EventArgs e)
        {
            var first = ServiceRequestRepository.GetAll().FirstOrDefault();
        if (first == null) return;
            var mst = graph.MinimumSpanningTree(first.Id);
          lastMst = mst.ToList();
         MessageBox.Show("MST edges:\n" + string.Join("\n", lastMst.Select(m => $"{m.a} - {m.b} (w:{m.w})")));
             pnlGraph.Invalidate();
        }
       
        private void PnlGraph_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(pnlGraph.BackColor);
            // this code is ansimple layout: place nodes in a circle
            var nodes = graph.Nodes.ToList();
       int n = nodes.Count;
            if (n == 0) return;
          var center = new Point(pnlGraph.Width / 2, pnlGraph.Height / 2);
               int radius = Math.Min(pnlGraph.Width, pnlGraph.Height) / 2 - 20;
         var pos = new Dictionary<string, Point>();
            for (int i = 0; i < n; i++)
            {
                double angle = 2 * Math.PI * i / n;
          int x = center.X + (int)(radius * Math.Cos(angle));
                   int y = center.Y + (int)(radius * Math.Sin(angle));
                pos[nodes[i]] = new Point(x, y);
            }
            // code to draw edges
            using (var pen = new Pen(Color.Gray, 2))
            {
                foreach (var a in nodes)
                {
                    foreach (var nb in graph.getNeighbors(a))
                    {
                        var b = nb.neighbor;
               if (string.Compare(a, b) < 0) // draw each undirected edge once
                        {
                            g.DrawLine(pen, pos[a], pos[b]);
                        }
                    }
                }
            }
            // code for the highlight MST edges if present
            if (lastMst != null && lastMst.Count > 0)
            {
           using (var pen = new Pen(Color.Red, 3))
            {
                    foreach (var eItem in lastMst)
                  {
                        if (pos.ContainsKey(eItem.a) && pos.ContainsKey(eItem.b)) g.DrawLine(pen, pos[eItem.a], pos[eItem.b]);
                    }
                }
            }
            // code to draw nodes
            foreach (var kv in pos)
            {
                var p = kv.Value;
                g.FillEllipse(Brushes.LightBlue, p.X - 12, p.Y - 12, 24, 24);
         g.DrawEllipse(Pens.Black, p.X - 12, p.Y - 12, 24, 24);
      var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
    g.DrawString(kv.Key, this.Font, Brushes.Black, new RectangleF(p.X - 30, p.Y + 16, 60, 40), fmt);
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
