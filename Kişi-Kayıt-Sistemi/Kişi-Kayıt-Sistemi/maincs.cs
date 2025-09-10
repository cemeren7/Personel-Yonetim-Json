
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace Kişi_Kayıt_Sistemi
{
    public static class main
    {
        public static string jsonPath = Path.Combine(Application.StartupPath, "Veriler.json");
        public static string jsonPathLog = Path.Combine(Application.StartupPath, "Logs.json");
        public static List<Person> Personeller = new List<Person>();
        public static List<Models.LogModel> Logs = new List<Models.LogModel>();
    }
}
