namespace University
{
    partial class MasterClasses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search_stds = new System.Windows.Forms.Button();
            this.master_name = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(409, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_search_stds);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(419, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(271, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشاهده لیست دانشجویان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد کلاس:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 31);
            this.textBox1.TabIndex = 1;
            // 
            // btn_search_stds
            // 
            this.btn_search_stds.Location = new System.Drawing.Point(4, 28);
            this.btn_search_stds.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search_stds.Name = "btn_search_stds";
            this.btn_search_stds.Size = new System.Drawing.Size(68, 30);
            this.btn_search_stds.TabIndex = 0;
            this.btn_search_stds.Text = "جستجو";
            this.btn_search_stds.UseVisualStyleBackColor = true;
            this.btn_search_stds.Click += new System.EventHandler(this.btn_search_stds_Click);
            // 
            // master_name
            // 
            this.master_name.AutoSize = true;
            this.master_name.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.master_name.Location = new System.Drawing.Point(633, 7);
            this.master_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.master_name.Name = "master_name";
            this.master_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.master_name.Size = new System.Drawing.Size(60, 24);
            this.master_name.TabIndex = 2;
            this.master_name.Text = "جعفر تنها";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(607, 470);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(65, 28);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MasterClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 508);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.master_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MasterClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterClasses";
            this.Load += new System.EventHandler(this.MasterClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_search_stds;
        private System.Windows.Forms.Label master_name;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}