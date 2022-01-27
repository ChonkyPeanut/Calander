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
            float username;
            username = float.Parse(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float password;
            password = float.Parse(textBox1.Text);
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Create_Account_Submit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void account(string username, string password)
        {

        }

        private void username(float username)
        {
            return;
        }
        
        private void password(float password)
        {
            return;
        }
    }
}
