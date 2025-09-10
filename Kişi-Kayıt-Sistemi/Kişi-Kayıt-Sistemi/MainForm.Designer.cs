
namespace Kişi_Kayıt_Sistemi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Temabtn = new DevExpress.XtraBars.BarButtonItem();
            this.ListBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Jsondatabtn = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.lıstSkın = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.jsonpathwiew = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.JsonviewLogs = new DevExpress.XtraBars.BarButtonGroup();
            this.btnlogsjs = new DevExpress.XtraBars.BarButtonItem();
            this.btnjsoncreate = new DevExpress.XtraBars.BarButtonItem();
            this.Jsoncreateandread = new DevExpress.XtraBars.BarButtonItem();
            this.FileView = new DevExpress.XtraBars.BarButtonItem();
            this.btnsend = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Temabtn,
            this.ListBtn,
            this.Jsondatabtn,
            this.skinDropDownButtonItem1,
            this.lıstSkın,
            this.barButtonItem1,
            this.jsonpathwiew,
            this.barSubItem1,
            this.barButtonGroup1,
            this.barButtonItem2,
            this.JsonviewLogs,
            this.btnlogsjs,
            this.btnjsoncreate,
            this.Jsoncreateandread,
            this.FileView,
            this.btnsend});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(701, 141);
            // 
            // Temabtn
            // 
            this.Temabtn.Id = 1;
            this.Temabtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Temabtn.ImageOptions.Image")));
            this.Temabtn.Name = "Temabtn";
            // 
            // ListBtn
            // 
            this.ListBtn.Caption = "Kişiler";
            this.ListBtn.Id = 2;
            this.ListBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListBtn.ImageOptions.Image")));
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ListBtn_ItemClick);
            // 
            // Jsondatabtn
            // 
            this.Jsondatabtn.Id = 3;
            this.Jsondatabtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Jsondatabtn.ImageOptions.Image")));
            this.Jsondatabtn.Name = "Jsondatabtn";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 4;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // lıstSkın
            // 
            this.lıstSkın.Caption = "Temalar";
            this.lıstSkın.Id = 5;
            this.lıstSkın.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lıstSkın.ImageOptions.Image")));
            this.lıstSkın.Name = "lıstSkın";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Json Verileri";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // jsonpathwiew
            // 
            this.jsonpathwiew.Caption = "Person Json Verileri";
            this.jsonpathwiew.Id = 7;
            this.jsonpathwiew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("jsonpathwiew.ImageOptions.Image")));
            this.jsonpathwiew.Name = "jsonpathwiew";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 8;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 9;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // JsonviewLogs
            // 
            this.JsonviewLogs.Caption = "barButtonGroup2";
            this.JsonviewLogs.Id = 11;
            this.JsonviewLogs.Name = "JsonviewLogs";
            // 
            // btnlogsjs
            // 
            this.btnlogsjs.Caption = "Logs Json Verileri";
            this.btnlogsjs.Id = 12;
            this.btnlogsjs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlogsjs.ImageOptions.Image")));
            this.btnlogsjs.Name = "btnlogsjs";
            // 
            // btnjsoncreate
            // 
            this.btnjsoncreate.Caption = "Json Dosyası Oluşturma Ve Okuma";
            this.btnjsoncreate.Id = 13;
            this.btnjsoncreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnjsoncreate.ImageOptions.Image")));
            this.btnjsoncreate.Name = "btnjsoncreate";
            // 
            // Jsoncreateandread
            // 
            this.Jsoncreateandread.Caption = "Dosya Görüntüleme";
            this.Jsoncreateandread.Id = 14;
            this.Jsoncreateandread.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Jsoncreateandread.ImageOptions.Image")));
            this.Jsoncreateandread.Name = "Jsoncreateandread";
            // 
            // FileView
            // 
            this.FileView.Caption = "Dosya Görüntüleme";
            this.FileView.Id = 15;
            this.FileView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FileView.ImageOptions.Image")));
            this.FileView.Name = "FileView";
            this.FileView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FileView_ItemClick);
            // 
            // btnsend
            // 
            this.btnsend.Caption = "Mail Gönder";
            this.btnsend.Id = 16;
            this.btnsend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsend.ImageOptions.Image")));
            this.btnsend.Name = "btnsend";
            this.btnsend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsend_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ListBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.FileView);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnsend);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ayarlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.lıstSkın);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 404);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Kayıt Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Temabtn;
        private DevExpress.XtraBars.BarButtonItem ListBtn;
        private DevExpress.XtraBars.BarButtonItem Jsondatabtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarSubItem lıstSkın;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem jsonpathwiew;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonGroup JsonviewLogs;
        private DevExpress.XtraBars.BarButtonItem btnlogsjs;
        private DevExpress.XtraBars.BarButtonItem btnjsoncreate;
        private DevExpress.XtraBars.BarButtonItem Jsoncreateandread;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem FileView;
        private DevExpress.XtraBars.BarButtonItem btnsend;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}