namespace University
{
    partial class SignUpStudentPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_std_signup = new System.Windows.Forms.Button();
            this.std_major = new System.Windows.Forms.TextBox();
            this.std_last_name = new System.Windows.Forms.TextBox();
            this.std_first_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back35 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_std_signup);
            this.groupBox1.Controls.Add(this.std_major);
            this.groupBox1.Controls.Add(this.std_last_name);
            this.groupBox1.Controls.Add(this.std_first_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(37, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(336, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات دانشجو";
            // 
            // btn_std_signup
            // 
            this.btn_std_signup.Location = new System.Drawing.Point(88, 169);
            this.btn_std_signup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_std_signup.Name = "btn_std_signup";
            this.btn_std_signup.Size = new System.Drawing.Size(71, 27);
            this.btn_std_signup.TabIndex = 1;
            this.btn_std_signup.Text = "ثبت";
            this.btn_std_signup.UseVisualStyleBackColor = true;
            this.btn_std_signup.Click += new System.EventHandler(this.btn_std_signup_Click);
            // 
            // std_major
            // 
            this.std_major.Location = new System.Drawing.Point(88, 119);
            this.std_major.Margin = new System.Windows.Forms.Padding(2);
            this.std_major.Name = "std_major";
            this.std_major.Size = new System.Drawing.Size(141, 30);
            this.std_major.TabIndex = 5;
            // 
            // std_last_name
            // 
            this.std_last_name.Location = new System.Drawing.Point(88, 79);
            this.std_last_name.Margin = new System.Windows.Forms.Padding(2);
            this.std_last_name.Name = "std_last_name";
            this.std_last_name.Size = new System.Drawing.Size(141, 30);
            this.std_last_name.TabIndex = 4;
            // 
            // std_first_name
            // 
            this.std_first_name.Location = new System.Drawing.Point(88, 38);
            this.std_first_name.Margin = new System.Windows.Forms.Padding(2);
            this.std_first_name.Name = "std_first_name";
            this.std_first_name.Size = new System.Drawing.Size(141, 30);
            this.std_first_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "رشته تحصیلی:";
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
            // btn_back35
            // 
            this.btn_back35.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_back35.Location = new System.Drawing.Point(37, 242);
            this.btn_back35.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back35.Name = "btn_back35";
            this.btn_back35.Size = new System.Drawing.Size(79, 30);
            this.btn_back35.TabIndex = 1;
            this.btn_back35.Text = "بازگشت";
            this.btn_back35.UseVisualStyleBackColor = true;
            this.btn_back35.Click += new System.EventHandler(this.btn_back35_Click);
            // 
            // SignUpStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 282);
            this.Controls.Add(this.btn_back35);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUpStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox std_major;
        private System.Windows.Forms.TextBox std_last_name;
        private System.Windows.Forms.TextBox std_first_name;
        private System.Windows.Forms.Button btn_std_signup;
        private System.Windows.Forms.Button btn_back35;
    }
}