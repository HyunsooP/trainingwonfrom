namespace BookLentalShop20
{
    partial class UserForm
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
            this.GrdUserTbl = new MetroFramework.Controls.MetroGrid();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.LblID = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.LblPW = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUserTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdUserTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtPW);
            this.splitContainer1.Panel2.Controls.Add(this.txtUserID);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.LblPW);
            this.splitContainer1.Panel2.Controls.Add(this.LblUserID);
            this.splitContainer1.Panel2.Controls.Add(this.LblID);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Size = new System.Drawing.Size(754, 364);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 2;
            // 
            // GrdUserTbl
            // 
            this.GrdUserTbl.AllowUserToAddRows = false;
            this.GrdUserTbl.AllowUserToDeleteRows = false;
            this.GrdUserTbl.AllowUserToResizeRows = false;
            this.GrdUserTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdUserTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdUserTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdUserTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdUserTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdUserTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdUserTbl.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdUserTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdUserTbl.EnableHeadersVisualStyles = false;
            this.GrdUserTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdUserTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdUserTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdUserTbl.Name = "GrdUserTbl";
            this.GrdUserTbl.ReadOnly = true;
            this.GrdUserTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdUserTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdUserTbl.RowHeadersWidth = 51;
            this.GrdUserTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdUserTbl.RowTemplate.Height = 27;
            this.GrdUserTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdUserTbl.Size = new System.Drawing.Size(361, 364);
            this.GrdUserTbl.TabIndex = 0;
            this.GrdUserTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDivTbl_CellClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(293, 126);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 22);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(207, 126);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 22);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(119, 126);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(70, 22);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(33, 126);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(70, 22);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(25, 25);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(37, 15);
            this.LblID.TabIndex = 6;
            this.LblID.Text = "순번";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Location = new System.Drawing.Point(25, 59);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(52, 15);
            this.LblUserID.TabIndex = 7;
            this.LblUserID.Text = "아이디";
            // 
            // LblPW
            // 
            this.LblPW.AutoSize = true;
            this.LblPW.Location = new System.Drawing.Point(25, 94);
            this.LblPW.Name = "LblPW";
            this.LblPW.Size = new System.Drawing.Size(67, 15);
            this.LblPW.TabIndex = 8;
            this.LblPW.Text = "패스워드";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(104, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(259, 25);
            this.txtID.TabIndex = 0;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(104, 56);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(259, 25);
            this.txtUserID.TabIndex = 1;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(104, 91);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(259, 25);
            this.txtPW.TabIndex = 2;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUserTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdUserTbl;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label LblPW;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Label LblID;
    }
}