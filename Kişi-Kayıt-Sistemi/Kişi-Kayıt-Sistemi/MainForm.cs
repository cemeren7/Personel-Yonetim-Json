using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using System.Linq;
using DevExpress.LookAndFeel;
using System;
using DevExpress.UserSkins;
using DevExpress.Skins;
namespace Kişi_Kayıt_Sistemi
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
            UserLookAndFeel.Default.StyleChanged += default_style;
        }
        private void default_style(object sender, EventArgs e)
        {
            string secilenTema = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.AppTheme = secilenTema;
            Properties.Settings.Default.Save();
        }
        private void ListBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var controlForm = documentManager1.View.Documents.FirstOrDefault(c => c.Form is KısıLıst);
            if (controlForm != null)
            {
                documentManager1.View.ActivateDocument(controlForm.Form);
            }
            else
            {
                KısıLıst Home = new KısıLıst();
                Home.MdiParent = this;
                Home.Show();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = XtraMessageBox.Show("Çıkmak İstediginize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }       
        private void MainForm_Load(object sender, EventArgs e)
        {
            BonusSkins.Register(); 
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            SkinHelper.InitSkinPopupMenu(lıstSkın); 
            UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.AppTheme);
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode==Keys.F11)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            if (e.Alt && e.KeyCode==Keys.F11)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (e.Control && e.KeyCode==Keys.K)
            {
                ListBtn.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.O)
            {
                FileView.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.M)
            {
                btnsend.PerformClick();
            }
        }
        private void FileView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var controlForm = documentManager1.View.Documents.FirstOrDefault(c => c.Form is FileView);
            if (controlForm != null)
            {
                documentManager1.View.ActivateDocument(controlForm.Form);
            }
            else
            {
                FileView jsc = new FileView();
                jsc.MdiParent = this;
                jsc.Show();
            }
        }
        private void btnsend_ItemClick(object sender, ItemClickEventArgs e)
        {
            var controlForm = documentManager1.View.Documents.FirstOrDefault(c => c.Form is Mailcontrol);
            if (controlForm != null)
            {
                documentManager1.View.ActivateDocument(controlForm.Form);
            }
            else
            {
                Mailcontrol mail = new Mailcontrol();
                mail.MdiParent = this;
                mail.Show();
            }
        }
    }
}