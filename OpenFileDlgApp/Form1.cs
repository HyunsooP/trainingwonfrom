using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDlgApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = " ";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "모든파일(*.*)|*.*";
            
            openFileDialog1.ShowDialog();
            foreach (var item in openFileDialog1.FileNames)
            {
                textBox1.Text += item;
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog.show
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
