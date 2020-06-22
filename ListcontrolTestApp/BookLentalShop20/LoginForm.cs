using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace BookLentalShop20
{
    public partial class LoginForm : MetroForm
    {
        /// <summary>
        /// 서버연결 후 연결문자열 기입(DB연결 시 필수)
        /// </summary>
        string strConnString = "Data Source=192.168.0.63;Initial Catalog=BookLentalShopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 캔슬버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            // Application.Exit(); // 아래와 두개 모두 같음
            Environment.Exit(0);
        }
        /// <summary>
        /// 로그인 처리버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }
        /// <summary>
        /// ID 입력 박스 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                txtPassword.Focus();
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                LoginProcess();
            }
        }

        private void LoginProcess()
        {
            // throw new NotImplemenetedException();
            if (string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
                //((txtID.Text == null || txtID.Text == "") ||
                //(txtPassword.Text == null || txtPassword.Text == "")) ;
            {
                MetroMessageBox.Show(this, "아이디 / 패스워드를 입력하세요!", "오류",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strUserID = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnString)) //SQL injection 방지
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM userTbl" +
                                      " WHERE userID = @userID" +
                                      " AND password = @password";
                    SqlParameter parmUserId = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                    parmUserId.Value = txtID.Text;
                    cmd.Parameters.Add(parmUserId);
                    SqlParameter parmPassword = new SqlParameter("@Password", SqlDbType.VarChar, 20);
                    parmPassword.Value = txtPassword.Text;
                    cmd.Parameters.Add(parmPassword);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUserID = reader["userID"] != null ? reader["userID"].ToString() : "";

                    if (strUserID != "")
                    {
                        MetroMessageBox.Show(this, "접속성공", "로그인 성공");
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인 실패",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //MetroMessageBox.Show(this, "접속성공", "로그인");
                    //Debug.WriteLine("On the Debug");
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, $"Error : {ex.Message}", "오류",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
