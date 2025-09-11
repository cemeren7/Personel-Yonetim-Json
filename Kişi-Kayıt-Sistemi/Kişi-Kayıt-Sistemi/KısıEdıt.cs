using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
namespace Kişi_Kayıt_Sistemi
{
    public partial class KısıEdıt : XtraForm
    {
        public KısıEdıt()
        {
            InitializeComponent();
            KeyPreview = true;
        }   
        public int Idadd()
        {
            if (main.Logs.Any())
                return main.Logs.Max(x => x.Id) + 1;
            else
                return 0;         
        }
        public int id = 0;
        List<Person> Kişiler = new List<Person>();
        private void KısıEdıt_Shown(object sender, EventArgs e)
        {            
                if (id > 0)
                {
                    var temp = main.Personeller.Where(c => c.Id == id).ToList();
                    Kişiler = new List<Person>
                { new Person
                {
                     Id = temp.FirstOrDefault().Id,
                     FullName = temp[0].FullName,
                     Phone = temp[0].Phone,
                     Email = temp[0].Email,
                     Aciklama = temp[0].Aciklama,
                     KayitTarih = temp[0].KayitTarih,
                     DuzeltTarih = temp[0].DuzeltTarih,
                }
                };
                }
                else
                {
                    int yenııd = 1;
                    if (main.Personeller.Any())
                    {
                        yenııd = main.Personeller.Max(c => c.Id) + 1;
                    }
                    Kişiler.Add(new Person
                    {
                        Id = yenııd,
                    });
                }
                bindingSource1.DataSource = Kişiler;         
        }
        private void KısıEdıt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BtnCancel.PerformClick();
            }
            if (e.KeyCode==Keys.Enter)
            {
                BtnKaydet.PerformClick();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            if (txtAdSoyad.Text.Trim() == "")
            {
                MessageBox.Show("Ad Soyad Alanı Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (id > 0)
                {
                    var index = main.Personeller.FindIndex(c => c.Id == id);
                    if (index >= 0)
                    {
                        Kişiler[0].DuzeltTarih = DateTime.Now;
                        Kişiler[0].Duzelten = Environment.MachineName;
                        if (Kişiler[0].FullName != main.Personeller[index].FullName)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].FullName;
                            logModel.NewValueFieldId = Kişiler[0].FullName;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "FullName";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = toolscs.getIp();
                            main.Logs.Add(logModel);
                        }
                        if (Kişiler[0].Phone != main.Personeller[index].Phone)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].Phone;
                            logModel.NewValueFieldId = Kişiler[0].Phone;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "Phone";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = toolscs.getIp();
                            main.Logs.Add(logModel);
                        }
                        if (Kişiler[0].Email != main.Personeller[index].Email)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].Email;
                            logModel.NewValueFieldId = Kişiler[0].Email;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "Email";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = toolscs.getIp();
                            main.Logs.Add(logModel);
                        }
                        if (Kişiler[0].Aciklama != main.Personeller[index].Aciklama)
                        {
                            Models.LogModel logModel = new Models.LogModel();
                            logModel.Id = Idadd();
                            logModel.OldValueFieldId = main.Personeller[index].Aciklama;
                            logModel.NewValueFieldId = Kişiler[0].Aciklama;
                            logModel.FieldId = Kişiler[0].Id;
                            logModel.TableName = "Person";
                            logModel.FieldName = "Aciklama";
                            logModel.PC = Environment.MachineName;
                            logModel.ChangeDate = DateTime.Now;
                            logModel.LocalIp = toolscs.getIp();
                            main.Logs.Add(logModel);
                        }
                        main.Logs.SaveLogs();
                        main.Personeller[index] = Kişiler[0];
                        Task.Run(() => main.Personeller.Save());
                    }
                }
                else
                {
                    main.Personeller.AddRange(Kişiler);
                    Task.Run(() => main.Personeller.Save());
                }
                this.Close();
            }
        }
    }
}
