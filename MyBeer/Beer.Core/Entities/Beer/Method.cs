using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beer.Core.Entities.Beer
{
    public class Method
    {
        [JsonPropertyName("mash_temp")]
        public List<MashTemp> MashTemp { get; set; }

        [JsonPropertyName("fermentation")]
        public Fermentation Fermentation { get; set; }

        [JsonPropertyName("twist")]
        public string Twist { get; set; }
    }
    public class MashTemp
    {
        [JsonPropertyName("temp")]
        public Temp Temp { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }
    }
    public class Fermentation
    {
        [JsonPropertyName("temp")]
        public Temp Temp { get; set; }
    }
    public class Temp
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
