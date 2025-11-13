namespace Municipality
{
    partial class ReportIssuesForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtMM2 = new System.Windows.Forms.Button();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.rTBDescricption = new System.Windows.Forms.RichTextBox();
            this.TBlocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtAttFile = new System.Windows.Forms.Button();
            this.BtSubmit = new System.Windows.Forms.Button();
            this.LbProgress = new System.Windows.Forms.Label();
            this.LbIssReport = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(1777, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1060, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "MUNICIPALITY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1777, 113);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Report Issue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.BtMM2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 730);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1777, 102);
            this.panel3.TabIndex = 1;
            // 
            // BtMM2
            // 
            this.BtMM2.BackColor = System.Drawing.Color.ForestGreen;
            this.BtMM2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMM2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMM2.Location = new System.Drawing.Point(779, 20);
            this.BtMM2.Name = "BtMM2";
            this.BtMM2.Size = new System.Drawing.Size(229, 70);
            this.BtMM2.TabIndex = 11;
            this.BtMM2.Text = "Back to Main Menu";
            this.BtMM2.UseVisualStyleBackColor = false;
            this.BtMM2.Click += new System.EventHandler(this.BtMM2_Click);
            // 
            // CBCategory
            // 
            this.CBCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.CBCategory.Location = new System.Drawing.Point(381, 375);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(763, 28);
            this.CBCategory.TabIndex = 2;
            this.CBCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // rTBDescricption
            // 
            this.rTBDescricption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBDescricption.Location = new System.Drawing.Point(381, 438);
            this.rTBDescricption.Name = "rTBDescricption";
            this.rTBDescricption.Size = new System.Drawing.Size(763, 107);
            this.rTBDescricption.TabIndex = 3;
            this.rTBDescricption.Text = "";
            // 
            // TBlocation
            // 
            this.TBlocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBlocation.Location = new System.Drawing.Point(381, 291);
            this.TBlocation.Multiline = true;
            this.TBlocation.Name = "TBlocation";
            this.TBlocation.Size = new System.Drawing.Size(763, 59);
            this.TBlocation.TabIndex = 5;
            this.TBlocation.TextChanged += new System.EventHandler(this.TBlocation_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 74);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // BtAttFile
            // 
            this.BtAttFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtAttFile.BackColor = System.Drawing.Color.ForestGreen;
            this.BtAttFile.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAttFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAttFile.Location = new System.Drawing.Point(142, 544);
            this.BtAttFile.Name = "BtAttFile";
            this.BtAttFile.Size = new System.Drawing.Size(158, 70);
            this.BtAttFile.TabIndex = 9;
            this.BtAttFile.Text = "Attach File";
            this.BtAttFile.UseVisualStyleBackColor = false;
            this.BtAttFile.Click += new System.EventHandler(this.BtAttFile_Click);
            // 
            // BtSubmit
            // 
            this.BtSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.BtSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSubmit.Location = new System.Drawing.Point(142, 620);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(158, 68);
            this.BtSubmit.TabIndex = 10;
            this.BtSubmit.Text = "Submit";
            this.BtSubmit.UseVisualStyleBackColor = false;
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // LbProgress
            // 
            this.LbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbProgress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbProgress.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbProgress.Location = new System.Drawing.Point(377, 568);
            this.LbProgress.Name = "LbProgress";
            this.LbProgress.Size = new System.Drawing.Size(367, 46);
            this.LbProgress.TabIndex = 11;
            this.LbProgress.Text = "Thank you for reporting! Progress 0%";
            this.LbProgress.Click += new System.EventHandler(this.LbProgress_Click);
            // 
            // LbIssReport
            // 
            this.LbIssReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbIssReport.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIssReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbIssReport.Location = new System.Drawing.Point(377, 636);
            this.LbIssReport.Name = "LbIssReport";
            this.LbIssReport.Size = new System.Drawing.Size(227, 52);
            this.LbIssReport.TabIndex = 12;
            this.LbIssReport.Text = "Issues Reported: 0";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Municipality.Properties.Resources.municipality;
            this.ClientSize = new System.Drawing.Size(1777, 832);
            this.Controls.Add(this.LbIssReport);
            this.Controls.Add(this.LbProgress);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.BtAttFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBlocation);
            this.Controls.Add(this.rTBDescricption);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportIssuesForm";
            this.Text = "ReportIssuesForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.RichTextBox rTBDescricption;
        private System.Windows.Forms.TextBox TBlocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtAttFile;
        private System.Windows.Forms.Button BtSubmit;
        private System.Windows.Forms.Button BtMM2;
        private System.Windows.Forms.Label LbProgress;
        private System.Windows.Forms.Label LbIssReport;
    }
}