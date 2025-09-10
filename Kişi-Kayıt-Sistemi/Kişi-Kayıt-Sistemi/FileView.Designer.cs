
namespace Kişi_Kayıt_Sistemi
{
    partial class FileView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.FileClose = new DevExpress.XtraEditors.SimpleButton();
            this.FileOpen = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fileviewtool = new DevExpress.XtraRichEdit.RichEditControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.FileClose);
            this.layoutControl1.Controls.Add(this.FileOpen);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(903, 55);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // FileClose
            // 
            this.FileClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FileClose.ImageOptions.Image")));
            this.FileClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.FileClose.Location = new System.Drawing.Point(453, 12);
            this.FileClose.Name = "FileClose";
            this.FileClose.Size = new System.Drawing.Size(438, 30);
            this.FileClose.StyleController = this.layoutControl1;
            this.FileClose.TabIndex = 5;
            this.FileClose.ToolTip = "İptal et ve kapat ESC";
            this.FileClose.ToolTipController = this.toolTipController1;
            this.FileClose.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.FileClose.ToolTipTitle = "Bilgilendirme";
            this.FileClose.Click += new System.EventHandler(this.FileClose_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FileOpen.ImageOptions.Image")));
            this.FileOpen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.FileOpen.Location = new System.Drawing.Point(12, 12);
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(437, 30);
            this.FileOpen.StyleController = this.layoutControl1;
            this.FileOpen.TabIndex = 4;
            this.FileOpen.ToolTip = "Dosya Aç CTRL+O";
            this.FileOpen.ToolTipController = this.toolTipController1;
            this.FileOpen.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.FileOpen.ToolTipTitle = "Bilgilendirme";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(903, 55);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.FileOpen;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(441, 35);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.FileClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(441, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(442, 35);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // fileviewtool
            // 
            this.fileviewtool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileviewtool.Location = new System.Drawing.Point(0, 55);
            this.fileviewtool.Name = "fileviewtool";
            this.fileviewtool.Size = new System.Drawing.Size(903, 694);
            this.fileviewtool.TabIndex = 1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ToolTipStyle = DevExpress.Utils.ToolTipStyle.Windows7;
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // FileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 749);
            this.Controls.Add(this.fileviewtool);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileView";
            this.Text = "Dosya Görünümü Ve Yönetimi";
            this.Shown += new System.EventHandler(this.FileView_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton FileClose;
        private DevExpress.XtraEditors.SimpleButton FileOpen;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraRichEdit.RichEditControl fileviewtool;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}