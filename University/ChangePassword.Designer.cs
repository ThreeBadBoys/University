namespace University
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.currentpassword = new System.Windows.Forms.TextBox();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // currentpassword
            // 
            this.currentpassword.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.currentpassword.Location = new System.Drawing.Point(52, 82);
            this.currentpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentpassword.Name = "currentpassword";
            this.currentpassword.Size = new System.Drawing.Size(136, 24);
            this.currentpassword.TabIndex = 0;
            // 
            // newpassword
            // 
            this.newpassword.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.newpassword.Location = new System.Drawing.Point(52, 110);
            this.newpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(136, 24);
            this.newpassword.TabIndex = 1;
            // 
            // confirmpassword
            // 
            this.confirmpassword.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.confirmpassword.Location = new System.Drawing.Point(52, 137);
            this.confirmpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(136, 24);
            this.confirmpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(191, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "رمزقبلی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(191, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "رمز جدید";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(191, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "تکرار رمز جدید";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.confirm.Location = new System.Drawing.Point(52, 177);
            this.confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(135, 29);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "تایید";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(85, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "تغییر رمز عبور";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(52, 211);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(135, 29);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "بازگشت";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(264, 262);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.currentpassword);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentpassword;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}