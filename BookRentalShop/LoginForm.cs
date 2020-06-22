using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
namespace BookRentalShop
{
    public partial class LoginForm : MetroForm
    {
        string strConnString = "Data Source=127.0.0.1;Initial Catalog=BookRentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cancle 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void BtnCancle_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0); // Environment에서 0은 트루, 1은 에러. C#에서 선호 함

        }
        /// <summary>
        /// 로그인 처리 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                textBox1.Focus();
            }
        }
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoginProcess();
            }
        }
        private void LoginProcess()
        {
            //throw new NotImplementedException();
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MetroMessageBox.Show(this, "아이디 / 패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string struserid = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select userID from userTbl" +
                                      " where userID = @userID" +
                                      " AND PASSWORD = @password";
                    SqlParameter parmUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                    parmUserID.Value = textBox1.Text;
                    cmd.Parameters.Add(parmUserID);
                    SqlParameter parmPassWord = new SqlParameter("@password", SqlDbType.VarChar, 20);
                    parmPassWord.Value = textBox2.Text;
                    cmd.Parameters.Add(parmPassWord);

                    SqlDataReader reder = cmd.ExecuteReader();
                    reder.Read();
                    struserid = reder["userID"] != null ? reder["userID"].ToString() : "";

                    if (struserid != "")
                    {
                        MetroMessageBox.Show(this, "접속성공", "로그인성공");
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MetroMessageBox.Show(this, " 접속성공", "로그인");
                    Debug.WriteLine("on the debug");
                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, $"Error : {ex.message}", "오류", MessageBoxButtons.OK, me);
            }
           
        }
    }
}