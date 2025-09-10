
using System.Windows.Forms;
namespace Kişi_Kayıt_Sistemi
{
    public partial class FileView : DevExpress.XtraEditors.XtraForm
    {
        public FileView()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private void FileOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "Default.docx";
            open.Filter = "Word Belgeleri (*.docx;*.doc;*.dotx;*.dot)|*.docx;*.doc;*.dotx;*.dot|" +
              "Rich Text Format (*.rtf)|*.rtf|" +
              "OpenDocument Text (*.odt)|*.odt|" +
              "Web Sayfaları (*.html;*.htm;*.mht)|*.html;*.htm;*.mht|" +
              "Metin Dosyaları (*.txt)|*.txt|" +
              "Tüm Dosyalar (*.*)|*.*";
            open.InitialDirectory = @"C:\";
            open.Title = "Dosya Aç";
            open.FilterIndex = 6;
            DialogResult Cevap = open.ShowDialog();
            if (Cevap==DialogResult.OK)
            {
                fileviewtool.LoadDocument(open.FileName);
            }
        }
        private void FileClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void FileView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.Control && e.KeyCode==Keys.O)
            {
                FileOpen.PerformClick();
            }
        }
        private void FileView_Shown(object sender, System.EventArgs e)
        {
            fileviewtool.Text = "Açılan Dosyadaki Degişiklikleri Kaydetmek İçin CTRL + S Kısayolunu Kullanın.  " +
                ".RTF.ODT.TXT.DOCX.HTML uzantılı Dosyalar açılabilir.";
        }
    }
}