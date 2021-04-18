using DigitalPhotoDiary.BusinessLayer;
using DigitalPhotoDiary.DataAccessLayer.Entity;
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
    public partial class HomePanel : Form
    {
        public HomePanel(int userId, string userName)
        {
            InitializeComponent();
            welcomeLabel.Text = userName;
            userIdLabel.Text = Convert.ToString(userId);
        }

        private void goToButton_Click(object sender, EventArgs e)
        {
            if (eventIdTextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Event Id!");
            }
            else if (eventNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Event Name!");
            }
            else
            {
                EventsService eventsService = new EventsService();
                UserEvent userEvent = eventsService.GetUserEvent(eventNameTextBox.Text, Convert.ToInt32(eventIdTextBox.Text));
                if (userEvent != null) {

                    EventDisplayPanel eventDisplayPanel = new EventDisplayPanel(userEvent.EventId, userEvent.EventName, userEvent.EventDate, userEvent.ModificationDate, userEvent.UserId, welcomeLabel.Text);
                    this.Hide();
                    eventDisplayPanel.Show();
                }
                else { MessageBox.Show("Something Went Worng!"); }
            }
        }


        private void createEventButton_Click(object sender, EventArgs e)
        {
            CreateEventPanel createEventPanel = new CreateEventPanel(Convert.ToInt32(userIdLabel.Text), welcomeLabel.Text);
            this.Hide();
            createEventPanel.Show();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        void UpdateListOfEvents() {
            EventsService eventsService = new EventsService();
            eventsDataGridView.DataSource = eventsService.GetEvents(Convert.ToInt32(userIdLabel.Text));
        }
        private void HomePanel_Load(object sender, EventArgs e)
        {
            EventsService eventsService = new EventsService();
            eventsDataGridView.DataSource = eventsService.GetEvents(Convert.ToInt32(userIdLabel.Text));

        }

        private void eventsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eventIdTextBox.Text = eventsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            eventNameTextBox.Text = eventsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void HomePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Selected Evnet Will be Deleted!", "Delete Event", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                EventsService eventsService = new EventsService();
                int result = eventsService.DeleteEvent(Convert.ToInt32(eventIdTextBox.Text));
                if (result > 0)
                {
                    MessageBox.Show("Event Deleted!");
                    UpdateListOfEvents();
                }
                else { MessageBox.Show("Registration Error!"); }

            }
            else { 
                
            }
        }
    }
}
