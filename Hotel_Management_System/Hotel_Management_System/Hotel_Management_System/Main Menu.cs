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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Close();

        private void btnreception_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Login = new Login();
            Login.Show(); 
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Login = new Login();
            Login.Show();
        }
    }
}
