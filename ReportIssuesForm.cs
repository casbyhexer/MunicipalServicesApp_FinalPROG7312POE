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
    public partial class ReportIssuesForm : Form
    {
        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Back Button
        {
            MainMenu mainForm = new MainMenu();
            mainForm.Show();
            this.Hide();
        }

        private List<Issue> issueList = new List<Issue>(); // Data structure to store reported issues

        private void button2_Click(object sender, EventArgs e) // Submit Button
        {
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string description = rtxtDescription.Text;

            if (string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Stores the issue
            Issue newIssue = new Issue(location, category, description);
            issueList.Add(newIssue);

            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Engagement feature - shows progress or message
            lblProgress.Text = $"You’ve reported {issueList.Count} issues. Thank you for your participation!";

            // This clears fields after submission
            txtLocation.Clear();
            rtxtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Medaia Attachment Button
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    MessageBox.Show($"File attached: {filePath}");
                }
            

        }

        private void lblProgress_Click(object sender, EventArgs e)
        {
            lblProgress.Text = $"You’ve reported {issueList.Count} issues. Keep up the good work!";

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
