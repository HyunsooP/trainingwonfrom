using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MemberForm : MetroForm
    {
        //디비연결 string
        string mode = "";
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기

        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))   //using이 없으면 conn.Close() 해줘야함
            {
                conn.Open(); //DB 열기
                string strQuery = "SELECT Idx, Names, Levels, Addr, Mobile, Email " +
                                  "  FROM dbo.membertbl "; //sql select문 불러오기
                //SqlCommand cmd = new SqlCommand(strQuery, conn);  //sql문을 실행할때는 SqlCommand가 꼭 필요하다! update할때는 필요없음
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "membertbl");

                GrdMemberTbl.DataSource = ds;
                GrdMemberTbl.DataMember = "membertbl";
            }
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow data = GrdMemberTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString(); //MemberTbl의 ID
                TxtNames.Text = data.Cells[1].Value.ToString(); //MemberTbl의 Name
                TxtIdx.ReadOnly = true; //Division이 PK라서 변경하면 안 된다.
                TxtIdx.BackColor = Color.Red;
                CboLevels.SelectedIndex = CboLevels.FindString(data.Cells[2].Value.ToString()); //콤보박스의 인덱스 0번을 출력
                TxtAddr.Text = data.Cells[3].Value.ToString();  //MemberTbl의 Address
                TxtMobile.Text = data.Cells[4].Value.ToString();  //MemberTbl의 Mobile
                TxtEmail.Text = data.Cells[5].Value.ToString(); //MemberTbl의 Email


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
            if (string.IsNullOrEmpty(TxtAddr.Text) || (string.IsNullOrEmpty(TxtNames.Text))
                 || (string.IsNullOrEmpty(TxtMobile.Text)) || (string.IsNullOrEmpty(TxtEmail.Text)))
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
            TxtIdx.Text = TxtNames.Text = TxtMobile.Text = TxtAddr.Text = TxtEmail.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtIdx.ReadOnly = true; //txtIdx는 자동 증가
            TxtIdx.BackColor = Color.Beige;
            TxtNames.Focus();
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
                    strQuery = "UPDATE dbo.membertbl " +
                                 " SET Names = @Names, " +
                                     " Levels = @Levels, " +
                                     " Addr = @Addr, " +
                                     " Mobile = @Mobile, " +
                                     " Email = @Email " +
                               " WHERE Idx = @Idx ";                   
                }
                else if (mode == "INSERT")
                {
                    //throw new NotImplementedException(); // 아직 구현 안 됬을 때 에러 발생
                    strQuery = "INSERT INTO dbo.membertbl (Names, Levels, Addr, Mobile, Email) " +
                              " VALUES (@Names, @Levels, @Addr, @Mobile, @Email) ";
                }
                cmd.CommandText = strQuery;

                if(mode == "Update")
                { 
                    // TxtIdx 설정 
                    SqlParameter pramIdx = new SqlParameter("@Idx", System.Data.SqlDbType.Int);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                    pramIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pramIdx);
                }

                    // TxtNames 설정 
                    SqlParameter pramNames = new SqlParameter("@Names", System.Data.SqlDbType.NVarChar, 45);//Names 속성 글자타입을 NVarChar, 길이를 45로 지정했음
                    pramNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pramNames);

                    //CboLevels 설정
                    SqlParameter parmLevels = new SqlParameter("@Levels", System.Data.SqlDbType.Char, 1);//Levels 속성 글자타입을 Char, 길이를 1로 지정했음
                    parmLevels.Value = CboLevels.SelectedItem;
                    cmd.Parameters.Add(parmLevels);

                    // TxtAddr 설정 
                    SqlParameter pramAddr = new SqlParameter("@Addr", System.Data.SqlDbType.VarChar, 100);//Address 속성 글자타입을 VarChar, 길이를 100로 지정했음
                    pramAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(pramAddr);

                    // TxtMobile 설정 
                    SqlParameter pramMobile = new SqlParameter("@Mobile", System.Data.SqlDbType.VarChar, 13);//Mobile 속성 글자타입을 VarChar, 길이를 13로 지정했음
                    pramMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pramMobile);

                    // TxtEmail 설정 
                    SqlParameter pramEmail = new SqlParameter("@Email", System.Data.SqlDbType.VarChar, 50);//Email 속성 글자타입을 VarChar, 길이를 50로 지정했음
                    pramEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(pramEmail);



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
            if (string.IsNullOrEmpty(TxtIdx.Text) || (string.IsNullOrEmpty(TxtNames.Text)))
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
                parmDivision.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }


    }
}
