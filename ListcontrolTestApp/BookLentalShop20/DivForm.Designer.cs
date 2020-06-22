namespace BookLentalShop20
{
    partial class DivForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdDivTbl = new MetroFramework.Controls.MetroGrid();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.txtNames = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDivision = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDivTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdDivTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.txtNames);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDivision);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Size = new System.Drawing.Size(754, 364);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 2;
            // 
            // GrdDivTbl
            // 
            this.GrdDivTbl.AllowUserToAddRows = false;
            this.GrdDivTbl.AllowUserToDeleteRows = false;
            this.GrdDivTbl.AllowUserToResizeRows = false;
            this.GrdDivTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdDivTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdDivTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdDivTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDivTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdDivTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdDivTbl.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdDivTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDivTbl.EnableHeadersVisualStyles = false;
            this.GrdDivTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdDivTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdDivTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdDivTbl.Name = "GrdDivTbl";
            this.GrdDivTbl.ReadOnly = true;
            this.GrdDivTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDivTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdDivTbl.RowHeadersWidth = 51;
            this.GrdDivTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdDivTbl.RowTemplate.Height = 27;
            this.GrdDivTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDivTbl.Size = new System.Drawing.Size(361, 364);
            this.GrdDivTbl.TabIndex = 0;
            this.GrdDivTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(293, 126);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 22);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(207, 126);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 22);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(119, 126);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(70, 22);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(33, 126);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(70, 22);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtNames
            // 
            // 
            // 
            // 
            this.txtNames.CustomButton.Image = null;
            this.txtNames.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.txtNames.CustomButton.Name = "";
            this.txtNames.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNames.CustomButton.TabIndex = 1;
            this.txtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNames.CustomButton.UseSelectable = true;
            this.txtNames.CustomButton.Visible = false;
            this.txtNames.Lines = new string[0];
            this.txtNames.Location = new System.Drawing.Point(121, 67);
            this.txtNames.MaxLength = 32767;
            this.txtNames.Name = "txtNames";
            this.txtNames.PasswordChar = '\0';
            this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNames.SelectedText = "";
            this.txtNames.SelectionLength = 0;
            this.txtNames.SelectionStart = 0;
            this.txtNames.ShortcutsEnabled = true;
            this.txtNames.Size = new System.Drawing.Size(206, 20);
            this.txtNames.TabIndex = 1;
            this.txtNames.UseSelectable = true;
            this.txtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNames_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(3, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "이름";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDivision
            // 
            // 
            // 
            // 
            this.txtDivision.CustomButton.Image = null;
            this.txtDivision.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.txtDivision.CustomButton.Name = "";
            this.txtDivision.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtDivision.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDivision.CustomButton.TabIndex = 1;
            this.txtDivision.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDivision.CustomButton.UseSelectable = true;
            this.txtDivision.CustomButton.Visible = false;
            this.txtDivision.Lines = new string[0];
            this.txtDivision.Location = new System.Drawing.Point(121, 30);
            this.txtDivision.MaxLength = 32767;
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.PasswordChar = '\0';
            this.txtDivision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDivision.SelectedText = "";
            this.txtDivision.SelectionLength = 0;
            this.txtDivision.SelectionStart = 0;
            this.txtDivision.ShortcutsEnabled = true;
            this.txtDivision.Size = new System.Drawing.Size(206, 20);
            this.txtDivision.TabIndex = 0;
            this.txtDivision.UseSelectable = true;
            this.txtDivision.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDivision.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(3, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 23);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "구분코드";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DivForm";
            this.Text = "DivForm";
            this.Load += new System.EventHandler(this.DivForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDivTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdDivTbl;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox txtNames;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDivision;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}