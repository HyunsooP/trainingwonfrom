using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class DivForm : MetroForm
    {
        //디비연결 string
        string mode = "";
        public DivForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기

        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))   //using이 없으면 conn.Close() 해줘야함
            {
                conn.Open(); //DB 열기
                string strQuery = "SELECT Division, Names FROM divtbl"; //sql select문 불러오기
                //SqlCommand cmd = new SqlCommand(strQuery, conn);  //sql문을 실행할때는 SqlCommand가 꼭 필요하다!
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "divtbl";
            }
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                TxtDivision.ReadOnly = true; //Division이 PK라서 변경하면 안 된다.
                TxtDivision.BackColor = Color.Red;

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
            if (string.IsNullOrEmpty(TxtDivision.Text) || (string.IsNullOrEmpty(TxtNames.Text)))
            {
                MetroMessageBox.Show(this, "빈값을 지정할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            SaveProcess();
            UpdateData();

            ClearTextControls();
        }

        private void ClearTextControls()
        {
            TxtDivision.Text = TxtNames.Text = "";
            TxtDivision.ReadOnly = false;
            TxtDivision.BackColor = Color.White;
            TxtDivision.Focus();
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
                    strQuery = "UPDATE dbo.divtbl " +
                               " SET Names = @Names " +
                               " WHERE Division = @Division ";                   
                }
                else if (mode == "INSERT")
                {
                    //throw new NotImplementedException(); // 아직 구현 안 됬을 때 에러 발생
                    strQuery = "INSERT INTO dbo.divtbl (Division, Names) " +
                                " VALUES(@Division, @Names) ";
                }
                cmd.CommandText = strQuery;

                // TxtNames 설정 
                SqlParameter pramNames = new SqlParameter("@Names", System.Data.SqlDbType.NVarChar, 45);//Names 속성 글자타입을 NVarChar, 길이를 45로 지정했음
                pramNames.Value = TxtNames.Text;
                cmd.Parameters.Add(pramNames);

                //TxtDivision 설정
                SqlParameter parmDivision = new SqlParameter("@Division", System.Data.SqlDbType.Char, 4);//Division 속성글자타입을 Char, 길이를 4로 지정했음
                parmDivision.Value = TxtDivision.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();  //쿼리문을 실행 시켜주기 위해서, NonQuery를 사용하는것은 값을 돌려받지 않기 위해서
            }
        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) || (string.IsNullOrEmpty(TxtNames.Text)))
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            DeleteProcess();
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
                parmDivision.Value = TxtDivision.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }
    }
}
