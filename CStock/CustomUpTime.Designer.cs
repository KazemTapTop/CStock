namespace CStock
{
    partial class CustomUpTime
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
            this.CustomUpTimetextBox = new System.Windows.Forms.TextBox();
            this.CustomUpTimeOK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "زمان دلخواه را برحسب ثانیه وارد نمایید:";
            // 
            // CustomUpTimetextBox
            // 
            this.CustomUpTimetextBox.Location = new System.Drawing.Point(4, 45);
            this.CustomUpTimetextBox.Name = "CustomUpTimetextBox";
            this.CustomUpTimetextBox.Size = new System.Drawing.Size(188, 20);
            this.CustomUpTimetextBox.TabIndex = 1;
            // 
            // CustomUpTimeOK_Button
            // 
            this.CustomUpTimeOK_Button.Location = new System.Drawing.Point(41, 79);
            this.CustomUpTimeOK_Button.Name = "CustomUpTimeOK_Button";
            this.CustomUpTimeOK_Button.Size = new System.Drawing.Size(117, 24);
            this.CustomUpTimeOK_Button.TabIndex = 2;
            this.CustomUpTimeOK_Button.Text = "تایید";
            this.CustomUpTimeOK_Button.UseVisualStyleBackColor = true;
            this.CustomUpTimeOK_Button.Click += new System.EventHandler(this.CustomUpTimeOK_Button_Click);
            // 
            // CustomUpTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 115);
            this.Controls.Add(this.CustomUpTimeOK_Button);
            this.Controls.Add(this.CustomUpTimetextBox);
            this.Controls.Add(this.label1);
            this.Name = "CustomUpTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "زمان بروزآوری";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomUpTimetextBox;
        private System.Windows.Forms.Button CustomUpTimeOK_Button;
    }
}