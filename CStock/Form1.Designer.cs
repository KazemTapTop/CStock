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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LastTradeDay_Stat = new System.Windows.Forms.TextBox();
            this.LastDayTrade_DG = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonExit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSettings = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonُSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastDayTrade_DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اندیکاتورها";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.SkyBlue;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonExit,
            this.barButtonSettings});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHome,
            this.ribbonُSettings});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(915, 142);
            // 
            // barButtonExit
            // 
            this.barButtonExit.Caption = "خروج";
            this.barButtonExit.Id = 3;
            this.barButtonExit.Name = "barButtonExit";
            this.barButtonExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitButton_Click);
            // 
            // barButtonSettings
            // 
            this.barButtonSettings.Caption = "تنظیمات";
            this.barButtonSettings.Id = 4;
            this.barButtonSettings.Name = "barButtonSettings";
            this.barButtonSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Settings_Click);
            // 
            // ribbonHome
            // 
            this.ribbonHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonHome.Name = "ribbonHome";
            this.ribbonHome.Text = "خــــــانه";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonExit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "        Exit                           ";
            // 
            // ribbonُSettings
            // 
            this.ribbonُSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonُSettings.Name = "ribbonُSettings";
            this.ribbonُSettings.Text = "گزینه ها";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonSettings);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "                                      ";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // CStock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 519);
            this.Controls.Add(this.ribbonControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView LastDayTrade_DG;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox LastTradeDay_Stat;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonExit;
        private DevExpress.XtraBars.BarButtonItem barButtonSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonُSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}

