using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookLentalShop20
{
    public partial class UserForm : MetroForm
    {
        string strConnString = "Data Source=192.168.0.63;" +
                               "Initial Catalog = BookLentalShopDB; " +
                               "Persist Security Info=True;" +
                               "User ID = sa; Password=p@ssw0rd!";
        string mode = "";
        public UserForm()
        {
            InitializeComponent();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            UpdateData(); // 데이터그리드DB 데어터 로딩하기
        }
        /// <summary>
        /// 사용자데이터 가져오기
        /// </summary>
        private void UpdateData()
        {
            //throw new NotImplementedException();
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open(); // DB열기
                string strQuery = " SELECT id, userID, password, lastLoginDt, loginIpAddr " 
                                    + " FROM dbo.usertbl ";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn); //데이타 가져오는 플러그
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl"); //데이타 집합  //ds 통에다가 divtbl 이름으로 넣었다

                GrdUserTbl.DataSource = ds;
                GrdUserTbl.DataMember = "divtbl"; //그걸 다시 Grd 통에 넣는다
            }
            DataGridViewColumn column = GrdUserTbl.Columns[0]; // id컬럼
            column.Width = 40;
            column.HeaderText = "순번";
            column = GrdUserTbl.Columns[1];
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2];
            column.Width = 100;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3];
            column.Width = 150;
            column.HeaderText = "최종접속시간";
            column = GrdUserTbl.Columns[4];
            column.Width = 150;
            column.HeaderText = "접속 IP 주소";
        }
        /// <summary>
        /// 그리드 셀클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                // var data
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                txtID.Text = data.Cells[0].Value.ToString();
                txtUserID.Text = data.Cells[1].Value.ToString();
                txtPW.Text = data.Cells[2].Value.ToString();

                mode = "UPDATE";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtPW.Text))
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteProcess();
            UpdateData();
            ClearTextControls();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();

            mode = "INSERT";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(txtUserID.Text)) || (string.IsNullOrEmpty(txtPW.Text)))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveProcess();
            UpdateData();
            ClearTextControls();
        }
        private void ClearTextControls()
        {
            txtID.Text = txtUserID.Text = txtPW.Text = "";
            txtID.ReadOnly = false;
            txtID.BackColor = Color.Beige;
            txtUserID.Focus();
        }
        private void SaveProcess()
        {
            if(string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //DB저장프로세스
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";
                if (mode == "UPDATE")
                {
                    strQuery = " UPDATE dbo.userTbl "
                             + " SET userID = @userID, "
                             + " password = @password WHERE id = @id ";
                    
                }
                else if (mode == "INSERT")
                {
                    strQuery = " INSERT INTO dbo.userTbl ( userID, password ) "
                             + " VALUES(@userID, @password) ";
                }
                cmd.CommandText = strQuery;
                

                SqlParameter parmUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                parmUserID.Value = txtUserID.Text;
                cmd.Parameters.Add(parmUserID);

                SqlParameter parmPW = new SqlParameter("@password", SqlDbType.VarChar, 20);
                parmPW.Value = txtPW.Text;
                cmd.Parameters.Add(parmPW);

                if (mode == "INSERT")
                {
                    SqlParameter parmID = new SqlParameter("@ID", SqlDbType.Int);
                    parmID.Value = txtID.Text;
                    cmd.Parameters.Add(parmID);
                }

                cmd.ExecuteNonQuery();
            }
        }
        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = txtUserID.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }
        private void txtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

      
    }
}
