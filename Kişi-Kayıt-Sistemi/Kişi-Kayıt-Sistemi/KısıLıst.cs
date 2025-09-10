
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.Export;
namespace Kişi_Kayıt_Sistemi
{
    public partial class KısıLıst : XtraForm
    {
        public KısıLıst()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            KeyPreview = true; 
        }
        private void RefreshDataList()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = personBindingSource.DataSource = main.Personeller;
        } 
        private void KısıLıst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                btnekle.PerformClick();
            }
            if (e.KeyCode==Keys.F5)
            {
                BtnYenıle.PerformClick();
            }
            if (e.KeyCode==Keys.F4)
            {
                btnduzenle.PerformClick();
            }
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode==Keys.Delete)
            {
                btnsil.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.X)
            {
                BtnExcel.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.P)
            {
                pdfBtn.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.H)
            {
                BtnHtml.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.W)
            {
                BtnWord.PerformClick();
            }
            if (e.KeyCode==Keys.Tab)
            {
                LogBtn.PerformClick();
            }
            if (e.Control && e.KeyCode==Keys.A)
            {
                BtnCopyAll.PerformClick();
            }
            if (e.Shift && e.KeyCode==Keys.Home)
            {
                BtnCopy.PerformClick();
            }
        } 
        private void KısıLıst_Shown(object sender, EventArgs e)
        {
            toolscs.dataloadPerson();
            toolscs.dataloadlogs();
            gridControl1.DataSource = personBindingSource.DataSource = main.Personeller;
            gridView1.Columns["KayitTarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            gridView1.Columns["DuzeltTarih"].DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.RestoreLayoutFromXml("GridPerson.xml");
            gridView1.BestFitMaxRowCount = -1;
            gridView1.BestFitColumns();
        }   
        private void btnekle_Click(object sender, EventArgs e)
        {
            new KısıEdıt().showDialog();
            toolscs.dataloadPerson();
            gridControl1.DataSource = personBindingSource.DataSource = main.Personeller;

            if (main.Personeller.Any())
            {
                int focus = main.Personeller.LastOrDefault().Id;
                int rowhandle = gridView1.LocateByValue("Id", focus);
                if (rowhandle>=0)
                {
                 gridView1.SelectRow(rowhandle);
                 gridView1.FocusedRowHandle = rowhandle;
                }      
            }
        }
        private void BtnYenıle_Click(object sender, EventArgs e)
        {
            RefreshDataList();
            gridView1.BestFitMaxRowCount = -1;
            gridView1.Columns["Phone"].BestFit();
            gridView1.BestFitColumns();
        }
        private void btnduzenle_Click(object sender, EventArgs e)
        {
            int cellval = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            new KısıEdıt().showDialog(gridView1.GetValueInt(0));
            toolscs.dataloadPerson();
            gridControl1.DataSource = personBindingSource.DataSource = main.Personeller;

            if (cellval>0)
            {
                int focusrow = gridView1.LocateByValue("Id", cellval);
                if (focusrow>=0)
                {
                    gridView1.FocusedRowHandle = focusrow;
                    gridView1.SelectRow(focusrow);
                }
            }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int rowId = gridView1.GetValueInt();
                var index = main.Personeller.FindIndex(k => k.Id == rowId);
                if (index >= 0)
                {
                    DialogResult cevap = XtraMessageBox.Show("Silmek İstediginize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (cevap == DialogResult.Yes)
                    {
                        main.Logs.RemoveAll(k => k.FieldId == rowId);
                        main.Logs.SaveLogs();
                        main.Personeller.RemoveAt(index);
                        Task.Run(() => main.Personeller.Save());
                        RefreshDataList();
                        if (main.Personeller.Any())
                        {
                            try
                            {
                                if (main.Personeller.Count() > 1)
                                {
                                    if (index == 0)
                                    {
                                        if (main.Personeller.Count == 2)
                                        {
                                            index++;
                                        }
                                    }
                                    gridView1.FocusedRowHandle = index;
                                    gridView1.MakeRowVisible(index);
                                }
                            }
                            catch (Exception)
                            {
                                int lastindex = main.Personeller.Count -1;
                                gridView1.FocusedRowHandle = lastindex;
                                gridView1.MakeRowVisible(lastindex);
                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Silinecek Kayıt Bulunamadı ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("Silinecek Veri Bulunamadı Lütfen Kayıt Oluşturun. ","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LogBtn_Click(object sender, EventArgs e)
        {
            new LogList().showDialogLog(gridView1.GetValueInt(0));
        } 
        private void eklebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnekle.PerformClick();
        }
        private void Btnsıl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnsil.PerformClick();
        }
        private void Btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnduzenle.PerformClick();
        }
        private void Btnlogs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LogBtn.PerformClick();
        }
        private void pdfBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (main.Personeller.Any())
            {
                SaveFileDialog saveone = new SaveFileDialog();
                saveone.FileName = "Person.pdf";
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
                       Title = "Person Raporu",
                       Subject = "Person Verileri",
                       Author = Environment.MachineName,
                       Producer = "Visual Studio 2019",
                       Application = "Kişi Kayıt Sistemi",
                       Keywords = "Person,Pdf,Devexpress,Windows Form",
                    },
                        ImageQuality = PdfJpegImageQuality.High,
                    };
                    lin.CreateDocument();
                    lin.ExportToPdf(saveone.FileName, pdf);
                    XtraMessageBox.Show("Veriler Başarılı Bir Şekilde Aktarıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }         
            }
            else
            {
                XtraMessageBox.Show("Veri Eklemeden Dışarı Aktarma Yapılamaz Lütfen Veri Girin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (main.Personeller.Any())
            {
            SaveFileDialog saveone = new SaveFileDialog();
            saveone.FileName = "Person.xlsx";
            saveone.Filter = "Excel Files (*.xlsx)|*.xlsx|Tüm Dosyalar (*.*)|*.*";
            saveone.Title = "Excel Dosyası Kaydet";
            saveone.InitialDirectory = @"C:\";
            if (saveone.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                gridView1.Columns["DuzeltTarih"].Width = 111;
                var ec = new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG,
                    SheetName = $"Person",
                    TextExportMode = TextExportMode.Value,
                };
                gridView1.ExportToXlsx(saveone.FileName, ec);
                XtraMessageBox.Show("Veriler Başarılı Bir Şekilde Aktarıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            else
            {
                XtraMessageBox.Show("Veri Eklemeden Dışarı Aktarma Yapılamaz Lütfen Veri Girin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }
        private void BtnHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (main.Personeller.Any())
            {
            SaveFileDialog savehmtl = new SaveFileDialog();
            savehmtl.Title = "Html Dosyası Kaydet";
            savehmtl.FileName = "Person.html";
            savehmtl.Filter = "HTML Dosyaları (*.html)|*.html|Tüm Dosyalar (*.*)|*.*";
            savehmtl.InitialDirectory = @"C:\";
            if (savehmtl.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                var optionshtml = new HtmlExportOptions
                {
                    Title = "Person Verileri",
                    ExportMode = HtmlExportMode.SingleFile,
                    CharacterSet = "UTF-8",                 
                };
                gridView1.ExportToHtml(savehmtl.FileName, optionshtml);
                XtraMessageBox.Show("Veriler Başarılı Bir Şekilde Aktarıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            else
            {
                XtraMessageBox.Show("Veri Eklemeden Dışarı Aktarma Yapılamaz Lütfen Veri Girin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }
        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (main.Personeller.Any())
            {
            SaveFileDialog savehmtl = new SaveFileDialog();
            savehmtl.Title = "Word Dosyası Kaydet";
            savehmtl.FileName = "Person.docx";
            savehmtl.Filter = "WORD Dosyaları (*.docx)|*.docx|Tüm Dosyalar (*.*)|*.*";
            savehmtl.InitialDirectory = @"C:\";
            if (savehmtl.ShowDialog() == DialogResult.OK)
            {
                gridView1.BestFitColumns();
                gridView1.OptionsPrint.AutoWidth = false;
                var Op = new DocxExportOptions()
                {
                    DocumentOptions = { Author = Environment.MachineName, Title = "Person Verileri" },
                    ExportMode = DocxExportMode.SingleFilePageByPage,
                };
                gridView1.ExportToDocx(savehmtl.FileName, Op);
                XtraMessageBox.Show("Veriler Başarılı Bir Şekilde Aktarıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            else
            {
                XtraMessageBox.Show("Veri Eklemeden Dışarı Aktarma Yapılamaz Lütfen Veri Girin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
        }
        private void BtnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CopyToClipboard();
            XtraMessageBox.Show("Panoya Kopyalandı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void BtnCopyAll_Click(object sender, EventArgs e)
        {
            if (main.Personeller.Any())
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
                gridView1.CopyToClipboard();
                XtraMessageBox.Show("Panoya Kopyalandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen Veri Giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnduzenle.PerformClick();
        }
        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var him = gridView1;
                var rowhit = him.CalcHitInfo(e.Location);
                if (rowhit.InRow || rowhit.InRowCell)
                {
                    him.FocusedRowHandle = rowhit.RowHandle;
                    him.ClearSelection();
                    him.SelectRow(rowhit.RowHandle);
                    Point ps = gridControl1.PointToScreen(e.Location);
                    popupMenu1.ShowPopup(ps);
                }
            }
        }
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnduzenle.PerformClick();
            }
        }
        private void KısıLıst_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.SaveLayoutToXml("GridPerson.xml");
        }
    }   
}
