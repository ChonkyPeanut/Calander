using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calander
{
    public partial class Menu : Form
    {
        public string usernameLogin;
        public string passwordLogin;

        public bool usernameLoginMatch;
        public bool passwordLoginMatch;

        public Menu()
        {
            InitializeComponent();

            usernameLogin = "/*error **************** error*/";
            passwordLogin = "/*errpr **************** error*/";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Username_login_TextChanged(object sender, EventArgs e)
        {
            usernameLogin = Username_login.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Password_login_TextChanged(object sender, EventArgs e)
        {
            passwordLogin = Password_login.Text;
            Password_login.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (usernameLogin == CreateAccount_Menu.username)
            {
                usernameLoginMatch = true;

                if (passwordLogin == CreateAccount_Menu.password)
                {
                    passwordLoginMatch = true;
                    Months frmImport = new Months();

                    frmImport.ShowDialog();
                }
                else
                {
                    passwordLoginMatch = false;
                    MessageBox.Show("Password does not match");
                }
            }
            else
            {
                usernameLoginMatch = false;
                MessageBox.Show("Username does not match");
            }
        }

        private void CreateAccount_Button_Click(object sender, EventArgs e)
        {
            CreateAccount_Menu frmImport = new CreateAccount_Menu();

            frmImport.ShowDialog();
        }
    }
}
