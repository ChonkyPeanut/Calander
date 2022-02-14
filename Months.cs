using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calander
{
    public partial class Months : Form
    {

        private ImageList imageListMonth;
        private int currentImage = 0;
        protected Graphics myGraphics;
        private OpenFileDialog openFileDialog1;

        public Months()
        {
            InitializeComponent();
            imageListMonth = new ImageList();

            imageListMonth.ImageSize = new Size(200,200);
            imageListMonth.TransparentColor = Color.White;

            myGraphics = Graphics.FromHwnd(panel1.Handle);
        }

        private void January_Load(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog1.FileNames != null)
                {
                    for(int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    {
                        addImage(openFileDialog1.FileNames[i]);
                    }
                }
                else
                {
                    addImage(openFileDialog1.FileName);
                }
            }
        }

        private void addImage(string imageToLoad)
        {
            if(imageToLoad != "")
            {
                imageListMonth.Images.Add(Image.FromFile(imageToLoad));
                listBox1.BeginUpdate();
                listBox1.Items.Add(imageToLoad);
                listBox1.EndUpdate();
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            if(imageListMonth.Images.Empty != true)
            {
                if(imageListMonth.Images.Count-1 > currentImage)
                {
                    currentImage++;
                }
                else
                {
                    currentImage = 0;
                }

                panel1.Refresh();

                imageListMonth.Draw(myGraphics, 10, 10, currentImage);

                pictureBox1.Image = imageListMonth.Images[currentImage];
                listBox1.SelectedIndex = currentImage;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            imageListMonth.Images.Clear();
            listBox1.Items.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
