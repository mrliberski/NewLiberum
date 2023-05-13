using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFormaUI
{
    public partial class LogonScreenForm : Form
    {
        public LogonScreenForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void logOnButton_Click(object sender, EventArgs e)
        {
            // TODO - Implement authentication logic here
            string username = userNameTextbox.Text;
            string password = passwordTextBox.Text;

            // Check if username and password are correct
            if (username == "myusername" && password == "mypassword")
            {
                // Authentication successful
                MessageBox.Show("Login successful!");
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password.");
            }
        }

        //private bool CheckUserRole(string username, string role)
        //{
        //    // TODO - Query database to check if user has role
        //    // Return true if user has role, false otherwise
        //}
    }
}
