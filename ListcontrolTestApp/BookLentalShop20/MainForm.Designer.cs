﻿namespace BookLentalShop20
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.메인관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemDivMng = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemUserMng = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인관리MToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(20, 60);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(786, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 메인관리MToolStripMenuItem
            // 
            this.메인관리MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemDivMng,
            this.MnuItemUserMng});
            this.메인관리MToolStripMenuItem.Name = "메인관리MToolStripMenuItem";
            this.메인관리MToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.메인관리MToolStripMenuItem.Text = "메인관리(&M)";
            // 
            // MnuItemDivMng
            // 
            this.MnuItemDivMng.Name = "MnuItemDivMng";
            this.MnuItemDivMng.Size = new System.Drawing.Size(224, 26);
            this.MnuItemDivMng.Text = "구분코드관리(&D)";
            this.MnuItemDivMng.Click += new System.EventHandler(this.MnuItemDivMng_Click);
            // 
            // MnuItemUserMng
            // 
            this.MnuItemUserMng.Name = "MnuItemUserMng";
            this.MnuItemUserMng.Size = new System.Drawing.Size(224, 26);
            this.MnuItemUserMng.Text = "사용자관리(&U)";
            this.MnuItemUserMng.Click += new System.EventHandler(this.MnuItemUserMng_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(826, 534);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Book Rentalshop v1.0";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 메인관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuItemDivMng;
        private System.Windows.Forms.ToolStripMenuItem MnuItemUserMng;
    }
}

