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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CStock_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LastTradeDay_Stat = new System.Windows.Forms.TextBox();
            this.LastDayTrade_DG = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxIndicators = new System.Windows.Forms.ListBox();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonHome = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTabSettings = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonSettings = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sec15MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sec30MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Min1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Min2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Min5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Min10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Min15MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hour1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hour2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomUpTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastDayTrade_DG)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 186);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 327);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LastTradeDay_Stat);
            this.tabPage1.Controls.Add(this.LastDayTrade_DG);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " معاملات آخرین روز";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LastTradeDay_Stat
            // 
            this.LastTradeDay_Stat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LastTradeDay_Stat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastTradeDay_Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastTradeDay_Stat.Location = new System.Drawing.Point(285, 127);
            this.LastTradeDay_Stat.Name = "LastTradeDay_Stat";
            this.LastTradeDay_Stat.Size = new System.Drawing.Size(329, 17);
            this.LastTradeDay_Stat.TabIndex = 1;
            this.LastTradeDay_Stat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastTradeDay_Stat.Visible = false;
            // 
            // LastDayTrade_DG
            // 
            this.LastDayTrade_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LastDayTrade_DG.Location = new System.Drawing.Point(0, 0);
            this.LastDayTrade_DG.Name = "LastDayTrade_DG";
            this.LastDayTrade_DG.Size = new System.Drawing.Size(904, 305);
            this.LastDayTrade_DG.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxIndicators);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اندیکاتورها";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxIndicators
            // 
            this.listBoxIndicators.FormattingEnabled = true;
            this.listBoxIndicators.Location = new System.Drawing.Point(697, 6);
            this.listBoxIndicators.Name = "listBoxIndicators";
            this.listBoxIndicators.Size = new System.Drawing.Size(203, 290);
            this.listBoxIndicators.TabIndex = 0;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton3.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton3.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "ribbonButton3";
            // 
            // ribbonHome
            // 
            this.ribbonHome.Panels.Add(this.ribbonPanel2);
            this.ribbonHome.Panels.Add(this.ribbonPanel1);
            this.ribbonHome.Text = "خانه";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonTabSettings
            // 
            this.ribbonTabSettings.Panels.Add(this.ribbonPanel3);
            this.ribbonTabSettings.Text = "گزینه‌ها";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButtonSettings);
            this.ribbonPanel3.Text = "تنظیمات";
            // 
            // ribbonButtonSettings
            // 
            this.ribbonButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSettings.Image")));
            this.ribbonButtonSettings.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButtonSettings.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButtonSettings.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSettings.SmallImage")));
            this.ribbonButtonSettings.Text = "تنظیمات";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton2.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton4.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton5.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton6.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.ViewMenuItem,
            this.OptionsMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(49, 20);
            this.FileMenuItem.Text = "&پرونده";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(99, 22);
            this.ExitMenuItem.Text = "&خروج";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateTimeMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ViewMenuItem.Text = "نمایش";
            this.ViewMenuItem.Click += new System.EventHandler(this.ViewMenuItem_Click);
            // 
            // UpdateTimeMenuItem
            // 
            this.UpdateTimeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sec15MenuItem,
            this.Sec30MenuItem,
            this.Min1MenuItem,
            this.Min2MenuItem,
            this.Min5MenuItem,
            this.Min10MenuItem,
            this.Min15MenuItem,
            this.Hour1MenuItem,
            this.Hour2MenuItem,
            this.CustomUpTimeMenuItem});
            this.UpdateTimeMenuItem.Name = "UpdateTimeMenuItem";
            this.UpdateTimeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UpdateTimeMenuItem.Text = "زمان بروزآوری";
            // 
            // Sec15MenuItem
            // 
            this.Sec15MenuItem.CheckOnClick = true;
            this.Sec15MenuItem.Name = "Sec15MenuItem";
            this.Sec15MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Sec15MenuItem.Text = "15 ثانیه";
            this.Sec15MenuItem.Click += new System.EventHandler(this.Sec15MenuItem_Click);
            // 
            // Sec30MenuItem
            // 
            this.Sec30MenuItem.CheckOnClick = true;
            this.Sec30MenuItem.Name = "Sec30MenuItem";
            this.Sec30MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Sec30MenuItem.Text = "30 ثانیه";
            this.Sec30MenuItem.Click += new System.EventHandler(this.Sec30MenuItem_Click);
            // 
            // Min1MenuItem
            // 
            this.Min1MenuItem.CheckOnClick = true;
            this.Min1MenuItem.Name = "Min1MenuItem";
            this.Min1MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Min1MenuItem.Text = "1 دقیقه";
            this.Min1MenuItem.Click += new System.EventHandler(this.Min1MenuItem_Click);
            // 
            // Min2MenuItem
            // 
            this.Min2MenuItem.CheckOnClick = true;
            this.Min2MenuItem.Name = "Min2MenuItem";
            this.Min2MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Min2MenuItem.Text = "2 دقیقه";
            this.Min2MenuItem.Click += new System.EventHandler(this.Min2MenuItem_Click);
            // 
            // Min5MenuItem
            // 
            this.Min5MenuItem.CheckOnClick = true;
            this.Min5MenuItem.Name = "Min5MenuItem";
            this.Min5MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Min5MenuItem.Text = "5 دقیقه";
            this.Min5MenuItem.Click += new System.EventHandler(this.Min5MenuItem_Click);
            // 
            // Min10MenuItem
            // 
            this.Min10MenuItem.CheckOnClick = true;
            this.Min10MenuItem.Name = "Min10MenuItem";
            this.Min10MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Min10MenuItem.Text = "10 دقیقه";
            this.Min10MenuItem.Click += new System.EventHandler(this.Min10MenuItem_Click);
            // 
            // Min15MenuItem
            // 
            this.Min15MenuItem.CheckOnClick = true;
            this.Min15MenuItem.Name = "Min15MenuItem";
            this.Min15MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Min15MenuItem.Text = "15 دقیقه";
            this.Min15MenuItem.Click += new System.EventHandler(this.Min15MenuItem_Click);
            // 
            // Hour1MenuItem
            // 
            this.Hour1MenuItem.CheckOnClick = true;
            this.Hour1MenuItem.Name = "Hour1MenuItem";
            this.Hour1MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Hour1MenuItem.Text = "1 ساعت";
            this.Hour1MenuItem.Click += new System.EventHandler(this.Hour1MenuItem_Click);
            // 
            // Hour2MenuItem
            // 
            this.Hour2MenuItem.CheckOnClick = true;
            this.Hour2MenuItem.Name = "Hour2MenuItem";
            this.Hour2MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Hour2MenuItem.Text = "2 ساعت";
            this.Hour2MenuItem.Click += new System.EventHandler(this.Hour2MenuItem_Click);
            // 
            // CustomUpTimeMenuItem
            // 
            this.CustomUpTimeMenuItem.Name = "CustomUpTimeMenuItem";
            this.CustomUpTimeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CustomUpTimeMenuItem.Text = "زمان دلخواه ...";
            this.CustomUpTimeMenuItem.Click += new System.EventHandler(this.CustomUpTimeMenuItem_Click);
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItem});
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Size = new System.Drawing.Size(56, 20);
            this.OptionsMenuItem.Text = "&گزینه‌ها";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SettingsMenuItem.Text = "&تنظیمات";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(48, 20);
            this.HelpMenuItem.Text = "&راهنما";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(102, 22);
            this.AboutMenuItem.Text = "&درباره";
            // 
            // CStock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CStock_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "CStock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitToolStripMenuItem_Click);
            this.Load += new System.EventHandler(this.CStock_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastDayTrade_DG)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView LastDayTrade_DG;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox LastTradeDay_Stat;
        private System.Windows.Forms.ListBox listBoxIndicators;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonTab ribbonHome;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab ribbonTabSettings;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButtonSettings;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sec15MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sec30MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Min1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Min2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Min5MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Min10MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Min15MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Hour1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Hour2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomUpTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    }
}

