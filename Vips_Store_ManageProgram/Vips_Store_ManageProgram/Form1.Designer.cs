namespace Vips_Store_ManageProgram
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
            this.button1 = new System.Windows.Forms.Button();
            this.Table1 = new System.Windows.Forms.Button();
            this.Adults = new System.Windows.Forms.Button();
            this.Kids = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "회원 관리 창";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table1
            // 
            this.Table1.Location = new System.Drawing.Point(54, 77);
            this.Table1.Name = "Table1";
            this.Table1.Size = new System.Drawing.Size(198, 93);
            this.Table1.TabIndex = 1;
            this.Table1.Text = "Table1";
            this.Table1.UseVisualStyleBackColor = true;
            this.Table1.Click += new System.EventHandler(this.Table1_Click);
            // 
            // Adults
            // 
            this.Adults.Location = new System.Drawing.Point(312, 33);
            this.Adults.Name = "Adults";
            this.Adults.Size = new System.Drawing.Size(75, 23);
            this.Adults.TabIndex = 2;
            this.Adults.Text = "성인";
            this.Adults.UseVisualStyleBackColor = true;
            this.Adults.Click += new System.EventHandler(this.Adults_Click);
            // 
            // Kids
            // 
            this.Kids.Location = new System.Drawing.Point(442, 33);
            this.Kids.Name = "Kids";
            this.Kids.Size = new System.Drawing.Size(75, 23);
            this.Kids.TabIndex = 3;
            this.Kids.Text = "아동";
            this.Kids.UseVisualStyleBackColor = true;
            this.Kids.Click += new System.EventHandler(this.Kids_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(312, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 112);
            this.listBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "Table2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Kids);
            this.Controls.Add(this.Adults);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.button1);
            this.Name = "Form1_Table";
            this.Text = "Table 현황";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Table1;
        private System.Windows.Forms.Button Adults;
        private System.Windows.Forms.Button Kids;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

