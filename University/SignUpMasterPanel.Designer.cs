namespace University
{
    partial class SignUpMasterPanel
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
            this.master_first_name = new System.Windows.Forms.Label();
            this.firstname_input = new System.Windows.Forms.TextBox();
            this.master_last_name = new System.Windows.Forms.Label();
            this.lastname_input = new System.Windows.Forms.TextBox();
            this.btn_back36 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_signup_master = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // master_first_name
            // 
            this.master_first_name.AutoSize = true;
            this.master_first_name.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.master_first_name.Location = new System.Drawing.Point(166, 27);
            this.master_first_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.master_first_name.Name = "master_first_name";
            this.master_first_name.Size = new System.Drawing.Size(27, 24);
            this.master_first_name.TabIndex = 0;
            this.master_first_name.Text = "نام:";
            // 
            // firstname_input
            // 
            this.firstname_input.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.firstname_input.Location = new System.Drawing.Point(74, 29);
            this.firstname_input.Margin = new System.Windows.Forms.Padding(2);
            this.firstname_input.Name = "firstname_input";
            this.firstname_input.Size = new System.Drawing.Size(76, 24);
            this.firstname_input.TabIndex = 1;
            // 
            // master_last_name
            // 
            this.master_last_name.AutoSize = true;
            this.master_last_name.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.master_last_name.Location = new System.Drawing.Point(166, 66);
            this.master_last_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.master_last_name.Name = "master_last_name";
            this.master_last_name.Size = new System.Drawing.Size(78, 24);
            this.master_last_name.TabIndex = 2;
            this.master_last_name.Text = "نام خانوادگی:";
            // 
            // lastname_input
            // 
            this.lastname_input.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.lastname_input.Location = new System.Drawing.Point(74, 66);
            this.lastname_input.Margin = new System.Windows.Forms.Padding(2);
            this.lastname_input.Name = "lastname_input";
            this.lastname_input.Size = new System.Drawing.Size(76, 24);
            this.lastname_input.TabIndex = 3;
            // 
            // btn_back36
            // 
            this.btn_back36.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_back36.Location = new System.Drawing.Point(36, 244);
            this.btn_back36.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back36.Name = "btn_back36";
            this.btn_back36.Size = new System.Drawing.Size(69, 30);
            this.btn_back36.TabIndex = 4;
            this.btn_back36.Text = "بازگشت";
            this.btn_back36.UseVisualStyleBackColor = true;
            this.btn_back36.Click += new System.EventHandler(this.btn_back36_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_signup_master);
            this.groupBox1.Controls.Add(this.firstname_input);
            this.groupBox1.Controls.Add(this.master_first_name);
            this.groupBox1.Controls.Add(this.master_last_name);
            this.groupBox1.Controls.Add(this.lastname_input);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(36, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(250, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات استاد";
            // 
            // btn_signup_master
            // 
            this.btn_signup_master.Location = new System.Drawing.Point(74, 141);
            this.btn_signup_master.Margin = new System.Windows.Forms.Padding(2);
            this.btn_signup_master.Name = "btn_signup_master";
            this.btn_signup_master.Size = new System.Drawing.Size(56, 30);
            this.btn_signup_master.TabIndex = 4;
            this.btn_signup_master.Text = "ثبت";
            this.btn_signup_master.UseVisualStyleBackColor = true;
            this.btn_signup_master.Click += new System.EventHandler(this.btn_signup_master_Click);
            // 
            // SignUpMasterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 284);
            this.Controls.Add(this.btn_back36);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUpMasterPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMasterPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label master_first_name;
        private System.Windows.Forms.TextBox firstname_input;
        private System.Windows.Forms.Label master_last_name;
        private System.Windows.Forms.TextBox lastname_input;
        private System.Windows.Forms.Button btn_back36;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_signup_master;
    }
}