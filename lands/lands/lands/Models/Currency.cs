using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lands.Models
{
    public class Currency
    {
        // A cada propiedad se le va a colocar un alias

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set;}

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }


    }
}
