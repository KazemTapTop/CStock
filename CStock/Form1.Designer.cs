namespace CStock
{
    partial class CStock_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.پروندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ابزارهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پروندهToolStripMenuItem,
            this.ابزارهاToolStripMenuItem,
            this.راهنماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // پروندهToolStripMenuItem
            // 
            this.پروندهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem});
            this.پروندهToolStripMenuItem.Name = "پروندهToolStripMenuItem";
            this.پروندهToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.پروندهToolStripMenuItem.Text = "&پرونده";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.خروجToolStripMenuItem.Text = "&خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // ابزارهاToolStripMenuItem
            // 
            this.ابزارهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیماتToolStripMenuItem});
            this.ابزارهاToolStripMenuItem.Name = "ابزارهاToolStripMenuItem";
            this.ابزارهاToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ابزارهاToolStripMenuItem.Text = "&ابزارها";
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.تنظیماتToolStripMenuItem.Text = "&تنظیمات";
            this.تنظیماتToolStripMenuItem.Click += new System.EventHandler(this.تنظیماتToolStripMenuItem_Click);
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دربارهToolStripMenuItem});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.راهنماToolStripMenuItem.Text = "&راهنما";
            // 
            // دربارهToolStripMenuItem
            // 
            this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
            this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.دربارهToolStripMenuItem.Text = "&درباره";
            // 
            // CStock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CStock_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "CStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem پروندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ابزارهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهToolStripMenuItem;
    }
}

