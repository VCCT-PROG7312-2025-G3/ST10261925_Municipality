namespace Municipality

{

    partial class MainForm

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BTReportIssue = new System.Windows.Forms.Button();
            this.BTlocalEA = new System.Windows.Forms.Button();
            this.BtSRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Municipality.Properties.Resources.Screenshot_2025_10_16_125039;
            this.pictureBox1.Location = new System.Drawing.Point(1144, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 143);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1010, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUNICIPALITY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 93);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BTReportIssue
            // 
            this.BTReportIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTReportIssue.BackColor = System.Drawing.Color.ForestGreen;
            this.BTReportIssue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTReportIssue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTReportIssue.Location = new System.Drawing.Point(76, 329);
            this.BTReportIssue.Margin = new System.Windows.Forms.Padding(4);
            this.BTReportIssue.Name = "BTReportIssue";
            this.BTReportIssue.Size = new System.Drawing.Size(261, 277);
            this.BTReportIssue.TabIndex = 3;
            this.BTReportIssue.Text = "Report Issue:\r\n\r\n\r\nHere to submit issue reports with location, category, and desc" +
    "ription details";
            this.BTReportIssue.UseVisualStyleBackColor = false;
            // 
            // BTlocalEA
            // 
            this.BTlocalEA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTlocalEA.BackColor = System.Drawing.Color.ForestGreen;
            this.BTlocalEA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTlocalEA.Location = new System.Drawing.Point(483, 329);
            this.BTlocalEA.Margin = new System.Windows.Forms.Padding(4);
            this.BTlocalEA.Name = "BTlocalEA";
            this.BTlocalEA.Size = new System.Drawing.Size(267, 277);
            this.BTlocalEA.TabIndex = 4;
            this.BTlocalEA.Text = "Local Events and Announcement:\r\n\r\n\r\nhere to search for and filter local events by" +
    " category or date.";
            this.BTlocalEA.UseVisualStyleBackColor = false;
            // 
            // BtSRS
            // 
            this.BtSRS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSRS.BackColor = System.Drawing.Color.ForestGreen;
            this.BtSRS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSRS.Location = new System.Drawing.Point(867, 329);
            this.BtSRS.Name = "BtSRS";
            this.BtSRS.Size = new System.Drawing.Size(274, 277);
            this.BtSRS.TabIndex = 5;
            this.BtSRS.Text = "Service Request Status:\r\n \r\n\r\nHere to see the status of the reported issues \r\n\r\n";
            this.BtSRS.UseVisualStyleBackColor = false;
            this.BtSRS.Click += new System.EventHandler(this.BtSRS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Municipality.Properties.Resources.municipality;
            this.ClientSize = new System.Drawing.Size(1344, 823);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BTReportIssue);
            this.Controls.Add(this.BTlocalEA);
            this.Controls.Add(this.BtSRS);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button BTReportIssue;

        private System.Windows.Forms.Button BTlocalEA;

        private System.Windows.Forms.Button BtSRS;

    }

}

