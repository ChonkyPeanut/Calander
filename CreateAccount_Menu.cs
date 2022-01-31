using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Calander
{
    public partial class CreateAccount_Menu : Form
    {
        public string username;
        public string password;
        public CreateAccount_Menu()
        {
            InitializeComponent();
        }

        private void CreateAccount_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            username = textBox2.Text;
            label4.Text = textBox2.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
            label3.Text = textBox1.Text;
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Create_Account_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: " + username + " " + "Password: " + password);
        }

        public void GetAccount()
        {
            password = textBox1.Text;
            username = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
