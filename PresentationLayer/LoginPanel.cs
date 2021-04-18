﻿using DigitalPhotoDiary.BusinessLayer;
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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else {

                UserService userService = new UserService();
                User user = userService.GetUser(nameTextBox.Text, passwordTextBox.Text);
                if (user != null)
                {
                    HomePanel homePanel = new HomePanel(user.UserId, user.Username);
                    this.Hide();
                    homePanel.Show();
                }
                else { MessageBox.Show("Something Went Worng!"); }
            }
        }

 

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
