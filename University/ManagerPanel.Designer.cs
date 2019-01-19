namespace University
{
    partial class ManagerPanel
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_remove_student = new System.Windows.Forms.Button();
            this.btn_remove_student_term = new System.Windows.Forms.Button();
            this.btn_sign_up_master = new System.Windows.Forms.Button();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.btn_sign_up_manager = new System.Windows.Forms.Button();
            this.managername = new System.Windows.Forms.Label();
            this.managerid = new System.Windows.Forms.Label();
            this.btn_sign_up_student = new System.Windows.Forms.Button();
            this.btn_remove_master = new System.Windows.Forms.Button();
            this.btn_remove_manager = new System.Windows.Forms.Button();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_control_add_remove_course = new System.Windows.Forms.Button();
            this.btn_add_course = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(-165, -55);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "ثبت دانشجو";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_remove_student
            // 
            this.btn_remove_student.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_remove_student.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_remove_student.Location = new System.Drawing.Point(6, 104);
            this.btn_remove_student.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove_student.Name = "btn_remove_student";
            this.btn_remove_student.Size = new System.Drawing.Size(166, 37);
            this.btn_remove_student.TabIndex = 11;
            this.btn_remove_student.Text = "حذف دانشجو";
            this.btn_remove_student.UseVisualStyleBackColor = false;
            this.btn_remove_student.Click += new System.EventHandler(this.btn_remove_student_Click);
            // 
            // btn_remove_student_term
            // 
            this.btn_remove_student_term.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_remove_student_term.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_remove_student_term.Location = new System.Drawing.Point(6, 189);
            this.btn_remove_student_term.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove_student_term.Name = "btn_remove_student_term";
            this.btn_remove_student_term.Size = new System.Drawing.Size(166, 38);
            this.btn_remove_student_term.TabIndex = 12;
            this.btn_remove_student_term.Text = "حذف ترم دانشجو";
            this.btn_remove_student_term.UseVisualStyleBackColor = false;
            this.btn_remove_student_term.Click += new System.EventHandler(this.btn_remove_student_term_Click);
            // 
            // btn_sign_up_master
            // 
            this.btn_sign_up_master.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_sign_up_master.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_sign_up_master.Location = new System.Drawing.Point(6, 60);
            this.btn_sign_up_master.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sign_up_master.Name = "btn_sign_up_master";
            this.btn_sign_up_master.Size = new System.Drawing.Size(166, 38);
            this.btn_sign_up_master.TabIndex = 8;
            this.btn_sign_up_master.Text = "ثبت استاد";
            this.btn_sign_up_master.UseVisualStyleBackColor = false;
            this.btn_sign_up_master.Click += new System.EventHandler(this.btn_sign_up_master_Click);
            // 
            // btn_change_password
            // 
            this.btn_change_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_change_password.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_change_password.Location = new System.Drawing.Point(181, 276);
            this.btn_change_password.Margin = new System.Windows.Forms.Padding(2);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(166, 39);
            this.btn_change_password.TabIndex = 10;
            this.btn_change_password.Text = "تغییر رمز عبور";
            this.btn_change_password.UseVisualStyleBackColor = false;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // btn_sign_up_manager
            // 
            this.btn_sign_up_manager.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_sign_up_manager.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_sign_up_manager.Location = new System.Drawing.Point(181, 61);
            this.btn_sign_up_manager.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sign_up_manager.Name = "btn_sign_up_manager";
            this.btn_sign_up_manager.Size = new System.Drawing.Size(166, 37);
            this.btn_sign_up_manager.TabIndex = 13;
            this.btn_sign_up_manager.Text = "ثبت آموزش";
            this.btn_sign_up_manager.UseVisualStyleBackColor = false;
            this.btn_sign_up_manager.Click += new System.EventHandler(this.btn_sign_up_manager_Click);
            // 
            // managername
            // 
            this.managername.AutoSize = true;
            this.managername.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.managername.Location = new System.Drawing.Point(161, 7);
            this.managername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managername.Name = "managername";
            this.managername.Size = new System.Drawing.Size(30, 17);
            this.managername.TabIndex = 14;
            this.managername.Text = "پاکزاد";
            // 
            // managerid
            // 
            this.managerid.AutoSize = true;
            this.managerid.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.managerid.Location = new System.Drawing.Point(142, 26);
            this.managerid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managerid.Name = "managerid";
            this.managerid.Size = new System.Drawing.Size(66, 17);
            this.managerid.TabIndex = 15;
            this.managerid.Text = "12345678912";
            // 
            // btn_sign_up_student
            // 
            this.btn_sign_up_student.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_sign_up_student.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_sign_up_student.Location = new System.Drawing.Point(181, 103);
            this.btn_sign_up_student.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sign_up_student.Name = "btn_sign_up_student";
            this.btn_sign_up_student.Size = new System.Drawing.Size(166, 37);
            this.btn_sign_up_student.TabIndex = 16;
            this.btn_sign_up_student.Text = "ثبت دانشجو";
            this.btn_sign_up_student.UseVisualStyleBackColor = false;
            this.btn_sign_up_student.Click += new System.EventHandler(this.btn_sign_up_student_Click);
            // 
            // btn_remove_master
            // 
            this.btn_remove_master.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_remove_master.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_remove_master.Location = new System.Drawing.Point(6, 145);
            this.btn_remove_master.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove_master.Name = "btn_remove_master";
            this.btn_remove_master.Size = new System.Drawing.Size(166, 39);
            this.btn_remove_master.TabIndex = 17;
            this.btn_remove_master.Text = "حذف استاد";
            this.btn_remove_master.UseVisualStyleBackColor = false;
            this.btn_remove_master.Click += new System.EventHandler(this.btn_remove_master_Click);
            // 
            // btn_remove_manager
            // 
            this.btn_remove_manager.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_remove_manager.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_remove_manager.Location = new System.Drawing.Point(181, 145);
            this.btn_remove_manager.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove_manager.Name = "btn_remove_manager";
            this.btn_remove_manager.Size = new System.Drawing.Size(166, 39);
            this.btn_remove_manager.TabIndex = 18;
            this.btn_remove_manager.Text = "حذف آموزش";
            this.btn_remove_manager.UseVisualStyleBackColor = false;
            this.btn_remove_manager.Click += new System.EventHandler(this.btn_remove_manager_Click);
            // 
            // btn_back1
            // 
            this.btn_back1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_back1.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_back1.Location = new System.Drawing.Point(6, 320);
            this.btn_back1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(340, 39);
            this.btn_back1.TabIndex = 19;
            this.btn_back1.Text = "بازگشت";
            this.btn_back1.UseVisualStyleBackColor = false;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button10.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(181, 189);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 38);
            this.button10.TabIndex = 20;
            this.button10.Text = "اتمام ترم";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_control_add_remove_course
            // 
            this.btn_control_add_remove_course.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_control_add_remove_course.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_control_add_remove_course.Location = new System.Drawing.Point(6, 232);
            this.btn_control_add_remove_course.Margin = new System.Windows.Forms.Padding(2);
            this.btn_control_add_remove_course.Name = "btn_control_add_remove_course";
            this.btn_control_add_remove_course.Size = new System.Drawing.Size(340, 39);
            this.btn_control_add_remove_course.TabIndex = 22;
            this.btn_control_add_remove_course.Text = "کنترل حذف و اضافه و انتخاب واحد";
            this.btn_control_add_remove_course.UseVisualStyleBackColor = false;
            this.btn_control_add_remove_course.Click += new System.EventHandler(this.btn_control_add_remove_course_Click);
            // 
            // btn_add_course
            // 
            this.btn_add_course.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_add_course.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_add_course.Location = new System.Drawing.Point(6, 276);
            this.btn_add_course.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_course.Name = "btn_add_course";
            this.btn_add_course.Size = new System.Drawing.Size(166, 39);
            this.btn_add_course.TabIndex = 23;
            this.btn_add_course.Text = "اضافه کردن درس";
            this.btn_add_course.UseVisualStyleBackColor = false;
            this.btn_add_course.Click += new System.EventHandler(this.btn_add_course_Click);
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 364);
            this.Controls.Add(this.btn_add_course);
            this.Controls.Add(this.btn_control_add_remove_course);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_remove_manager);
            this.Controls.Add(this.btn_remove_master);
            this.Controls.Add(this.btn_sign_up_student);
            this.Controls.Add(this.managerid);
            this.Controls.Add(this.managername);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_remove_student);
            this.Controls.Add(this.btn_remove_student_term);
            this.Controls.Add(this.btn_sign_up_master);
            this.Controls.Add(this.btn_change_password);
            this.Controls.Add(this.btn_sign_up_manager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_remove_student;
        private System.Windows.Forms.Button btn_remove_student_term;
        private System.Windows.Forms.Button btn_sign_up_master;
        private System.Windows.Forms.Button btn_change_password;
        private System.Windows.Forms.Button btn_sign_up_manager;
        private System.Windows.Forms.Label managername;
        private System.Windows.Forms.Label managerid;
        private System.Windows.Forms.Button btn_sign_up_student;
        private System.Windows.Forms.Button btn_remove_master;
        private System.Windows.Forms.Button btn_remove_manager;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_control_add_remove_course;
        private System.Windows.Forms.Button btn_add_course;
    }
}