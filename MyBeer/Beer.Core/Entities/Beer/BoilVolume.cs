using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beer.Core.Entities.Beer
{
    public class BoilVolume
    {
        //[JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

}
