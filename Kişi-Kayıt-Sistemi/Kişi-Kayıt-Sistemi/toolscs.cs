using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
namespace Kişi_Kayıt_Sistemi
{
    public static class toolscs
    {
        public static void Save(this List<Person>  value)
        {
            string yenıdosya = JsonConvert.SerializeObject(main.Personeller, Formatting.Indented);
            File.WriteAllText(main.jsonPath, yenıdosya);
        }
        public static void SaveLogs(this List<Models.LogModel> value)
        {
            string yenıdosyalog = JsonConvert.SerializeObject(main.Logs, Formatting.Indented);
            File.WriteAllText(main.jsonPathLog, yenıdosyalog);
        }
        public static int GetValueInt(this GridView view ,int cell=0)
        {
            int rowHandle = view.FocusedRowHandle;
            string column = view.Columns[cell].FieldName;
            var value = view.GetRowCellValue(rowHandle, column);
            return Convert.ToInt32(value);
        }
        public static void showDialog(this KısıEdıt form,int id=0)
        {
            form.id = id;
            form.ShowDialog();
        }
        public static void showDialogLog(this LogList form, int id = 0)
        {
            form.Logid = id;
            form.ShowDialog();
        }
        public static void dataloadPerson()
        {
            string jsonpth = File.ReadAllText(main.jsonPath);
            main.Personeller = JsonConvert.DeserializeObject<List<Person>>(jsonpth);
        }
        public static void dataloadlogs()
        {
            string jsonlog = File.ReadAllText(main.jsonPathLog);
            main.Logs = JsonConvert.DeserializeObject<List<Models.LogModel>>(jsonlog);
        }
        public static string getIp()
        {
            var GetHos = Dns.GetHostEntry(Dns.GetHostName());
            var ıpget = GetHos.AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            return ıpget.ToString();
        }
    }
}
