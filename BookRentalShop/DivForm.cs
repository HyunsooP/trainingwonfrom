using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop
{
    public partial class DivForm : MetroForm
    {
        string strConnString = "Data Source=127.0.0.1;Initial Catalog=BookRentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = " ";
        public DivForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            updatedata(); // 데이터그리드 DB 데이터 로딩하기
          

        }

        private void updatedata()
        {
          //  throw new NotImplementedException();
          using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open(); // DB열기
                string strQuery = "SELECT Division, Names FROM divtbl";
               // SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "divtbl";
            }
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                TxtDivision.ReadOnly = true;
                TxtDivision.BackColor = Color.Beige;

                mode  = "UPDATE";
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtDivision.Text = TxtNames.Text = "";
            TxtDivision.ReadOnly = false;
            TxtDivision.BackColor = Color.White;

            mode = "INSERT";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.divtbl" + "SET Names = @Names" + "WHERE Division = @Division";
                    cmd.CommandText = strQuery;
                }
                else if (mode =="INSERT")
                {
                    SqlCommand cmd = new SqlCommand(strQuery, conn);
                }
                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.VarChar, 45);
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);
                SqlParameter parmDivision = new SqlParameter("@password", SqlDbType.VarChar, 4);
                parmDivision.Value = TxtDivision.Text;
                cmd.Parameters.Add(parmDivision);
                cmd.ExecuteNonQuery();
             
            }
        }
    }
}
