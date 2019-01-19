namespace University
{
    partial class MasterPanel
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
            this.labelTeacherId = new System.Windows.Forms.Label();
            this.teachername = new System.Windows.Forms.Label();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.btn_back2 = new System.Windows.Forms.Button();
            this.btn_get_classes_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTeacherId
            // 
            this.labelTeacherId.AutoSize = true;
            this.labelTeacherId.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTeacherId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTeacherId.Location = new System.Drawing.Point(80, 60);
            this.labelTeacherId.Name = "labelTeacherId";
            this.labelTeacherId.Size = new System.Drawing.Size(87, 23);
            this.labelTeacherId.TabIndex = 3;
            this.labelTeacherId.Text = "12345678912";
            // 
            // teachername
            // 
            this.teachername.AutoSize = true;
            this.teachername.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.teachername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.teachername.Location = new System.Drawing.Point(96, 19);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(56, 23);
            this.teachername.TabIndex = 2;
            this.teachername.Text = "جعفر تنها";
            // 
            // btn_change_password
            // 
            this.btn_change_password.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_change_password.Location = new System.Drawing.Point(12, 157);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(221, 48);
            this.btn_change_password.TabIndex = 4;
            this.btn_change_password.Text = "تغییر رمز عبور";
            this.btn_change_password.UseVisualStyleBackColor = true;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // btn_back2
            // 
            this.btn_back2.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_back2.Location = new System.Drawing.Point(12, 211);
            this.btn_back2.Name = "btn_back2";
            this.btn_back2.Size = new System.Drawing.Size(221, 48);
            this.btn_back2.TabIndex = 5;
            this.btn_back2.Text = "بازگشت";
            this.btn_back2.UseVisualStyleBackColor = true;
            this.btn_back2.Click += new System.EventHandler(this.btn_back2_Click);
            // 
            // btn_get_classes_list
            // 
            this.btn_get_classes_list.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_get_classes_list.Location = new System.Drawing.Point(12, 103);
            this.btn_get_classes_list.Name = "btn_get_classes_list";
            this.btn_get_classes_list.Size = new System.Drawing.Size(221, 48);
            this.btn_get_classes_list.TabIndex = 6;
            this.btn_get_classes_list.Text = "لیست کلاس ها";
            this.btn_get_classes_list.UseVisualStyleBackColor = true;
            this.btn_get_classes_list.Click += new System.EventHandler(this.btn_get_classes_list_Click);
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(241, 268);
            this.Controls.Add(this.btn_get_classes_list);
            this.Controls.Add(this.btn_back2);
            this.Controls.Add(this.btn_change_password);
            this.Controls.Add(this.labelTeacherId);
            this.Controls.Add(this.teachername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeacherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeacherId;
        private System.Windows.Forms.Label teachername;
        private System.Windows.Forms.Button btn_change_password;
        private System.Windows.Forms.Button btn_back2;
        private System.Windows.Forms.Button btn_get_classes_list;
    }
}