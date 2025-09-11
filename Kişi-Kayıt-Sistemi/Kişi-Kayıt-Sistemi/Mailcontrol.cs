using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
namespace Kişi_Kayıt_Sistemi
{
    public partial class Mailcontrol : XtraForm
    {
        public Mailcontrol()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        string fileopen;
        string filepath;
        private void Mailcontrol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.Control && e.KeyCode==Keys.O)
            {
                btnfile.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BtnSend.PerformClick();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openmail = new OpenFileDialog();
            openmail.Title = "Mail İçin  Ek Dosya Ekle";
            openmail.FileName = "default.png";
            openmail.InitialDirectory = @"C:\";
            openmail.Filter = "Tüm Desteklenen Dosyalar| *.pdf; *.docx; *.xlsx; *.txt; *.jpg; *.jpeg; *.png; *.zip; *.rar | " +
                              "Belge Dosyaları (*.pdf;*.docx;*.xlsx;*.txt)|*.pdf;*.docx;*.xlsx;*.txt|" +
                              "PDF Dosyaları (*.pdf)|*.pdf|" +
                              "Microsoft Word Dökümanları (*.docx)|*.docx|" +
                              "Microsoft Excel Tabloları (*.xlsx)|*.xlsx|" +
                              "Metin Dosyaları (*.txt)|*.txt|" +
                              "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|" +
                              "Arşiv Dosyaları (*.zip;*.rar;*.7z)|*.zip;*.rar;*.7z|" +
                              "Tüm Dosyalar (*.*)|*.*";
            if (openmail.ShowDialog()==DialogResult.OK)
            {
                fileopen = openmail.FileName;
                filepath = openmail.FileName;
                txtfilepath.Text = filepath;
            }
        }
        private async void BtnSend_Click(object sender, EventArgs e)
        {
            if (txtfrom.Text.Trim() == "" || txtto.Text.Trim() == "" || txthesap.Text.Trim() == "" || txtsıfre.Text.Trim() == "")
            {
                XtraMessageBox.Show("Hesap,Şifre,Gönderen,Gönderilen Alanları Boş Olamaz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(txthesap.Text.Trim(), txtsıfre.Text.Trim()),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(txtfrom.Text.Trim()),
                    Subject = txtcaption.Text.Trim(),
                    Body = txtmesaj.Text.Trim(),
                };
                if (!string.IsNullOrEmpty(fileopen))
                {
                    Attachment fileadd = new Attachment(fileopen);
                    mail.Attachments.Add(fileadd);
                }
                try
                {
                    mail.To.Add(txtto.Text.Trim());
                    await client.SendMailAsync(mail);
                    XtraMessageBox.Show("E-Postanız Başarılı Bir Şekilde İletildi Lüften Gmail Hesabınızı Kontrol Edin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ee)
                {
                    XtraMessageBox.Show($"Mail Gönderimi Sırasında Hata Oluştu Hata: {ee.Message}", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }     
            }
        }
    }
}