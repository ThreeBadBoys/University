namespace University
{
    partial class Grades
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
            this.std_name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // std_name
            // 
            this.std_name.AutoSize = true;
            this.std_name.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.std_name.Location = new System.Drawing.Point(708, 9);
            this.std_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(47, 17);
            this.std_name.TabIndex = 1;
            this.std_name.Text = "علی نجفی";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 517);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(727, 472);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 34);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 517);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.std_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Grades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.Grades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label std_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_back;
    }
}