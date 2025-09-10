using System;
using Newtonsoft.Json;
namespace Kişi_Kayıt_Sistemi
{
    public class Person 
    {
        [JsonProperty("ıd")]
        public int Id { get; set; } 
        [JsonProperty("fullname")]
        public string FullName { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("kayittarih")]
        public DateTime KayitTarih { get; set; } = DateTime.Now;
        [JsonProperty("kayıteden")]
        public string KayitEden { get; } = Environment.MachineName; 
        [JsonProperty("aciklama")]
        public string Aciklama { get; set;}
        [JsonProperty("duzelttarih")]
        public DateTime DuzeltTarih { get; set; } = DateTime.Now;
        [JsonProperty("duzelten")]
        public string Duzelten { get; set; } = Environment.MachineName;
    }
}
