namespace University
{
    partial class Add_Remove_Course
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_back38 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "برای حذف یا اضافه درس، کد درس را وارد نمایید";
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_remove.Location = new System.Drawing.Point(235, 147);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(66, 34);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "حذف";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add.Location = new System.Drawing.Point(152, 147);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(66, 34);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(188, 104);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 31);
            this.textBox1.TabIndex = 3;
            // 
            // btn_back38
            // 
            this.btn_back38.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_back38.Location = new System.Drawing.Point(9, 204);
            this.btn_back38.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back38.Name = "btn_back38";
            this.btn_back38.Size = new System.Drawing.Size(66, 34);
            this.btn_back38.TabIndex = 4;
            this.btn_back38.Text = "بازگشت";
            this.btn_back38.UseVisualStyleBackColor = true;
            this.btn_back38.Click += new System.EventHandler(this.btn_back38_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Add_Remove_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 248);
            this.Controls.Add(this.btn_back38);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Add_Remove_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Remove_Course";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_back38;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}