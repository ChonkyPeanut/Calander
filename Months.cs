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

        private ImageList imageListJan;
        private int currentImage = 0;
        protected Graphics myGraphics;
        private OpenFileDialog openFileDialog1;

        public Months()
        {
            InitializeComponent();
            imageListJan = new ImageList();

            imageListJan.ImageSize = new Size(200,200);
            imageListJan.TransparentColor = Color.White;

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
                imageListJan.Images.Add(Image.FromFile(imageToLoad));
                listBox1.BeginUpdate();
                listBox1.Items.Add(imageToLoad);
                listBox1.EndUpdate();
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            if(imageListJan.Images.Empty != true)
            {
                if(imageListJan.Images.Count-1 > currentImage)
                {
                    currentImage++;
                }
                else
                {
                    currentImage = 0;
                }
                panel1.Refresh();

                imageListJan.Draw(myGraphics, 10, 10, currentImage);

                pictureBox1.Image = imageListJan.Images[currentImage];
                listBox1.SelectedIndex = currentImage;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            imageListJan.Images.Clear();
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
