using System;
using System.Windows.Forms;

namespace ActivitySelectorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the list box with some activities
            listBoxActivities.Items.Add("Hiking");
            listBoxActivities.Items.Add("Reading");
            listBoxActivities.Items.Add("Swimming");
            listBoxActivities.Items.Add("Watching movies");
            listBoxActivities.Items.Add("Cooking");
            lblResult.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Clear the result label
            lblResult.Text = "";

            // Determine indoor or outdoor preference using radio buttons
            string preference = "";
            if (radioIndoor.Checked)
            {
                preference = "indoor";
            }
            else if (radioOutdoor.Checked)
            {
                preference = "outdoor";
            }

            // Display selected activities based on preference using list box
            lblResult.Text += "Selected " + preference + " activities:\n";

            foreach (string activity in listBoxActivities.SelectedItems)
            {
                lblResult.Text += "- " + activity + "\n";
            }

            // Include additional notes based on checkboxes
            if (chkIncludeNotes.Checked)
            {
                lblResult.Text += "\nNotes:\n";

                if (chkQuietPlace.Checked)
                {
                    lblResult.Text += "- Prefer a quiet place\n";
                }

                if (chkGroupActivity.Checked)
                {
                    lblResult.Text += "- Enjoy group activities\n";
                }
            }
        }
    }
}