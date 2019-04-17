using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lands.Models
{
    public class Translations
    {
        [JsonProperty(PropertyName = "de")]
        public string Germany { get; set; }

        [JsonProperty(PropertyName = "es")]
        public string Espanish { get; set; }

        [JsonProperty(PropertyName = "fr")]
        public string French { get; set; }

        [JsonProperty(PropertyName = "ja")]
        public string Japanese { get; set; }

        [JsonProperty(PropertyName = "it")]
        public string Italian { get; set; }

        [JsonProperty(PropertyName = "br")]
        public string Brasilian { get; set; }

        [JsonProperty(PropertyName = "pt")]
        public string Portuges { get; set; }

        [JsonProperty(PropertyName = "nl")]
        public string Duthc { get; set; }

        [JsonProperty(PropertyName = "hr")]
        public string Croatian { get; set; }

        [JsonProperty(PropertyName = "fa")]
        public string Danish { get; set; }
        
    }
}
