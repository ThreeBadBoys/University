namespace University
{
    partial class ChooseCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(132, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "برای انتخاب درس،کد درس مورد نظر را وارد فرمایید";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(12, 214);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 33);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(251, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 37);
            this.textBox1.TabIndex = 2;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_ok.Location = new System.Drawing.Point(251, 150);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 37);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "تایید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ChooseCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 259);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChooseCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ok;
    }
}