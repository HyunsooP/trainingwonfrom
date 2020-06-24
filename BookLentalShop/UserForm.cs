using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class UserForm : MetroForm
    {
        //디비연결 string
        string mode = "";
        public UserForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기

        }
        /// <summary>
        /// 사용자 데이터 가져오기
        /// </summary>
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))   //using이 없으면 conn.Close() 해줘야함
            {
                conn.Open(); //DB 열기
                string strQuery = "SELECT id, userID, password, lastLoginDt, loginIpAddr " + //sql select문 불러오기
                                  " FROM dbo.userTbl ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);  //sql문을 실행할때는 SqlCommand가 꼭 필요하다!
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "userTbl");

                GrdUserTbl.DataSource = ds;
                GrdUserTbl.DataMember = "userTbl";
            }

            DataGridViewColumn column = GrdUserTbl.Columns[0];  // id Column
            column.Width = 40;
            column.HeaderText = "순번";
            column = GrdUserTbl.Columns[1]; // userID Column
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2]; // password Column
            column.Width = 100;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3]; // Last Login Time
            column.Width = 120;
            column.HeaderText = "최종접속시간";
            column = GrdUserTbl.Columns[4]; // Login IP Address
            column.Width = 150;
            column.HeaderText = "접속아이피주소";
        }

        /// <summary>
        /// 그리드 셀 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                TxtID.Text = data.Cells[0].Value.ToString();
                TxtUserID.Text = data.Cells[1].Value.ToString();
                TxtPassword.Text = data.Cells[2].Value.ToString();

                mode = "UPDATE"; // 수정은 UPDATE
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)   //New Button (추가)
        {
            ClearTextControls();
            mode = "INSERT"; // 신규는 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)  //Save Button (저장)
        {
            if (string.IsNullOrEmpty(TxtUserID.Text) || (string.IsNullOrEmpty(TxtPassword.Text)))
            {
                MetroMessageBox.Show(this, "빈값을 지정할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }

            SaveProcess();
            UpdateData();   // 앞에서 이미 수정

            ClearTextControls();
        }

        private void ClearTextControls()
        {
            TxtID.Text = TxtUserID.Text = TxtPassword.Text = "";
            //TxtUserID.ReadOnly = false;
            //TxtUserID.BackColor = Color.White;
            TxtUserID.Focus();
        }

        private void SaveProcess()
        {
            if(String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오.","경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //DB저장프로세스
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.userTbl " +
                               "   SET userID = @UserID, " +
                               "       password = @Password " +
                               " WHERE ID = @ID ";                   
                }

                else if (mode == "INSERT")
                {
                    //throw new NotImplementedException(); // 아직 구현 안 됬을 때 에러 발생
                    strQuery = "INSERT INTO dbo.userTbl ( userID, password ) " +
                               " VALUES(@UserID, @Password) ";
                }
                cmd.CommandText = strQuery;

                if (mode == "UPDATE")
                { 
                // Number 설정
                SqlParameter parmID = new SqlParameter("@ID", System.Data.SqlDbType.Int);// ID 속성글자타입을 Int로 지정
                parmID.Value = TxtID.Text;
                cmd.Parameters.Add(parmID);
                }

                // UserID 설정 
                SqlParameter pramUserID = new SqlParameter("@UserID", System.Data.SqlDbType.VarChar, 12);//UserID 속성 글자타입을 VarChar, 길이를 12로 지정했음
                pramUserID.Value = TxtUserID.Text;
                cmd.Parameters.Add(pramUserID);

                //TxtPassword 설정
                SqlParameter parmPassword = new SqlParameter("@Password", System.Data.SqlDbType.VarChar, 20);//TxtPassword 속성글자타입을 VarChar, 길이를 20로 지정했음
                parmPassword.Value = TxtPassword.Text;
                cmd.Parameters.Add(parmPassword);

                cmd.ExecuteNonQuery();  //쿼리문을 실행 시켜주기 위해서, NonQuery를 사용하는것은 값을 돌려받지 않기 위해서
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = label2.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }
    }
}
