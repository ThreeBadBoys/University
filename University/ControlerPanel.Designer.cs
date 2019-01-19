namespace University
{
    partial class ControlerPanel
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
            this.chooseUnit = new System.Windows.Forms.CheckBox();
            this.addOrRemove = new System.Windows.Forms.CheckBox();
            this.btn_back13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_back13);
            this.groupBox1.Controls.Add(this.chooseUnit);
            this.groupBox1.Controls.Add(this.addOrRemove);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(349, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کنترل انتخاب واحد و حذف و اضافه";
            // 
            // chooseUnit
            // 
            this.chooseUnit.AutoSize = true;
            this.chooseUnit.Location = new System.Drawing.Point(226, 48);
            this.chooseUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseUnit.Name = "chooseUnit";
            this.chooseUnit.Size = new System.Drawing.Size(115, 34);
            this.chooseUnit.TabIndex = 1;
            this.chooseUnit.Text = "انتخاب واحد";
            this.chooseUnit.UseVisualStyleBackColor = true;
            this.chooseUnit.CheckedChanged += new System.EventHandler(this.chooseUnit_CheckedChanged);
            // 
            // addOrRemove
            // 
            this.addOrRemove.AutoSize = true;
            this.addOrRemove.Location = new System.Drawing.Point(220, 90);
            this.addOrRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addOrRemove.Name = "addOrRemove";
            this.addOrRemove.Size = new System.Drawing.Size(121, 34);
            this.addOrRemove.TabIndex = 0;
            this.addOrRemove.Text = "حذف و اضافه";
            this.addOrRemove.UseVisualStyleBackColor = true;
            this.addOrRemove.CheckedChanged += new System.EventHandler(this.addOrRemove_CheckedChanged);
            // 
            // btn_back13
            // 
            this.btn_back13.Location = new System.Drawing.Point(16, 90);
            this.btn_back13.Name = "btn_back13";
            this.btn_back13.Size = new System.Drawing.Size(85, 36);
            this.btn_back13.TabIndex = 3;
            this.btn_back13.Text = "بازگشت";
            this.btn_back13.UseVisualStyleBackColor = true;
            this.btn_back13.Click += new System.EventHandler(this.btn_back13_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 179);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ControlerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "controlerPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.controlerPanel_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox addOrRemove;
        private System.Windows.Forms.CheckBox chooseUnit;
        private System.Windows.Forms.Button btn_back13;
        private System.Windows.Forms.Button button1;
    }
}