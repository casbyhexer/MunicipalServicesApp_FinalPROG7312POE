using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Report Issues Button
        {
            
                ReportIssuesForm reportForm = new ReportIssuesForm();
                reportForm.Show();
                this.Hide();  // Hides the main form
            

            // Local Events & Service Request Status can be implemented similarly later

        }

        private void button2_Click(object sender, EventArgs e) // Events button
        {
            LocalEvents_AnnoucementsForm EventsForm = new LocalEvents_AnnoucementsForm();
            EventsForm.Show();
            this.Hide();  // Hides the main form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Confirms if the user really wants to close the app
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Municipal Services App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Closes the entire application
            }
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            ServiceRequestStatusForm EventsForm = new ServiceRequestStatusForm();
            EventsForm.Show();
            this.Hide();  // Hides the main form
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
