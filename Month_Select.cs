using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calander
{
    public partial class Month_Select : Form
    {
        public Month_Select()
        {
            InitializeComponent();
        }

        private void January_Click(object sender, EventArgs e)
        {
            January frmImport = new January();

            frmImport.ShowDialog();
        }

        private void Febuary_Click(object sender, EventArgs e)
        {

        }

        private void March_Click(object sender, EventArgs e)
        {

        }

        private void April_Click(object sender, EventArgs e)
        {

        }

        private void May_Click(object sender, EventArgs e)
        {

        }

        private void June_Click(object sender, EventArgs e)
        {

        }

        private void Month_Select_Load(object sender, EventArgs e)
        {

        }
    }
}
