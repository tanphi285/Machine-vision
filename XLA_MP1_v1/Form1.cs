using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace XLA_MP1_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Image<Bgr, byte> anhgoc = new Image<Bgr, byte>(@"D:\Photos\LENA.jpg");
            anh_goc.Image = anhgoc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}