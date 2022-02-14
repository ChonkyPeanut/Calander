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
        public static string username;
        public static string password;

        public CreateAccount_Menu()
        {
            InitializeComponent();

            username = string.Empty;
            password = string.Empty;
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
            Username.Text = "Username: "+ textBox2.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
            Password.Text = "Password: " + textBox1.Text;
            textBox1.PasswordChar = '*';
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Create_Account_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: " + username + " " + "Password: " + password);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
