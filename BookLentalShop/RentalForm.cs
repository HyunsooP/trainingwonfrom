using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class RentalForm : MetroForm
    {
        /// <summary>
        /// DB연결 String
        /// </summary>
        string mode = "";
        public RentalForm()
        {
            InitializeComponent();
        }
        private void RentalForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기
            UpdateCboDivision();
            DateFormat();
        }
        /// <summary>
        /// DB데이터 로딩
        /// </summary>
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))   //using이 없으면 conn.Close() 해줘야함
            {
                conn.Open(); //DB 열기
                string strQuery = "SELECT r.Idx, r.memberIdx, r.bookIdx, r.rentalDate, r.returnDate " +
                                  " FROM dbo.rentaltbl as r " +
                                  " INNER JOIN dbo.membertbl as m " +
                                  " ON r.memberIdx = m.Idx " +
                                  " INNER JOIN dbo.bookstbl as b " +
                                  " ON r.bookIdx = b.Idx ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);  //sql문을 실행할때는 SqlCommand가 꼭 필요하다! update할때는 필요없음
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "rentaltbl");

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = "bookstbl";
            }

            DataGridViewColumn column = GrdBooksTbl.Columns[2];  // Division Column
            column.Visible = false;
        }
        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Division, Names FROM divtbl";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = -1;
            }
        }
        /// <summary>
        /// 버튼클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        private void BtnNew_Click(object sender, EventArgs e)        // New Button (추가)
        {
            ClearTextControls();
            mode = "INSERT"; // 신규는 INSERT
        }
        private void BtnSave_Click(object sender, EventArgs e)       // Save Button (저장)
        {
            if (string.IsNullOrEmpty(TxtNames.Text) || string.IsNullOrEmpty(TxtAuthor.Text) || string.IsNullOrEmpty(TxtPrice.Text)
                 || string.IsNullOrEmpty(TxtISBN.Text)) // 나머지 컨드롤도 검사해야함
            {
                MetroMessageBox.Show(this, "빈값을 지정할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            SaveProcess();
            UpdateData();
            ClearTextControls();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIdx.Text) || (string.IsNullOrEmpty(TxtAuthor.Text)))
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            DeleteProcess();
        }  // Delete Button (삭제)
        private void BtnCancle_Click(object sender, EventArgs e)
        {
            ClearTextControls();
        }
        /// <summary>
        /// 프로세스
        /// </summary>
        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오.", "경고",
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
                    strQuery = " UPDATE dbo.bookstbl " +
                               " SET   Author = @Author, " +
                               "       Division = @Division, " +
                               "       Names = @Names, " +
                               "       ReleaseDate = @ReleaseDate, " +
                               "       ISBN = @ISBN, " +
                               "       Price = @Price " +
                               " WHERE Idx = @Idx ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = " INSERT INTO dbo.bookstbl (Author,Division,Names,ReleaseDate,ISBN,Price) " +
                               " VALUES(@Author, @Division, @Names, @ReleaseDate, @ISBN, @Price) ";
                }
                cmd.CommandText = strQuery;

                // TxtAuthor 설정 
                SqlParameter paramAuthor = new SqlParameter("@Author", System.Data.SqlDbType.VarChar, 45);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                paramAuthor.Value = TxtAuthor.Text;
                cmd.Parameters.Add(paramAuthor);
                // CboDivision 설정 
                SqlParameter paramDivision = new SqlParameter("@Division", System.Data.SqlDbType.Char, 4);//Names 속성 글자타입을 NVarChar, 길이를 45로 지정했음
                paramDivision.Value = CboDivision.SelectedValue;
                cmd.Parameters.Add(paramDivision);
                // TxtNames 설정 
                SqlParameter paramNames = new SqlParameter("@Names", System.Data.SqlDbType.VarChar, 100);//Names 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                paramNames.Value = TxtNames.Text;
                cmd.Parameters.Add(paramNames);
                // DtpReleaseDate 설정 
                SqlParameter paramReleaseDate = new SqlParameter("@ReleaseDate", System.Data.SqlDbType.Date);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                paramReleaseDate.Value = DtpReleaseDate.Value;
                cmd.Parameters.Add(paramReleaseDate);
                // TxtISBN 설정 
                SqlParameter paramISBN = new SqlParameter("@ISBN", System.Data.SqlDbType.VarChar, 200);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                paramISBN.Value = TxtISBN.Text;
                cmd.Parameters.Add(paramISBN);
                // TxtPrice 설정 
                SqlParameter paramPrice = new SqlParameter("@Price", System.Data.SqlDbType.Decimal, 10);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                paramPrice.Value = TxtPrice.Text;
                cmd.Parameters.Add(paramPrice);
                // TxtIdx 설정 
                if (mode == "UPDATE")
                {
                    SqlParameter paramIdx = new SqlParameter("@Idx", System.Data.SqlDbType.Int);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                    paramIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(paramIdx);
                }


                cmd.ExecuteNonQuery();  //쿼리문을 실행 시켜주기 위해서, NonQuery를 사용하는것은 값을 돌려받지 않기 위해서
            }
        }   // 저장프로세스
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
        } // 삭제프로세스
        /// <summary>
        /// 텍스트박스 클리어 메소드
        /// </summary>
        private void ClearTextControls()
        {
            TxtIdx.Text = TxtAuthor.Text = TxtNames.Text = TxtISBN.Text = TxtPrice.Text =  "";
            CboDivision.SelectedIndex = -1;
            // 날짜값 클리어
            DtpReleaseDate.CustomFormat = " "; //스페이스 있어야함.
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;

            TxtIdx.ReadOnly = true; //txtIdx는 자동 증가
            TxtIdx.BackColor = Color.Beige;
            TxtAuthor.Focus();
        }
        /// <summary>
        /// 텍스트창 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //Cells[3]은 inner join으로 결과를 나타내준다.
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString(); // ID
                TxtIdx.ReadOnly = true; //Division이 PK라서 변경하면 안 된다.
                TxtIdx.BackColor = Color.Red;
                TxtAuthor.Text = data.Cells[1].Value.ToString(); // 저자
                // "로맨스', "SF/판타지"
                //CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString());
                // "B001", "B006"
                CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[2].Value.ToString()); // 책 장르
                TxtNames.Text = data.Cells[4].Value.ToString();  // 책 제목

                DateFormat();
                DtpReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());  //발간일
                TxtISBN.Text = data.Cells[6].Value.ToString(); // ISBN
                TxtPrice.Text = data.Cells[7].Value.ToString(); // 가격

                mode = "UPDATE"; // 수정은 UPDATE
            }
        }
        /// <summary>
        /// 대여일시 날짜형식 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            DateFormat();
        }
        /// <summary>
        /// 날짜형식 메소드
        /// </summary>
        private void DateFormat()
        {
            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }
        /// <summary>
        /// 키프레스 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }
    }
}
