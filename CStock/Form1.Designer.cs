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
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonHome = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTabSettings = new System.Windows.Forms.RibbonTab();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastDayTrade_DG)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton3);
            this.ribbon1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbon1.Size = new System.Drawing.Size(915, 169);
            this.ribbon1.TabIndex = 3;
            this.ribbon1.Tabs.Add(this.ribbonHome);
            this.ribbon1.Tabs.Add(this.ribbonTabSettings);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
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
            this.ribbonHome.Panels.Add(this.ribbonPanel1);
            this.ribbonHome.Panels.Add(this.ribbonPanel2);
            this.ribbonHome.Text = "خانه";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "Exit";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonTabSettings
            // 
            this.ribbonTabSettings.Text = "گزینه‌ها";
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
            // CStock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 519);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.tabControl1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView LastDayTrade_DG;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox LastTradeDay_Stat;
        private System.Windows.Forms.ListBox listBoxIndicators;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonTab ribbonHome;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab ribbonTabSettings;
    }
}

