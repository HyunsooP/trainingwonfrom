namespace WinFormApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTcurrentDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMessage
            // 
            this.BtnMessage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnMessage.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMessage.Location = new System.Drawing.Point(653, 318);
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.Size = new System.Drawing.Size(177, 123);
            this.BtnMessage.TabIndex = 0;
            this.BtnMessage.Text = "현재 시간";
            this.BtnMessage.UseVisualStyleBackColor = false;
            this.BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 시간 :";
            // 
            // TXTcurrentDate
            // 
            this.TXTcurrentDate.Location = new System.Drawing.Point(218, 61);
            this.TXTcurrentDate.Name = "TXTcurrentDate";
            this.TXTcurrentDate.Size = new System.Drawing.Size(242, 25);
            this.TXTcurrentDate.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 453);
            this.Controls.Add(this.TXTcurrentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMessage);
            this.Name = "MainForm";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTcurrentDate;
    }
}

