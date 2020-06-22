using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int index = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           // index %= imageList1.Images.Count;
           // label1.Image = imageList1.Images[index++];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            //Pen pen = new Pen(Color.DeepPink);
            //pen.Width = 6.8f;
            //pen.DashStyle  = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            //Point startPoint = new Point(45, 45);
            //Point endpoint = new Point(180, 150);
            //g.DrawLine(pen, startPoint, endpoint);
            //g.DrawLine(pen, 190, 60, 65, 170);

        }
    }
}
