using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace CMYK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Size GetSize(Size origSize, Size needSize)
        {
            Size returnSize = new Size();
            if (origSize.Width > origSize.Height)
            {
                returnSize.Width = needSize.Width;
                returnSize.Height = origSize.Height * needSize.Width / origSize.Width;
            }
            else
                if (origSize.Width < origSize.Height)
                {
                    returnSize.Height = needSize.Height;
                    returnSize.Width = origSize.Width * needSize.Height / origSize.Height;
                }
                else
                {
                    returnSize = needSize;
                }
            return returnSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Bitmap bm = new Bitmap(myStream, false);
                            pictureBox1.Image = new Bitmap(bm, GetSize(new Size { Height = bm.Height, Width = bm.Width }, new Size { Width = 450, Height = 450 }));
                            Bitmap btY = new Bitmap(bm);
                            Bitmap btC = new Bitmap(bm);
                            Bitmap btM = new Bitmap(bm);
                            for (int i = 0; i < bm.Height; i++)
                            {
                                for (int j = 0; j < bm.Width; j++)
                                {
                                    var color = bm.GetPixel(j, i);
                                    float c;
                                    float m;
                                    float y;
                                    y = 1 - color.B / 255.0F;
                                    c = 1 - color.R / 255.0F;
                                    m = 1 - color.G / 255.0F;
                                    Color co = Color.FromArgb(255, 255, (int)(255 * (1 - y)));
                                    btY.SetPixel(j, i, co);
                                    co = Color.FromArgb((int)(255 * (1 - c)), 255, 255);
                                    btC.SetPixel(j, i, co);
                                    co = Color.FromArgb((255), (int)(255 * (1 - m)), 255);
                                    btM.SetPixel(j, i, co);
                                }
                            }
                            Bitmap cr = btC;
                            pictureBox2.Image = new Bitmap(cr, GetSize(new Size { Height = cr.Height, Width = cr.Width }, new Size { Width = 200, Height = 200 }));
                            pictureBox3.Image = new Bitmap(btM, GetSize(new Size { Height = btM.Height, Width = btM.Width }, new Size { Width = 200, Height = 200 }));
                            pictureBox4.Image = new Bitmap(btY, GetSize(new Size { Height = btY.Height, Width = btY.Width }, new Size { Width = 200, Height = 200 })); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            //openFileDialog1.ShowDialog();


            /* End of code segment. */
            //Bitmap bt = new System.Drawing.Bitmap("c:\\fakePhoto.jpg");
            //pictureBox1.Image = bt;

            //Bitmap btY = new Bitmap(bt);
            //Bitmap btC = new Bitmap(bt);
            //Bitmap btM = new Bitmap(bt);
            //for (int i = 0; i < bt.Height; i++)
            //{
            //    for (int j = 0; j < bt.Width; j++)
            //    {
            //        var color = bt.GetPixel(j, i);
            //        float c;
            //        float m;
            //        float y;
            //        y = 1 - color.B / 255.0F;
            //        c = 1 - color.R / 255.0F;
            //        m = 1 - color.G / 255.0F;
            //        Color co = Color.FromArgb(255, 255, (int)(255 * (1 - y)));
            //        btY.SetPixel(j, i, co);
            //        co = Color.FromArgb((int)(255 * (1 - c)), 255, 255);
            //        btC.SetPixel(j, i, co);
            //        co = Color.FromArgb((255), (int)(255 * (1 - m)), 255);
            //        btM.SetPixel(j, i, co);
            //    }
            //}
            //Bitmap cr = new Bitmap(btC, new Size { Height = 205, Width = 217 });
            //pictureBox2.Image = cr;
            //pictureBox3.Image = btM;
            //pictureBox4.Image = btY;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //                //Create a bitmap from a file.
            //    Bitmap bmp1 = new Bitmap("c:\\fakePhoto.jpg");

            //    // Create a new bitmap from the original, resizing it for this example.
            //    Bitmap bmp2 = new Bitmap(bmp1, new Size(80, 80));

            //    bmp1.Dispose();
            //    //pictureBox1.dr
            //    // Create an ImageAttributes object.
            //    ImageAttributes imgAttributes = new ImageAttributes();
            //    //bmp1.SetPixel()
            //    // Draw the image unaltered.
            //    e.Graphics.DrawImage(bmp2, 10, 10);

            //    // Draw the image, showing the intensity of the cyan channel.
            //    imgAttributes.SetOutputChannel(ColorChannelFlag.ColorChannelC,
            //        System.Drawing.Imaging.ColorAdjustType.Bitmap);

            //    e.Graphics.DrawImage(bmp2, new Rectangle(100, 10, bmp2.Width, bmp2.Height),
            //        0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imgAttributes);

            //    // Draw the image, showing the intensity of the magenta channel.
            //    imgAttributes.SetOutputChannel(ColorChannelFlag.ColorChannelM,
            //        ColorAdjustType.Bitmap);

            //    //ColorPalette cp=new ColorPalette();
            //    //cp.Entries[0]=new Color{}

            //    e.Graphics.DrawImage(bmp2, new Rectangle(10, 100, bmp2.Width, bmp2.Height),
            //        0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imgAttributes);

            //    // Draw the image, showing the intensity of the yellow channel.
            //    imgAttributes.SetOutputChannel(ColorChannelFlag.ColorChannelY,
            //        ColorAdjustType.Bitmap);
            //    //float test=1.2F;

            //    imgAttributes.SetGamma(2.2F, ColorAdjustType.Bitmap);
            //    imgAttributes.SetColorMatrices()

            //    e.Graphics.DrawImage(bmp2, new Rectangle(100, 100, bmp2.Width, bmp2.Height), 0, 0,
            //        bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imgAttributes);

            //    // Draw the image, showing the intensity of the black channel.
            //    imgAttributes.SetOutputChannel(ColorChannelFlag.ColorChannelK,

            //        System.Drawing.Imaging.ColorAdjustType.Bitmap);
            //    e.Graphics.DrawImage(bmp2, new Rectangle(10, 190, bmp2.Width, bmp2.Height),
            //        0, 0, bmp2.Width, bmp2.Height, GraphicsUnit.Pixel, imgAttributes);

            //    //Dispose of the bitmap.
            //    bmp2.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
