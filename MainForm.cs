using System;
using System.Windows.Forms;

namespace Municipality
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
               this.WindowState = FormWindowState.Maximized;
           this.BTReportIssue.Click += BTReportIssue_Click;
             this.BTlocalEA.Click += BTlocalEA_Click; 
        }

        private void BTReportIssue_Click(object sender, EventArgs e)
        {
          var reportForm = new ReportIssuesForm();
            reportForm.Show();
        }

        private void BTlocalEA_Click(object sender, EventArgs e)
        {
                var eventsForm = new LocalEventsForm();
            eventsForm.Show(); 
        }
         private void BtSRS_Click(object sender, EventArgs e)
        {
       // MessageBox.("Service Request Status - Available in Part 3.");
        }
      private void label2_Click(object sender, EventArgs e)
        {
        }
         private void MainForm_Load(object sender, EventArgs e)
        {
        }
         private void pictureBox1_Click(object sender,EventArgs e)
        {
        }
       private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}