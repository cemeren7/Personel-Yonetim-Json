using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Kişi_Kayıt_Sistemi
{
    public partial class LogList : XtraForm
    {
        public LogList()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        public int Logid = 0;
        List<Models.LogModel> LogsFilter = new List<Models.LogModel>();
        private void LogList_Load(object sender, EventArgs e)
        {
            if (Logid > 0)
            {
                var LogsList = main.Logs.Where(x => x.FieldId == Logid).ToList();
                if (LogsList.Any())
                {
                    LogsFilter = LogsList.OrderByDescending(f => f.Id).ToList();
                    gridControl1.DataSource = logModelBindingSource.DataSource = LogsFilter;
                    gridView1.Columns["ChangeDate"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
                    gridView1.FocusedRowHandle = 0;
                    gridView1.OptionsView.ColumnAutoWidth = false;
                    gridView1.OptionsBehavior.Editable = false;
                    gridView1.BestFitMaxRowCount = -1;
                    gridView1.BestFitColumns();
                }
                else
                {
                    BeginInvoke((Action)(() =>
                    {
                        XtraMessageBox.Show("Log Kaydı Bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }));
                }
            }
            else
            {
                BeginInvoke((Action)(() =>
                {
                    XtraMessageBox.Show("Lütfen Geçerli Bir Veri Şeçiniz. Veya Kayıt Oluşturunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }));
            }
        }
        private void LogList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.Control && e.KeyCode==Keys.P)
            {
                btnPdf.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.H)
            {
                btnHtml.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.W)
            {
                btnWord.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.X)
            {
                btnExcel.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.A)
            {
                btncopyall.PerformClick();
            }
        }
        private void LogList_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.SaveLayoutToXml("LogGrid.xml");
        }
        private void LogList_Shown(object sender, EventArgs e)
        {
            gridView1.RestoreLayoutFromXml("LogGrid.xml");
        }
        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveone = new SaveFileDialog();
            saveone.FileName = "Logs.pdf";
            saveone.Filter = "Pdf Files (*.pdf)|*.pdf|Tüm Dosyalar (*.*)|*.*";
            saveone.Title = "Pdf Dosyası Kaydet";
            saveone.InitialDirectory = @"C:\";
            if (saveone.ShowDialog() == DialogResult.OK)
            {
                PrintingSystem print = new PrintingSystem();
                print.PageSettings.Landscape = true;
                PrintableComponentLink lin = new PrintableComponentLink(print)
                {
                    Component = gridView1.GridControl,
                    Landscape = true,
                    PaperKind = System.Drawing.Printing.PaperKind.A3,
                };
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                var pdf = new PdfExportOptions
                {
                    DocumentOptions =
                    {
                       Title = "Log Raporu",
                       Subject = "Log Kayıtları",
                       Author = Environment.MachineName,
                       Producer = "Visual Studio 2019",
                       Application = "Kişi Kayıt Sistemi",
                       Keywords = "Log,Pdf,Devexpress,Windows Form",
                    },
                    ImageQuality = PdfJpegImageQuality.High,
                };
                lin.CreateDocument();
                lin.ExportToPdf(saveone.FileName, pdf);
                XtraMessageBox.Show("Dosya Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveone = new SaveFileDialog();
            saveone.FileName = "Log.xlsx";
            saveone.Filter = "Excel Files (*.xlsx)|*.xlsx|Tüm Dosyalar (*.*)|*.*";
            saveone.Title = "Excel Dosyası Kaydet";
            saveone.InitialDirectory = @"C:\";
            if (saveone.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                var ec = new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG,
                    SheetName = $"Log",
                    TextExportMode = TextExportMode.Value,
                };
                gridView1.ExportToXlsx(saveone.FileName, ec);
                XtraMessageBox.Show("Dosya Kaydetme Tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog savehmtl = new SaveFileDialog();
            savehmtl.Title = "Html Dosyası Kaydet";
            savehmtl.FileName = "Log.html";
            savehmtl.Filter = "HTML Dosyaları (*.html)|*.html|Tüm Dosyalar (*.*)|*.*";
            savehmtl.InitialDirectory = @"C:\";
            if (savehmtl.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                var optionshtml = new HtmlExportOptions
                {
                    Title = "Log Kayıtları",
                    ExportMode = HtmlExportMode.SingleFile,
                    CharacterSet = "UTF-8",
                };
                gridView1.ExportToHtml(savehmtl.FileName, optionshtml);
                XtraMessageBox.Show("Dosya Kaydetme Tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog savehmtl = new SaveFileDialog();
            savehmtl.Title = "Word Dosyası Kaydet";
            savehmtl.FileName = "Log.docx";
            savehmtl.Filter = "WORD Dosyaları (*.docx)|*.docx|Tüm Dosyalar (*.*)|*.*";
            savehmtl.InitialDirectory = @"C:\";
            if (savehmtl.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                var Op = new DocxExportOptions()
                {
                    DocumentOptions = { Author = Environment.MachineName, Title = "Log Kayıtları" },
                    ExportMode = DocxExportMode.SingleFilePageByPage,
                };
                gridView1.ExportToDocx(savehmtl.FileName, Op);
                XtraMessageBox.Show("Dosya Kaydetme Tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btncopyall_Click(object sender, EventArgs e)
        {
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.SelectAll();
            gridView1.CopyToClipboard();
            XtraMessageBox.Show("Panoya Kopyalandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
