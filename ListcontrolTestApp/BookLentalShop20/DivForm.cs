using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace BookLentalShop20
{
    public partial class DivForm : MetroForm
    {
        string strConnString = "Data Source=192.168.0.63;Initial Catalog=BookLentalShopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = "";
        public DivForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData(); // 데이터그리드DB 데어터 로딩하기
            //// TODO: 이 코드는 데이터를 'bookLentalShopDBDataSet1.divtbl' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.divtblTableAdapter.Fill(this.bookLentalShopDBDataSet1.divtbl);
        }

        private void UpdateData()
        {
            //throw new NotImplementedException();
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open(); // DB열기
                string strQuery = "SELECT Division, Names FROM divtbl";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn); //데이타 가져오는 플러그
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl"); //데이타 집합  //ds 통에다가 divtbl 이름으로 넣었다

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "divtbl"; //그걸 다시 Grd 통에 넣는다

            }
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                // var data
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                txtDivision.Text = data.Cells[0].Value.ToString();
                txtNames.Text = data.Cells[1].Value.ToString();
                txtDivision.ReadOnly = true; // PK 값은 수정하면 단된다. TXTDIVISION이 PK값이다.
                txtDivision.BackColor = Color.Blue;

                mode = "UPDATE";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDivision.Text) || string.IsNullOrEmpty(txtNames.Text))
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
            if(string.IsNullOrEmpty(txtDivision.Text) || string.IsNullOrEmpty(txtNames.Text))
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
            txtDivision.Text = txtNames.Text = "";
            txtDivision.ReadOnly = false;
            txtDivision.BackColor = Color.White;
            txtDivision.Focus();
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
                    strQuery = " UPDATE dbo.divtbl "
                             + " SET Names = @Names "
                             + " WHERE Division = @Division ";
                    
                }
                else if (mode == "INSERT")
                {
                    strQuery = " INSERT INTO dbo.divtbl (Division,Names) " 
                                + " VALUES(@Division, @Names) ";
                }
                cmd.CommandText = strQuery;

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                parmNames.Value = txtNames.Text;
                cmd.Parameters.Add(parmNames);
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = txtDivision.Text;
                cmd.Parameters.Add(parmDivision);

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
                parmDivision.Value = txtDivision.Text;
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
