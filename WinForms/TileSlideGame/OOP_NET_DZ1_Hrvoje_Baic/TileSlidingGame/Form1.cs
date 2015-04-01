﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileSlidingGame
{
    public partial class gameForm : Form
    {
        // Starting image and size, panels for different sizes
        Image currentImage;
        Panel[] x3Box;
        Panel[] x4Box;
        int size;

        public gameForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Initialize starting values
            size = 3;
            currentImage = gameResources.crazy_dog_pics_part2_52;
            x3Box = new Panel[9];
            x4Box = new Panel[16];

            // Initialize new game
            DrawNewImage(size);
        }

        // Click on "3x3" will set the new game
        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 3;
            // Clear the previous game
            gamePanel.Controls.Clear();

            // Draw and slice picture
            DrawNewImage(size);
        }

        // Click on "4x4" will set the new game
        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 4;
            // Clear the previous game
            gamePanel.Controls.Clear();

            // Draw and slice picture
            DrawNewImage(size);

        }

        // Setting a dog image from the menu
        private void dogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = gameResources.crazy_dog_pics_part2_52;

            gamePanel.Controls.Clear();

            DrawNewImage(size);
        }

        // Setting a mountain image from the menu
        private void mountainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = gameResources.mountain_04;

            gamePanel.Controls.Clear();

            DrawNewImage(size);
        }

        // Setting a BSOD image from the menu
        private void bSODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImage = gameResources.Windows_9X_BSOD;

            gamePanel.Controls.Clear();

            DrawNewImage(size);
        }

        // Divide and conquer
        private void DrawNewImage(int size)
        {
            Image resizedImage = resizeImage(currentImage, new Size(gamePanel.Width, gamePanel.Height));

            if (size == 3)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int index = i * size + j;

                        // We will be inserting panels with cropped images on a parent panel
                        Panel p = new Panel();
                        p.Width = gamePanel.Width / size;
                        p.Height = gamePanel.Height / size;
                        p.Margin = new Padding(0);
                        p.Click += p_Click;
                        p.Name = index.ToString();

                        x3Box[index] = p;

                        // Setting a background image
                        x3Box[index].BackgroundImage = new Bitmap(gamePanel.Width / size, gamePanel.Height / size);
                        Graphics g = Graphics.FromImage(x3Box[index].BackgroundImage);

                        // Cropping
                        g.DrawImage(resizedImage, new Rectangle(0, 0, gamePanel.Width / size, gamePanel.Height / size), new Rectangle(i * gamePanel.Width / size, j * gamePanel.Height / size, gamePanel.Width / size, gamePanel.Height / size), GraphicsUnit.Pixel);
                        g.Dispose();
                    }
                }

                for (int i = 0; i < 9; i++)
                {
                    gamePanel.Controls.Add(x3Box[i]);
                }

                x3Box[0].BackgroundImage = null;
                x3Box[0].Name = "Empty";
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int index = i * size + j;

                        // We will be inserting panels with cropped images on a parent panel
                        Panel p = new Panel();
                        p.Width = gamePanel.Width / size;
                        p.Height = gamePanel.Height / size;
                        p.Margin = new Padding(0);
                        p.Click += p_Click;

                        x4Box[index] = p;

                        // Setting a background image
                        x4Box[index].BackgroundImage = new Bitmap(gamePanel.Width / size, gamePanel.Height / size);
                        Graphics g = Graphics.FromImage(x4Box[index].BackgroundImage);

                        // Cropping
                        g.DrawImage(resizedImage, new Rectangle(0, 0, gamePanel.Width / size, gamePanel.Height / size), new Rectangle(i * gamePanel.Width / size, j * gamePanel.Height / size, gamePanel.Width / size, gamePanel.Height / size), GraphicsUnit.Pixel);

                        g.Dispose();
                    }
                }

                for (int i = 0; i < 16; i++)
                {
                    gamePanel.Controls.Add(x4Box[i]);
                }

                x4Box[0].BackgroundImage = null;
                x4Box[0].Name = "Empty";
            }
        }

        // Clicked panel will check if there are any free spaces to move
        void p_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            int iOfBlankFile = 0;
            int jOfBlankFile = 0;
            int iOfClickedPanel = 0;
            int jOfClickedPanel = 0;
            Panel temp = new Panel();

            if (size == 3)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int index = i * size + j;

                        if (x3Box[index].Name == "Empty")
                        {
                            iOfBlankFile = i;
                            jOfBlankFile = j;
                        }

                        if (x3Box[index].Name == clickedPanel.Name)
                        {
                            iOfClickedPanel = i;
                            jOfClickedPanel = j;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int index = i * size + j;

                        if (x3Box[index].Name == "Empty")
                        {
                            iOfBlankFile = i;
                            jOfBlankFile = j;
                        }

                        if (x3Box[index].Name == clickedPanel.Name)
                        {
                            iOfClickedPanel = i;
                            jOfClickedPanel = j;
                        }
                    }
                }
            }

            // Check to see where is the clicked panel
            // First check to see if it is in one of the corners

            // If in left upper corner
            if (iOfClickedPanel == 0 && jOfClickedPanel == 0)
            {
                if (iOfBlankFile == iOfClickedPanel + 1 && jOfBlankFile == jOfClickedPanel)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
                else if (iOfBlankFile == iOfClickedPanel && jOfBlankFile == jOfClickedPanel + 1){
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
            }
            // If in right upper corner
            else if (iOfClickedPanel == 0 && jOfClickedPanel == size - 1)
            {
                if (iOfBlankFile == iOfClickedPanel && jOfBlankFile == jOfClickedPanel - 1)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
                else if (iOfBlankFile == iOfClickedPanel + 1 && jOfBlankFile == jOfClickedPanel)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
            }
            // If in left lower corner
            else if (iOfClickedPanel == size - 1 && jOfClickedPanel == 0)
            {
                if (iOfBlankFile == iOfClickedPanel - 1 && jOfBlankFile == jOfClickedPanel)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
                else if (iOfBlankFile == iOfClickedPanel && jOfBlankFile == jOfClickedPanel + 1)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
            }
            // If in right lower corner
            else if (iOfClickedPanel == size - 1 && jOfClickedPanel == size - 1)
            {
                if (iOfBlankFile == iOfClickedPanel - 1 && jOfBlankFile == jOfClickedPanel)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
                else if (iOfBlankFile == iOfClickedPanel && jOfBlankFile == jOfClickedPanel - 1)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
            }
            // If on upper border
            else if (iOfClickedPanel == 0 && jOfClickedPanel > 0 && jOfClickedPanel < size){
                if (iOfBlankFile == iOfClickedPanel && jOfBlankFile == jOfClickedPanel - 1)
                {
                    temp = x3Box[iOfClickedPanel];
                    x3Box[iOfClickedPanel] = x3Box[iOfBlankFile];
                    x3Box[iOfBlankFile] = temp;
                }
            }
            // If on left border
            else if ((iOfClickedPanel > 0 && iOfClickedPanel < size - 1) && jOfClickedPanel == 0){

            }
            // If on bottom border
            else if (iOfClickedPanel == size - 1 && (jOfClickedPanel > 0 && jOfClickedPanel < size - 1))
            {

            }
            else if ((iOfClickedPanel > 0 && iOfClickedPanel < size - 1) && jOfClickedPanel == size - 1)
            {

            }
            // Else it must be in the middle somewhere so we
            // have to check if there is free space on all four sides
            else
            {

            }
        }

        private Image resizeImage(Image currentImage, Size size)
        {
            return (Image)(new Bitmap(currentImage, size));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple tile sliding game.\n\nClick on the pictures to move them around and reconstruct the original image.\nThere are '3x3' and '4x4' options available.\n\nGood luck!");
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author:\t Hrvoje Baic \n\nGitHub:\t https://github.com/baic989 \nBlog:\t http://imnotswift.com");
        }
    }
}
