namespace University
{
    partial class AddCoursePanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back9 = new System.Windows.Forms.Button();
            this.examTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.val = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masterCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.btn_add_course = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_back9);
            this.groupBox1.Controls.Add(this.examTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.val);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.masterCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.code);
            this.groupBox1.Controls.Add(this.btn_add_course);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(447, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن درس جدید";
            // 
            // btn_back9
            // 
            this.btn_back9.Location = new System.Drawing.Point(12, 180);
            this.btn_back9.Name = "btn_back9";
            this.btn_back9.Size = new System.Drawing.Size(111, 37);
            this.btn_back9.TabIndex = 14;
            this.btn_back9.Text = "بازگشت";
            this.btn_back9.UseVisualStyleBackColor = true;
            this.btn_back9.Click += new System.EventHandler(this.btn_back9_Click);
            // 
            // examTime
            // 
            this.examTime.Location = new System.Drawing.Point(236, 122);
            this.examTime.Margin = new System.Windows.Forms.Padding(4);
            this.examTime.Name = "examTime";
            this.examTime.Size = new System.Drawing.Size(93, 37);
            this.examTime.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "تعداد واحد:";
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(12, 122);
            this.val.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(121, 37);
            this.val.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "تاریخ امتحان:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "زمان کلاس:";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(12, 78);
            this.time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(121, 37);
            this.time.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "کد استاد:";
            // 
            // masterCode
            // 
            this.masterCode.Location = new System.Drawing.Point(235, 78);
            this.masterCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masterCode.Name = "masterCode";
            this.masterCode.Size = new System.Drawing.Size(121, 37);
            this.masterCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام درس:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 32);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 37);
            this.name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد درس:";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(235, 32);
            this.code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(121, 37);
            this.code.TabIndex = 1;
            // 
            // btn_add_course
            // 
            this.btn_add_course.Location = new System.Drawing.Point(143, 180);
            this.btn_add_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_course.Name = "btn_add_course";
            this.btn_add_course.Size = new System.Drawing.Size(123, 37);
            this.btn_add_course.TabIndex = 0;
            this.btn_add_course.Text = "افزودن";
            this.btn_add_course.UseVisualStyleBackColor = true;
            this.btn_add_course.Click += new System.EventHandler(this.btn_add_course_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddCoursePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 257);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCoursePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Button btn_add_course;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox masterCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox val;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker examTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_back9;
    }
}