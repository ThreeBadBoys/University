namespace University
{
    partial class InsertingGradePanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdid = new System.Windows.Forms.TextBox();
            this.btn_insert_stds = new System.Windows.Forms.Button();
            this.course_title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stdid);
            this.groupBox1.Controls.Add(this.btn_insert_stds);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(489, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(271, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "درج نمره";
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(114, 74);
            this.grade.Margin = new System.Windows.Forms.Padding(2);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(113, 31);
            this.grade.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "نمره:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "شماره دانشجویی:";
            // 
            // stdid
            // 
            this.stdid.Location = new System.Drawing.Point(13, 28);
            this.stdid.Margin = new System.Windows.Forms.Padding(2);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(148, 31);
            this.stdid.TabIndex = 1;
            // 
            // btn_insert_stds
            // 
            this.btn_insert_stds.Location = new System.Drawing.Point(13, 74);
            this.btn_insert_stds.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insert_stds.Name = "btn_insert_stds";
            this.btn_insert_stds.Size = new System.Drawing.Size(68, 30);
            this.btn_insert_stds.TabIndex = 0;
            this.btn_insert_stds.Text = "درج";
            this.btn_insert_stds.UseVisualStyleBackColor = true;
            this.btn_insert_stds.Click += new System.EventHandler(this.btn_insert_stds_Click);
            // 
            // course_title
            // 
            this.course_title.AutoSize = true;
            this.course_title.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.course_title.Location = new System.Drawing.Point(704, 9);
            this.course_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.course_title.Name = "course_title";
            this.course_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.course_title.Size = new System.Drawing.Size(60, 24);
            this.course_title.TabIndex = 2;
            this.course_title.Text = "جعفر تنها";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(695, 469);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(65, 28);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // InsertingGradePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 508);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.course_title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertingGradePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertingGrades";
            this.Load += new System.EventHandler(this.InsertingGradePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdid;
        private System.Windows.Forms.Button btn_insert_stds;
        private System.Windows.Forms.Label course_title;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Label label2;
    }
}