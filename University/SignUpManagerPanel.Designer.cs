namespace University
{
    partial class SignUpManagerPanel
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
            this.btn_back34 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_std_signup = new System.Windows.Forms.Button();
            this.mng_last_name = new System.Windows.Forms.TextBox();
            this.mng_first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back34
            // 
            this.btn_back34.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_back34.Location = new System.Drawing.Point(22, 222);
            this.btn_back34.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back34.Name = "btn_back34";
            this.btn_back34.Size = new System.Drawing.Size(79, 30);
            this.btn_back34.TabIndex = 3;
            this.btn_back34.Text = "بازگشت";
            this.btn_back34.UseVisualStyleBackColor = true;
            this.btn_back34.Click += new System.EventHandler(this.btn_back34_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_std_signup);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.mng_last_name);
            this.groupBox1.Controls.Add(this.mng_first_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(336, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات مدیرآموزشی";
            // 
            // btn_std_signup
            // 
            this.btn_std_signup.Location = new System.Drawing.Point(88, 155);
            this.btn_std_signup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_std_signup.Name = "btn_std_signup";
            this.btn_std_signup.Size = new System.Drawing.Size(71, 27);
            this.btn_std_signup.TabIndex = 1;
            this.btn_std_signup.Text = "ثبت";
            this.btn_std_signup.UseVisualStyleBackColor = true;
            this.btn_std_signup.Click += new System.EventHandler(this.btn_std_signup_Click);
            // 
            // mng_last_name
            // 
            this.mng_last_name.Location = new System.Drawing.Point(88, 79);
            this.mng_last_name.Margin = new System.Windows.Forms.Padding(2);
            this.mng_last_name.Name = "mng_last_name";
            this.mng_last_name.Size = new System.Drawing.Size(141, 30);
            this.mng_last_name.TabIndex = 4;
            // 
            // mng_first_name
            // 
            this.mng_first_name.Location = new System.Drawing.Point(88, 38);
            this.mng_first_name.Margin = new System.Windows.Forms.Padding(2);
            this.mng_first_name.Name = "mng_first_name";
            this.mng_first_name.Size = new System.Drawing.Size(141, 30);
            this.mng_first_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(88, 121);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(141, 30);
            this.password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "رمزعبور:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SignUpManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.btn_back34);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUpManagerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpManagerPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back34;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_std_signup;
        private System.Windows.Forms.TextBox mng_last_name;
        private System.Windows.Forms.TextBox mng_first_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
    }
}