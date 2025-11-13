using System;
using System.Windows.Forms;
using System.IO;

namespace Municipality
{
    // form that user use to report municipal issues
    public partial class ReportIssuesForm : Form
    {
        // tracks how many issues have been reported
        private int issueCount = 0;
        private string attachedFilePath = "";

        // constructor
        public ReportIssuesForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LbProgress.Text = "Progress is: 0%";
            LbIssReport.Text = "Issues Reported are : 0";
        }

       // to attach a file 
        private void BtAttFile_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpj;*.jpeg;*.png)|*.jpg;*.jpeg;*.png| all files (*.*)|*.*";
          if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachedFilePath = openFileDialog.FileName;
                MessageBox.Show("file has attached: " + Path.GetFileName(attachedFilePath));
            }
            UpdateProgress();
        }

        // to submit report
        private void BtSubmit_Click(object sender, EventArgs e)
        {
         if (string.IsNullOrWhiteSpace(TBlocation.Text) || CBCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace(rTBDescricption.Text) || string.IsNullOrEmpty(attachedFilePath))
            {
             MessageBox.Show("Please fill all fields and attach a file before submitting.");
                return;
            }

            string location = TBlocation.Text;
          string category = CBCategory.SelectedItem.ToString();
                string description = rTBDescricption.Text;
            string attachment = Path.GetFileName(attachedFilePath);

            MessageBox.Show($"Submission Successful!\nLocation: {location}\nCategory: {category}\nDescription: {description}\nAttachment: {attachment}");

            issueCount++;
           LbIssReport.Text = $"issues reported: {issueCount}";
                 TBlocation.Clear();
           CBCategory.SelectedIndex = -1;
             rTBDescricption.Clear();
            attachedFilePath = "";
            UpdateProgress();
        }

       // close form to go to main menuu
        private void BtMM2_Click(object sender, EventArgs e)
        {
         this.Close();
        }
            private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
       UpdateProgress();
        }

        // to calculate and update progress level
        private void UpdateProgress()
        {
            int progress = 0;
          if (!string.IsNullOrWhiteSpace(TBlocation.Text)) progress += 25;
            if (CBCategory.SelectedIndex != -1) progress += 25;
                 if (!string.IsNullOrWhiteSpace(rTBDescricption.Text)) progress += 25;
            if (!string.IsNullOrEmpty(attachedFilePath)) progress += 25;
            LbProgress.Text = $"Progress: {progress}%";
        }

        // event handlers
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void TBlocation_TextChanged (object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void LbProgress_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}