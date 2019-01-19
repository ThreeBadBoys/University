namespace University
{
    partial class EnterPage
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
            this.Greeting = new System.Windows.Forms.Label();
            this.LogInType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_id = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Greeting.Location = new System.Drawing.Point(133, 58);
            this.Greeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(94, 30);
            this.Greeting.TabIndex = 3;
            this.Greeting.Text = "خوش آمدید";
            // 
            // LogInType
            // 
            this.LogInType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LogInType.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LogInType.FormattingEnabled = true;
            this.LogInType.Items.AddRange(new object[] {
            "دانشجو",
            "استاد",
            "آموزش"});
            this.LogInType.Location = new System.Drawing.Point(124, 112);
            this.LogInType.Margin = new System.Windows.Forms.Padding(2);
            this.LogInType.Name = "LogInType";
            this.LogInType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LogInType.Size = new System.Drawing.Size(106, 32);
            this.LogInType.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.password1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.username_id, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(94, 154);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // password1
            // 
            this.password1.Dock = System.Windows.Forms.DockStyle.Left;
            this.password1.Location = new System.Drawing.Point(90, 26);
            this.password1.Margin = new System.Windows.Forms.Padding(2);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(90, 20);
            this.password1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "شماره کاربری:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمزعبور:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_id
            // 
            this.username_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.username_id.Location = new System.Drawing.Point(90, 2);
            this.username_id.Margin = new System.Windows.Forms.Padding(2);
            this.username_id.Name = "username_id";
            this.username_id.Size = new System.Drawing.Size(90, 20);
            this.username_id.TabIndex = 0;
            // 
            // btn_enter
            // 
            this.btn_enter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_enter.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.btn_enter.Location = new System.Drawing.Point(124, 217);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(105, 34);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "ورود";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // EnterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LogInType);
            this.Controls.Add(this.Greeting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EnterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.ComboBox LogInType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox username_id;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

