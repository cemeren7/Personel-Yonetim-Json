using System;
using Newtonsoft.Json;
namespace Kişi_Kayıt_Sistemi.Models
{
    public class LogModel
    {
        [JsonProperty("ıd")]
        public int Id { get; set; }
        [JsonProperty("changedate")]
        public DateTime ChangeDate { get; set; }
        [JsonProperty("pc")]
        public string PC { get; set; }
        [JsonProperty("tablename")]
        public string TableName { get; set; }
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
        [JsonProperty("fieldıd")]
        public int FieldId { get; set; }
        [JsonProperty("oldvaluefieldıd")]
        public string OldValueFieldId { get; set; }
        [JsonProperty("newvaluefieldıd")]
        public string NewValueFieldId { get; set; }
        [JsonProperty("localıp")]
        public string LocalIp { get; set; }
    }
}
