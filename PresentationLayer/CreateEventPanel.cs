using DigitalPhotoDiary.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPhotoDiary.PresentationLayer
{
    public partial class CreateEventPanel : Form
    {
        public CreateEventPanel(int userId, string userName)
        {
            InitializeComponent();
            userIdLabel.Text = Convert.ToString(userId);
            userNameLabel.Text = userName;
        }

        private void CreateEventPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int importance = 0;
            if (eventNameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }

            else if (!highRadioButton.Checked && !lowRadioButton.Checked && !modRadioButton.Checked)
            {
                MessageBox.Show("Set Importance");
            }
            else
            {
                if (lowRadioButton.Checked) { importance = 1; } else if (modRadioButton.Checked) { importance = 2; } else { importance = 3; }

                EventsService eventService = new EventsService();
                string modDate = DateTime.Now.ToString("u");
                int result = eventService.AddNewEvent(eventNameTextBox.Text, dateTimePicker.Text, modDate, importance,Convert.ToInt32(userIdLabel.Text));
                if (result > 0)
                {
                    MessageBox.Show("Events Added!");
                    this.Hide();
                    HomePanel homePanel = new HomePanel(Convert.ToInt32(userIdLabel.Text), userNameLabel.Text);
                    homePanel.Show();
                }
                else { MessageBox.Show("Error!"); }
            }
        }
    

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePanel homePanel = new HomePanel(Convert.ToInt32(userIdLabel.Text), userNameLabel.Text);
            homePanel.Show();
        }
    }
}
