using System;
using System.Windows.Forms;

namespace Municipality
{
    public partial class LocalEventsForm : Form
    {
        public LocalEventsForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LbUpcomingEve.Text = "please enter a category and optionally a date to see events";
          this.BtSearchCat.Click += new System.EventHandler(this.BtSearchCat_Click);
                this.BtFilter.Click += new System.EventHandler(this.BtFilter_Click);
           this.BtRMM1.Click += new System.EventHandler(this.BtRMM1_Click_1);
        } 

        private void BtSearchCat_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(TbSearchCat.Text))
            {
             MessageBox.Show("please enter a category to search.");
                 return;
            }

                 string category = TbSearchCat.Text.Trim();
            LbUpcomingEve.Text = $"Category: {category}";
            TbSearchCat.Clear();
        }

        private void BtFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbFilter.Text))
            {
              MessageBox.Show("please enter a date to filter eg 2025-10-20 .");
                return;
            }

            string date = TbFilter.Text.Trim();
            string currentCategory = "";
            if (LbUpcomingEve.Text.Contains("Category:"))
            {
               
          var parts = LbUpcomingEve.Text.Replace("Category: ", "").Split(new[] { ", Date: " }, StringSplitOptions.None);
                currentCategory = parts.Length > 0 ? parts[0] : string.Empty;
            }

            LbUpcomingEve.Text = $"Category: {currentCategory}, Date: {date}";
            TbFilter.Clear();
        }

          private void BtRMM1_Click(object sender, EventArgs e)
        {
         this.Close();
        }

       private void BtRMM1_Click_1 (object sender, EventArgs e)
        {
            this.Close();
        }
            private void label2_Click(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
              private void label1_Click(object sender, EventArgs e)
        {
        }
       private void TbFilter_TextChanged(object sender, EventArgs e )
        {
        }
    }
}