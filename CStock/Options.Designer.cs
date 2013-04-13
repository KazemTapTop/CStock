namespace CStock
{
    partial class Options
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
            this.label2 = new System.Windows.Forms.Label();
            this.textUpdate_Time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboServer_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textUpdate_Time);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ثانیه";
            // 
            // textUpdate_Time
            // 
            this.textUpdate_Time.Location = new System.Drawing.Point(281, 25);
            this.textUpdate_Time.Name = "textUpdate_Time";
            this.textUpdate_Time.Size = new System.Drawing.Size(45, 20);
            this.textUpdate_Time.TabIndex = 4;
            this.textUpdate_Time.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "بازه زمانی به روزآوری";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPass);
            this.groupBox2.Controls.Add(this.textUser);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboServer_Type);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textPort);
            this.groupBox2.Controls.Add(this.textIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 133);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تنظیمات SQL Server";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(50, 67);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(103, 20);
            this.textPass.TabIndex = 7;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(50, 28);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(103, 20);
            this.textUser.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "نام کاربری";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "رمز عبور";
            // 
            // cboServer_Type
            // 
            this.cboServer_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServer_Type.FormattingEnabled = true;
            this.cboServer_Type.Items.AddRange(new object[] {
            "Local",
            "Remote"});
            this.cboServer_Type.Location = new System.Drawing.Point(283, 28);
            this.cboServer_Type.Name = "cboServer_Type";
            this.cboServer_Type.Size = new System.Drawing.Size(93, 21);
            this.cboServer_Type.TabIndex = 5;
            this.cboServer_Type.SelectedIndexChanged += new System.EventHandler(this.cboServer_Type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "نوع سرور:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "پورت";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(325, 98);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(51, 20);
            this.textPort.TabIndex = 2;
            this.textPort.Text = "1403";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(283, 68);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(93, 20);
            this.textIP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "آدرس (IP)";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(258, 260);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 24);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&تایید";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(373, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Options";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUpdate_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboServer_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}