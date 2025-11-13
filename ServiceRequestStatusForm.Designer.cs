namespace Municipality
{
    partial class ServiceRequestStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchId = new System.Windows.Forms.TextBox();
            this.btnTrackById = new System.Windows.Forms.Button();
            this.tvStructure = new System.Windows.Forms.TreeView();
            this.LstHeap = new System.Windows.Forms.ListBox();
            this.btnShowHeap = new System.Windows.Forms.Button();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.btnRunHeap = new System.Windows.Forms.Button();
            this.btnRunDFS = new System.Windows.Forms.Button();
            this.btnShowMST = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Description,
            this.Status,
            this.Priority,
            this.CreatedAt});
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1442, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 8;
            this.Priority.Name = "Priority";
            this.Priority.Width = 150;
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.MinimumWidth = 8;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Width = 150;
            // 
            // tbSearchId
            // 
            this.tbSearchId.Location = new System.Drawing.Point(1460, 175);
            this.tbSearchId.Multiline = true;
            this.tbSearchId.Name = "tbSearchId";
            this.tbSearchId.Size = new System.Drawing.Size(201, 58);
            this.tbSearchId.TabIndex = 1;
            // 
            // btnTrackById
            // 
            this.btnTrackById.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTrackById.Location = new System.Drawing.Point(1680, 175);
            this.btnTrackById.Name = "btnTrackById";
            this.btnTrackById.Size = new System.Drawing.Size(93, 58);
            this.btnTrackById.TabIndex = 2;
            this.btnTrackById.Text = "Search";
            this.btnTrackById.UseVisualStyleBackColor = false;
            // 
            // tvStructure
            // 
            this.tvStructure.Location = new System.Drawing.Point(1413, 612);
            this.tvStructure.Name = "tvStructure";
            this.tvStructure.Size = new System.Drawing.Size(346, 225);
            this.tvStructure.TabIndex = 3;
            // 
            // LstHeap
            // 
            this.LstHeap.FormattingEnabled = true;
            this.LstHeap.ItemHeight = 20;
            this.LstHeap.Location = new System.Drawing.Point(12, 653);
            this.LstHeap.Name = "LstHeap";
            this.LstHeap.Size = new System.Drawing.Size(249, 224);
            this.LstHeap.TabIndex = 4;
            // 
            // btnShowHeap
            // 
            this.btnShowHeap.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShowHeap.Location = new System.Drawing.Point(267, 653);
            this.btnShowHeap.Name = "btnShowHeap";
            this.btnShowHeap.Size = new System.Drawing.Size(103, 50);
            this.btnShowHeap.TabIndex = 5;
            this.btnShowHeap.Text = "Show HEAP";
            this.btnShowHeap.UseVisualStyleBackColor = false;
            // 
            // pnlGraph
            // 
            this.pnlGraph.Location = new System.Drawing.Point(544, 595);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(463, 271);
            this.pnlGraph.TabIndex = 6;
            // 
            // btnRunHeap
            // 
            this.btnRunHeap.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRunHeap.Location = new System.Drawing.Point(1088, 595);
            this.btnRunHeap.Name = "btnRunHeap";
            this.btnRunHeap.Size = new System.Drawing.Size(87, 53);
            this.btnRunHeap.TabIndex = 7;
            this.btnRunHeap.Text = "Heap";
            this.btnRunHeap.UseVisualStyleBackColor = false;
            // 
            // btnRunDFS
            // 
            this.btnRunDFS.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRunDFS.Location = new System.Drawing.Point(1088, 653);
            this.btnRunDFS.Name = "btnRunDFS";
            this.btnRunDFS.Size = new System.Drawing.Size(87, 48);
            this.btnRunDFS.TabIndex = 8;
            this.btnRunDFS.Text = "DFS";
            this.btnRunDFS.UseVisualStyleBackColor = false;
            // 
            // btnShowMST
            // 
            this.btnShowMST.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShowMST.Location = new System.Drawing.Point(1088, 714);
            this.btnShowMST.Name = "btnShowMST";
            this.btnShowMST.Size = new System.Drawing.Size(87, 51);
            this.btnShowMST.TabIndex = 9;
            this.btnShowMST.Text = "MST";
            this.btnShowMST.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1812, 147);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Request Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Municipality.Properties.Resources.municipality;
            this.ClientSize = new System.Drawing.Size(1814, 898);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowMST);
            this.Controls.Add(this.btnRunDFS);
            this.Controls.Add(this.btnRunHeap);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.btnShowHeap);
            this.Controls.Add(this.LstHeap);
            this.Controls.Add(this.tvStructure);
            this.Controls.Add(this.btnTrackById);
            this.Controls.Add(this.tbSearchId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequestStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ServiceRequestStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.Button btnTrackById;
        private System.Windows.Forms.TreeView tvStructure;
        private System.Windows.Forms.ListBox LstHeap;
        private System.Windows.Forms.Button btnShowHeap;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Button btnRunHeap;
        private System.Windows.Forms.Button btnRunDFS;
        private System.Windows.Forms.Button btnShowMST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}