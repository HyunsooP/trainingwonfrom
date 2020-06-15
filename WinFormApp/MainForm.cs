using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void BtnMessage_click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBox.Show($"HELL Wodrld!{now} " );
        }

        private void BtnMessage_Click_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            // MessageBox.Show($"HELL Wodrld!{now} ");
            TXTcurrentDate.Text = now.ToString();
        }
    }
}
