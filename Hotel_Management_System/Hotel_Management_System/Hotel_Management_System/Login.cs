using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnReseption_Click(object sender, EventArgs e)
        {
            Form Reception = new Reception();
            Form Kitchen = new Kitchen();
            if (txtUsername.Text == "Reception" && txtPin.Text == "1234")
            {
                this.Hide(); 
                Reception.Show();
            }
            else if (txtUsername.Text == "Kitchen" && txtPin.Text == "1234")
            {
                this.Hide();
                Kitchen.Show();
            }
            else
            {
                MessageBox.Show("Username OR PIN Is Wrong"); 
            }
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainmenu = new mainForm();
            mainmenu.Show();
        }

        private void lblEditorder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();    
        }
    }
}
