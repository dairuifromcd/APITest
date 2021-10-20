using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    public class Festival
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bands")]
        public Band[] Bands { get; set; }
    }

    public class Band
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("recordLabel")]
        public string RecordLabel { get; set; }
    }
}
