using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Net.Mime;
namespace Kişi_Kayıt_Sistemi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);         
            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show("UI Thread Hatası: " + e.Exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string methodName = new StackTrace(e.Exception, true).GetFrames()?.FirstOrDefault(f => f.GetMethod()?.DeclaringType?.Namespace?.StartsWith("System") == false)?.GetMethod()?.Name ?? "Bilinmiyor";
                string hostname = Dns.GetHostName();
                string ıp = Dns.GetHostByName(hostname).AddressList[0].ToString();
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true, 
                    UseDefaultCredentials = false,  
                    Credentials = new NetworkCredential("cemeren660@gmail.com", "qmdqcdapdvaovqbf"),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                MailMessage mail = new MailMessage
                {
                    IsBodyHtml = true, 
                    From = new MailAddress("cemeren660@gmail.com"), 
                    Subject = "Kişi Kayıt Sistemi Hata Kaydı", 
                    Body = @"<p><b>Uygulama Adı: </b>" + Application.ProductName + "</p><hr>" + "<p><b>Uygulama Versiyonu:   </b>"
                    + Application.ProductVersion + "</p><hr>" + "<p><b>Hata Başlıgı:  </b>" + e.Exception.Message + "</p><hr>" + "<p><b>Hata Saati Ve Tarihi:   </b>"
                    + DateTime.Now + "</p><hr>" + "<p><b>Hata Veren Pc Name:  </b> "
                    + Environment.MachineName + "</p><hr>" + "<p><b>Hata Detayları:  </b>"
                    + e.Exception.ToString() + "</p><hr>" + "<p><b>Hata Veren satır Bilgisi:  </b>"
                    + e.Exception.StackTrace + "</p><hr>" + "<p><b>Hat Veren Method:  </b>"
                    + methodName + "</p><hr>" + "<p><b>Hata Veren İp: </b>" + ıp + "</p><hr>",
                };
                // İstege Baglıdır.
                //Attachment file = new Attachment(@"C:\Users\Lenovo\Desktop\GitHub Dosyaları\Kişi-Kayıt-Sistemi\Kişi-Kayıt-Sistemi\Resim-Hata\hata.png", MediaTypeNames.Image.Jpeg);
                //mail.Attachments.Add(file);
                mail.To.Add("cemeren660@gmail.com"); 
                Task.Run(()=> client.Send(mail)); 
                MessageBox.Show("Hata Bilgileri Mail Olarak İletildi");
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = (Exception)e.ExceptionObject;
                Exception hata = ex.InnerException ?? ex;
                MessageBox.Show("Non-UI Thread Hatası: " + hata.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string methodName = new StackTrace(hata, true).GetFrames()?.FirstOrDefault(f => f.GetMethod()?.DeclaringType?.Namespace?.StartsWith("System") == false)?.GetMethod()?.Name ?? "Bilinmiyor";
                string hostname = Dns.GetHostName();
                string ıp = Dns.GetHostByName(hostname).AddressList[0].ToString();
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("cemeren660@gmail.com", "qmdqcdapdvaovqbf"),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                MailMessage mail = new MailMessage
                {
                    IsBodyHtml = true,
                    From = new MailAddress("cemeren660@gmail.com"),
                    Subject = "Kişi Kayıt Sistemi Hata Kaydı",
                    Body = @"<p><b>Uygulama Adı: </b>" + Application.ProductName + "</p><hr>" + "<p><b>Uygulama Versiyonu:   </b>"
                    + Application.ProductVersion + "</p><hr>" + "<p><b>Hata Başlıgı:  </b>" + hata.Message + "</p><hr>" + "<p><b>Hata Saati Ve Tarihi:   </b>"
                    + DateTime.Now + "</p><hr>" + "<p><b>Hata Veren Pc Name:  </b> "
                    + Environment.MachineName + "</p><hr>" + "<p><b>Hata Detayları:  </b>"
                    + hata.ToString() + "</p><hr>" + "<p><b>Hata Veren satır Bilgisi:  </b>"
                    + hata.StackTrace + "</p><hr>" + "<p><b>Hat Veren Method:  </b>"
                    + methodName + "</p><hr>" + "<p><b>Hata Veren İp: </b>" + ıp + "</p><hr>",
                };
                //Attachment file = new Attachment(@"C:\Users\Lenovo\Desktop\GitHub Dosyaları\Kişi-Kayıt-Sistemi\Kişi-Kayıt-Sistemi\Resim-Hata\hata.png", MediaTypeNames.Image.Jpeg);
                //mail.Attachments.Add(file);
                mail.To.Add("cemeren660@gmail.com");
                Task.Run(() => client.Send(mail));
                MessageBox.Show("Hata Bilgileri Mail Olarak İletildi");
            };
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.Run(new MainForm());
        }    
    }
}
