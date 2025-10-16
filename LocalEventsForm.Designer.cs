namespace Municipality
{
    partial class LocalEventsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LbUpcomingEve = new System.Windows.Forms.Label();
            this.Lbsearch = new System.Windows.Forms.Label();
            this.TbSearchCat = new System.Windows.Forms.TextBox();
            this.LbFilter = new System.Windows.Forms.Label();
            this.TbFilter = new System.Windows.Forms.TextBox();
            this.BtSearchCat = new System.Windows.Forms.Button();
            this.BtFilter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtRMM1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1609, 126);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUNICIPALITY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1609, 93);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local Events and Announcments";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LbUpcomingEve
            // 
            this.LbUpcomingEve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbUpcomingEve.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUpcomingEve.Location = new System.Drawing.Point(196, 239);
            this.LbUpcomingEve.Name = "LbUpcomingEve";
            this.LbUpcomingEve.Size = new System.Drawing.Size(828, 179);
            this.LbUpcomingEve.TabIndex = 2;
            this.LbUpcomingEve.Text = "The Up Coming Events:";
            // 
            // Lbsearch
            // 
            this.Lbsearch.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Lbsearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbsearch.Location = new System.Drawing.Point(42, 451);
            this.Lbsearch.Name = "Lbsearch";
            this.Lbsearch.Size = new System.Drawing.Size(182, 91);
            this.Lbsearch.TabIndex = 3;
            this.Lbsearch.Text = "Search by Catagory:";
            this.Lbsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbSearchCat
            // 
            this.TbSearchCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearchCat.Location = new System.Drawing.Point(277, 451);
            this.TbSearchCat.Multiline = true;
            this.TbSearchCat.Name = "TbSearchCat";
            this.TbSearchCat.Size = new System.Drawing.Size(473, 91);
            this.TbSearchCat.TabIndex = 4;
            // 
            // LbFilter
            // 
            this.LbFilter.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.LbFilter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFilter.Location = new System.Drawing.Point(40, 589);
            this.LbFilter.Name = "LbFilter";
            this.LbFilter.Size = new System.Drawing.Size(184, 103);
            this.LbFilter.TabIndex = 5;
            this.LbFilter.Text = "Fillter (e.g. 2025-10-29)";
            this.LbFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbFilter
            // 
            this.TbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFilter.Location = new System.Drawing.Point(277, 589);
            this.TbFilter.Multiline = true;
            this.TbFilter.Name = "TbFilter";
            this.TbFilter.Size = new System.Drawing.Size(473, 103);
            this.TbFilter.TabIndex = 6;
            this.TbFilter.TextChanged += new System.EventHandler(this.TbFilter_TextChanged);
            // 
            // BtSearchCat
            // 
            this.BtSearchCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSearchCat.BackColor = System.Drawing.Color.ForestGreen;
            this.BtSearchCat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearchCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSearchCat.Location = new System.Drawing.Point(777, 451);
            this.BtSearchCat.Name = "BtSearchCat";
            this.BtSearchCat.Size = new System.Drawing.Size(162, 91);
            this.BtSearchCat.TabIndex = 7;
            this.BtSearchCat.Text = "Search";
            this.BtSearchCat.UseVisualStyleBackColor = false;
            this.BtSearchCat.Click += new System.EventHandler(this.BtSearchCat_Click);
            // 
            // BtFilter
            // 
            this.BtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtFilter.BackColor = System.Drawing.Color.ForestGreen;
            this.BtFilter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtFilter.Location = new System.Drawing.Point(777, 589);
            this.BtFilter.Name = "BtFilter";
            this.BtFilter.Size = new System.Drawing.Size(162, 103);
            this.BtFilter.TabIndex = 8;
            this.BtFilter.Text = "Filter";
            this.BtFilter.UseVisualStyleBackColor = false;
            this.BtFilter.Click += new System.EventHandler(this.BtFilter_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.BtRMM1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 731);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1609, 93);
            this.panel3.TabIndex = 9;
            // 
            // BtRMM1
            // 
            this.BtRMM1.BackColor = System.Drawing.Color.ForestGreen;
            this.BtRMM1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRMM1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtRMM1.Location = new System.Drawing.Point(730, 18);
            this.BtRMM1.Name = "BtRMM1";
            this.BtRMM1.Size = new System.Drawing.Size(231, 72);
            this.BtRMM1.TabIndex = 10;
            this.BtRMM1.Text = "Return to Main Menu";
            this.BtRMM1.UseVisualStyleBackColor = false;
            this.BtRMM1.Click += new System.EventHandler(this.BtRMM1_Click_1);
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Municipality.Properties.Resources.municipality;
            this.ClientSize = new System.Drawing.Size(1609, 824);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtFilter);
            this.Controls.Add(this.BtSearchCat);
            this.Controls.Add(this.TbFilter);
            this.Controls.Add(this.LbFilter);
            this.Controls.Add(this.TbSearchCat);
            this.Controls.Add(this.Lbsearch);
            this.Controls.Add(this.LbUpcomingEve);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LocalEventsForm";
            this.Text = "LocalEventsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbUpcomingEve;
        private System.Windows.Forms.Label Lbsearch;
        private System.Windows.Forms.TextBox TbSearchCat;
        private System.Windows.Forms.Label LbFilter;
        private System.Windows.Forms.TextBox TbFilter;
        private System.Windows.Forms.Button BtSearchCat;
        private System.Windows.Forms.Button BtFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtRMM1;
    }
}