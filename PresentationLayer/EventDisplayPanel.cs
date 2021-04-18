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
    public partial class EventDisplayPanel : Form
    {
        public EventDisplayPanel( int eventId, string name, string date, string modDate, int userId, string userName)
        {
            InitializeComponent();
            userNameLabel.Text = userName;
            userIdLabel.Text = Convert.ToString(userId);
            eventIdLabel.Text = Convert.ToString(eventId);
            eventNameLabel.Text = name;
            modificationDateLabel.Text = modDate;
            dateLabel.Text = date;
        }


        private void homeBackButton_Click(object sender, EventArgs e)
        {
            HomePanel homePanel = new HomePanel(Convert.ToInt32(userIdLabel.Text), userNameLabel.Text);
            this.Hide();
            homePanel.Show();
        }

        private void EventDisplayPanel_Load(object sender, EventArgs e)
        {

        }

        private void EventDisplayPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void storyTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void storyGroypBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
