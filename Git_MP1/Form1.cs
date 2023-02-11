using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

                                                        //Developed by Cao Tan Phi - 20146513
namespace XLA_MP1_v2
{
    public partial class MP1_v2 : Form
    {
        public MP1_v2()
        {
            InitializeComponent();

            //Tao bien cho file anh, bien chua hinh bitmap 
            string source_file = @"D:\Photos\LENA.jpg";
            Bitmap source_image = new Bitmap(source_file);

            //Hien thi hinh goc
            pictureBox1.Image = source_image;

            //Tao bien chua hinh bitmap cho 3 kenh mau
            Bitmap red = new Bitmap(source_image.Width, source_image.Height);
            Bitmap green = new Bitmap(source_image.Width, source_image.Height);
            Bitmap blue = new Bitmap(source_image.Width, source_image.Height);

            //Loop de doc het cac pixel
            for (int y = 0; y < source_image.Height; y++)
                for (int x = 0; x < source_image.Width; x++)
                {
                    //doc gia tri pixel 
                    Color pixel = source_image.GetPixel(x, y);

                    //lay thong tin cac gia tri
                    byte R = pixel.R; //gia tri kenh mau RED
                    byte G = pixel.G; //gia tri kenh mau GREEN
                    byte B = pixel.B; //gia tri kenh mau BLUE
                    byte A = pixel.A; //gia tri do trong suot

                    //set cac gia tri pixel cho hinh chua cac kenh mau R B G
                    red.SetPixel(x, y, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(x, y, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(x, y, Color.FromArgb(A, 0, 0, B));                    
                }
            //hien thi
            pictureBox2.Image = red;
            pictureBox3.Image = green; 
            pictureBox4.Image = blue;

            //Image<Bgr, byte> anhgoc = new Image<Bgr, byte>(@"D:\Photos\LENA.jpg");
            //imageBox1.Image = anhgoc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
