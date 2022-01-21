using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calander
{
    public partial class January : Form
    {

        string _january = string.Empty;

        public January()
        {
            InitializeComponent();
        }

        private void January_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Open_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Title = "Select Calander Excel file";

            openDialog.Filter = "Excel 7.0 (*.xlsx)|*.xlsx" + "|" + "Excel (*.xls)|*.xls" + "|" + "CSV (*.csv)|*.csv" + "|" + "All Files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _january = openDialog.FileName;
            }
        }

        private void Import_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
