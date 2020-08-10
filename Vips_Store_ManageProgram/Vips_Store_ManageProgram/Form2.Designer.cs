namespace Vips_Store_ManageProgram
{
    partial class Form2_Customer
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
            this.label_Days_Title = new System.Windows.Forms.Label();
            this.label_Customer_List_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Days_Title
            // 
            this.label_Days_Title.AutoSize = true;
            this.label_Days_Title.Location = new System.Drawing.Point(89, 63);
            this.label_Days_Title.Name = "label_Days_Title";
            this.label_Days_Title.Size = new System.Drawing.Size(67, 12);
            this.label_Days_Title.TabIndex = 0;
            this.label_Days_Title.Text = "요일 별 ~~";
            // 
            // label_Customer_List_Title
            // 
            this.label_Customer_List_Title.AutoSize = true;
            this.label_Customer_List_Title.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Customer_List_Title.Location = new System.Drawing.Point(592, 9);
            this.label_Customer_List_Title.Name = "label_Customer_List_Title";
            this.label_Customer_List_Title.Size = new System.Drawing.Size(73, 21);
            this.label_Customer_List_Title.TabIndex = 1;
            this.label_Customer_List_Title.Text = "회원 List";
            // 
            // Form2_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Customer_List_Title);
            this.Controls.Add(this.label_Days_Title);
            this.Name = "Form2_Customer";
            this.Text = "회원 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Days_Title;
        private System.Windows.Forms.Label label_Customer_List_Title;
    }
}