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

namespace XLA_MP3_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Tao bien cho file anh, bien chua hinh bitmap
            string source_file = @"D:\Photos\bird_small.jpg";
            Bitmap source_img = new Bitmap(source_file);
            SourceImg.Image = source_img;

            //Hien thi hinh muc xam theo pp lightness:
            GrayScale1.Image = Chuyen_hinh_RGB_sang_GrayScale1(source_img);

            //Hien thi hinh muc xam theo pp Average:
            GrayScale2.Image = Chuyen_hinh_RGB_sang_GrayScale2(source_img);

            //Hien thi hinh muc xam theo pp Luminance:
            GrayScale3.Image = Chuyen_hinh_RGB_sang_GrayScale3(source_img);
        }

        //Tinh toan chuyen hinh mau RGB sang grayscale theo pp lightness
        public Bitmap Chuyen_hinh_RGB_sang_GrayScale1(Bitmap source_img)
        {   
            Bitmap Grayscale1_img = new Bitmap(source_img.Width, source_img.Height);
            for (int i = 0; i < source_img.Height; i++)
                for (int j = 0; j < source_img.Width; j++)  //loop doc gia tri pixel bat dau tu diem cao nhat ben trai, sang phai, xuong duoi.
                {
                    //lay diem anh
                    Color pixel = source_img.GetPixel(j,i);

                    //lay thong tin cac gia tri
                    byte R = pixel.R; //gia tri kenh mau red
                    byte G = pixel.G; //gia tri kenh mau green
                    byte B = pixel.B; //gia tri kenh mau blue
                    byte A = pixel.A; //gia tri do trong suot

                    //tinh gia tri muc xam cho diem anh (j,i)
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2); //gia tri (max+min)/2 la so thuc, phai su dung "(byte)" de ep kieu gia tri

                    //gan gia tri muc xam lightness vao bien hinh Grayscale
                    Grayscale1_img.SetPixel(j, i, Color.FromArgb(gray, gray, gray));

                }
            return Grayscale1_img;
        }

        //Tinh toan chuyen hinh mau RGB sang grayscale theo pp average
        public Bitmap Chuyen_hinh_RGB_sang_GrayScale2(Bitmap source_img)
        {
            Bitmap Grayscale2_img = new Bitmap(source_img.Width, source_img.Height);
            for (int i = 0; i < source_img.Height; i++)
                for (int j = 0; j < source_img.Width; j++)  //loop doc gia tri pixel bat dau tu diem cao nhat ben trai, sang phai, xuong duoi.
                {
                    //lay diem anh
                    Color pixel = source_img.GetPixel(j, i);

                    //lay thong tin cac gia tri
                    byte R = pixel.R; //gia tri kenh mau red
                    byte G = pixel.G; //gia tri kenh mau green
                    byte B = pixel.B; //gia tri kenh mau blue
                    byte A = pixel.A; //gia tri do trong suot

                    //tinh gia tri muc xam cho diem anh (j,i)
                    byte gray = (byte)((R + G + B) / 3); //gia tri (R+G+B)/2 la so thuc, phai su dung "(byte)" de ep kieu gia tri

                    //gan gia tri muc xam vao bien hinh Grayscale
                    Grayscale2_img.SetPixel(j, i, Color.FromArgb(gray, gray, gray));
                }
            return Grayscale2_img;
        }

        //Tinh toan chuyen hinh mau RGB sang grayscale theo pp luminance
        public Bitmap Chuyen_hinh_RGB_sang_GrayScale3(Bitmap source_img)
        {
            Bitmap Grayscale3_img = new Bitmap(source_img.Width, source_img.Height);
            for (int i = 0; i < source_img.Height; i++)
                for (int j = 0; j < source_img.Width; j++)  //loop doc gia tri pixel bat dau tu diem cao nhat ben trai, sang phai, xuong duoi.
                {
                    //lay diem anh
                    Color pixel = source_img.GetPixel(j, i);

                    //lay thong tin cac gia tri
                    byte R = pixel.R; //gia tri kenh mau red
                    byte G = pixel.G; //gia tri kenh mau green
                    byte B = pixel.B; //gia tri kenh mau blue
                    byte A = pixel.A; //gia tri do trong suot

                    //tinh gia tri muc xam cho diem anh (j,i)
                    byte gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B); //gia tri 0.2126*R+0.7152*G+0.0722*B la so thuc, phai su dung "(byte)" de ep kieu gia tri

                    //gan gia tri muc xam vao bien hinh Grayscale
                    Grayscale3_img.SetPixel(j, i, Color.FromArgb(gray, gray, gray));
                }
            return Grayscale3_img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
