using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MnuItemDivMng_Click(object sender, EventArgs e)
        {
            DivForm Form = new DivForm();
            Form.Text = "구문코드관리";
            Form.Dock = DockStyle.Fill;
            Form.MdiParent = this;
            Form.Show();
            Form.WindowState = FormWindowState.Maximized;
        }
    }
}
