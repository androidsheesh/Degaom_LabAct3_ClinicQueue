using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Degaom_LabAct3
{
    public partial class Form1 : Form
    {
        // Queue for patients
        Queue<string> patientQueue = new Queue<string>();

        // Queue number
        int queueNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_Click(object sender, EventArgs e)
        {

        }

        private void txtage_Click(object sender, EventArgs e)
        {

        }

        private void txtreasonforvisit_Click(object sender, EventArgs e)
        {

        }

        private void txttype_Click(object sender, EventArgs e)
        {

        }

        // ADD TO QUEUE
        private void addtoqueue_Click(object sender, EventArgs e)
        {
            // Check if fields are empty
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtage.Text) ||
                string.IsNullOrWhiteSpace(txtreasonforvisit.Text) ||
                string.IsNullOrWhiteSpace(txttype.Text))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Incomplete Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Get patient type
            string patientType = txttype.Text.Trim();

            // Determine priority based on patient type
            string priority;

            switch (patientType.ToLower())
            {
                case "emergency":
                    priority = "EMERGENCY";
                    break;

                case "senior":
                    priority = "SENIOR PRIORITY";
                    break;

                case "pregnant":
                    priority = "PRIORITY";
                    break;

                case "regular":
                    priority = "REGULAR";
                    break;

                default:
                    MessageBox.Show(
                        "Invalid patient type.\n\n" +
                        "Please select: Regular, Senior, Pregnant, or Emergency.",
                        "Invalid Patient Type",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
            }

            // Create queue number
            string queueNumberText = "Q" + queueNumber.ToString("000");

            // Create patient information
            string patient =
                queueNumberText + " | " +
                txtname.Text + " | " +
                txtage.Text + " | " +
                txtreasonforvisit.Text + " | " +
                patientType + " | " +
                priority;

            // Add patient to queue
            patientQueue.Enqueue(patient);

            // Increase queue number AFTER adding patient
            queueNumber++;

            MessageBox.Show(
                "Successfully added to queue!\n\n" +
                "Queue Number: " + queueNumberText + "\n" +
                "Priority: " + priority,
                "Queue System",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Clear textboxes
            txtname.Clear();
            txtage.Clear();
            txtreasonforvisit.Clear();
            txttype.Clear();

            txtname.Focus();
        }


        // CLEAR BUTTON
        private void clear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtreasonforvisit.Clear();
            txttype.Clear();

            txtname.Focus();
        }
    }
}