using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 로그인 폼 연결 / 모달 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        /// <summary>
        /// 폼 클로징 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;   //false는 취소가 되지 않았다는 뜻
            }
            else
            {
                e.Cancel = true;    //true가 취소 됬다는 뜻
            }

        }
        /// <summary>
        /// Dock 스타일
        /// </summary>
        /// <param name="form"></param>
        /// <param name="strFormTitle"></param>
        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill; //화면을 꽉 채움
            form.MdiParent = this;  //
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// 사용자 표시 라벨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Activated(object sender, EventArgs e)
        {
            LblUserID.Text = Commons.LOGINUSERID;
        }
        /// <summary>
        /// 툴스트립 불러오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuItemDivMng_Click(object sender, EventArgs e)                 // 구분코드 관리
        {
            DivForm form = new DivForm();
            InitChildForm(form, "구분코드 관리");
        }
        private void 사용자관리UToolStripMenuItem_Click(object sender, EventArgs e)  // 사용자폼
        {
            UserForm form = new UserForm();
            InitChildForm(form, "사용자 관리");
        }
        private void 회원관리MToolStripMenuItem_Click(object sender, EventArgs e)    // 회원관리폼
        {
            MemberForm form = new MemberForm();
            InitChildForm(form, "회원 관리");
        }
        private void 책관리BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm form = new BooksForm();
            InitChildForm(form, "책 관리");
        }   // 책관리폼

        private void 대여관리RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalForm form = new RentalForm();
            InitChildForm(form, "대여 관리");
        }
    }
}
