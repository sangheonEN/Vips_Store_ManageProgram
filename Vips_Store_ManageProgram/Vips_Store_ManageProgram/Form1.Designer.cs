﻿namespace Vips_Store_ManageProgram
{
    partial class Form1_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Table));
            this.Customer_Manage = new System.Windows.Forms.Button();
            this.Table1 = new System.Windows.Forms.Button();
            this.Adults_Plus = new System.Windows.Forms.Button();
            this.Kids_Plus = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Table2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Adult_Minus = new System.Windows.Forms.Button();
            this.Kids_Minus = new System.Windows.Forms.Button();
            this.Table3 = new System.Windows.Forms.Button();
            this.Table4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_Manage
            // 
            this.Customer_Manage.Location = new System.Drawing.Point(714, 506);
            this.Customer_Manage.Name = "Customer_Manage";
            this.Customer_Manage.Size = new System.Drawing.Size(111, 31);
            this.Customer_Manage.TabIndex = 0;
            this.Customer_Manage.Text = "회원 관리 창";
            this.Customer_Manage.UseVisualStyleBackColor = true;
            this.Customer_Manage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table1
            // 
            this.Table1.BackColor = System.Drawing.Color.White;
            this.Table1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table1.Location = new System.Drawing.Point(17, 95);
            this.Table1.Name = "Table1";
            this.Table1.Size = new System.Drawing.Size(145, 75);
            this.Table1.TabIndex = 1;
            this.Table1.Text = "Table1";
            this.Table1.UseVisualStyleBackColor = false;
            this.Table1.Click += new System.EventHandler(this.Table1_Click);
            // 
            // Adults_Plus
            // 
            this.Adults_Plus.Location = new System.Drawing.Point(652, 191);
            this.Adults_Plus.Name = "Adults_Plus";
            this.Adults_Plus.Size = new System.Drawing.Size(75, 23);
            this.Adults_Plus.TabIndex = 2;
            this.Adults_Plus.Text = "성인 +1";
            this.Adults_Plus.UseVisualStyleBackColor = true;
            this.Adults_Plus.Click += new System.EventHandler(this.Adults_Click);
            // 
            // Kids_Plus
            // 
            this.Kids_Plus.Location = new System.Drawing.Point(733, 191);
            this.Kids_Plus.Name = "Kids_Plus";
            this.Kids_Plus.Size = new System.Drawing.Size(75, 23);
            this.Kids_Plus.TabIndex = 3;
            this.Kids_Plus.Text = "아동 +1";
            this.Kids_Plus.UseVisualStyleBackColor = true;
            this.Kids_Plus.Click += new System.EventHandler(this.Kids_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(652, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 124);
            this.listBox1.TabIndex = 4;
            // 
            // Table2
            // 
            this.Table2.BackColor = System.Drawing.Color.White;
            this.Table2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Table2.Location = new System.Drawing.Point(169, 96);
            this.Table2.Name = "Table2";
            this.Table2.Size = new System.Drawing.Size(145, 75);
            this.Table2.TabIndex = 6;
            this.Table2.Text = "Table2";
            this.Table2.UseVisualStyleBackColor = false;
            this.Table2.Click += new System.EventHandler(this.Table2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(683, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "인원수 추가";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(596, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "원하는 테이블을 선택하세요.";
            // 
            // Adult_Minus
            // 
            this.Adult_Minus.Location = new System.Drawing.Point(652, 220);
            this.Adult_Minus.Name = "Adult_Minus";
            this.Adult_Minus.Size = new System.Drawing.Size(75, 23);
            this.Adult_Minus.TabIndex = 9;
            this.Adult_Minus.Text = "성인 -1";
            this.Adult_Minus.UseVisualStyleBackColor = true;
            this.Adult_Minus.Click += new System.EventHandler(this.Adult_Minus_Click);
            // 
            // Kids_Minus
            // 
            this.Kids_Minus.Location = new System.Drawing.Point(733, 220);
            this.Kids_Minus.Name = "Kids_Minus";
            this.Kids_Minus.Size = new System.Drawing.Size(75, 23);
            this.Kids_Minus.TabIndex = 10;
            this.Kids_Minus.Text = "아동 -1";
            this.Kids_Minus.UseVisualStyleBackColor = true;
            this.Kids_Minus.Click += new System.EventHandler(this.Kids_Minus_Click);
            // 
            // Table3
            // 
            this.Table3.BackColor = System.Drawing.Color.White;
            this.Table3.Location = new System.Drawing.Point(415, 252);
            this.Table3.Name = "Table3";
            this.Table3.Size = new System.Drawing.Size(198, 85);
            this.Table3.TabIndex = 11;
            this.Table3.Text = "Table3";
            this.Table3.UseVisualStyleBackColor = false;
            this.Table3.Click += new System.EventHandler(this.Table3_Click);
            // 
            // Table4
            // 
            this.Table4.BackColor = System.Drawing.Color.White;
            this.Table4.Location = new System.Drawing.Point(415, 363);
            this.Table4.Name = "Table4";
            this.Table4.Size = new System.Drawing.Size(198, 82);
            this.Table4.TabIndex = 12;
            this.Table4.Text = "Table4";
            this.Table4.UseVisualStyleBackColor = false;
            this.Table4.Click += new System.EventHandler(this.Table4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 549);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Table4);
            this.Controls.Add(this.Table3);
            this.Controls.Add(this.Kids_Minus);
            this.Controls.Add(this.Adult_Minus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Kids_Plus);
            this.Controls.Add(this.Adults_Plus);
            this.Controls.Add(this.Customer_Manage);
            this.Name = "Form1_Table";
            this.Text = "Table 현황";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customer_Manage;
        private System.Windows.Forms.Button Table1;
        private System.Windows.Forms.Button Adults_Plus;
        private System.Windows.Forms.Button Kids_Plus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Table2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Adult_Minus;
        private System.Windows.Forms.Button Kids_Minus;
        private System.Windows.Forms.Button Table3;
        private System.Windows.Forms.Button Table4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

