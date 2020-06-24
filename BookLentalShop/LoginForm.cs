using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 로그인 폼 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }  // OK버튼
        private void BtnCancle_Click(object sender, EventArgs e) // 취소버튼
        {
            //Application.Exit();
            Environment.Exit(0); // Environment에서 0은 트루, 1은 에러. C#에서 선호 함

        }
        /// <summary>
        /// 텍스트박스 키프레스 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                TxtPassword.Focus();
            }
         } // 아이디박스
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)  // 패스워드박스
        {
            if(e.KeyChar == (char)13) 
            {
                LoginProcess();
            }
        }
        /// <summary>
        /// 로그인 프로세스
        /// </summary>
        private void LoginProcess()
        {
            if ( string.IsNullOrEmpty(TxtUserID.Text)|| string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디 / 패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strUserId = string.Empty;

            try
            {
                //DB연결, SQL 인젝션 해킹을 방지하기 위해서 아래와 같이 복잡하게 사용
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();  //Sql 명령문을 입력 받는 타입
                    cmd.Connection = conn;
                    cmd.CommandText = "select userID from userTbl" +    //쿼리문을 넣을 때 마지막 또는 처음에 꼭! 스페이스 넣어줘야함!
                                        " Where userId = @userID" +   //'admin' 과 @userID가 동일
                                        " And Password = @password";   //'12345' 과 @password가 동일

                    //ID 설정
                    SqlParameter parmUserId = new SqlParameter("@userID", System.Data.SqlDbType.VarChar, 12);//id속성 글자수를 12로 지정했음
                    parmUserId.Value = TxtUserID.Text;
                    cmd.Parameters.Add(parmUserId);

                    //Password 설정
                    SqlParameter parmPassword = new SqlParameter("@password", System.Data.SqlDbType.VarChar, 20);//password속성 글자수를 20로 지정했음
                    parmPassword.Value = TxtPassword.Text;
                    cmd.Parameters.Add(parmPassword);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUserId = reader["userID"] != null ? reader["userID"].ToString() : ""; //"userID"는 sql문의 userID 필드값이다.

                    if (strUserId != "") //로그인 성공했을 때
                    {
                        Commons.LOGINUSERID = strUserId;
                        MetroMessageBox.Show(this, "접속성공", "로그인 성공");
                        this.Close();   //로그인폼을 닫아줌
                    }
                    else // 로그인 실패했을 때
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인 실패",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //Debug.WriteLine("On the Debug");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error : {ex.StackTrace}", "오류",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
