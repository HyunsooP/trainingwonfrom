using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 파일andToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.Location);
            }
        }

        private void LBlmouseLocatoin_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            파일andToolStripMenuItem_Click(sender, e);
        }
    }
}
