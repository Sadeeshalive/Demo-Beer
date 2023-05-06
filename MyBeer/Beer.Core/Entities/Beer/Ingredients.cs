using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beer.Core.Entities.Beer
{
    public class Ingredients
    {
        [JsonPropertyName("malt")]
        public List<Malt> Malt { get; set; }

        [JsonPropertyName("hops")]
        public List<Hop> Hops { get; set; }

        [JsonPropertyName("yeast")]
        public string Yeast { get; set; }
    }
    public class Malt
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public Amount Amount { get; set; }
    }
    public class Hop
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public Amount Amount { get; set; }

        [JsonPropertyName("add")]
        public string Add { get; set; }

        [JsonPropertyName("attribute")]
        public string Attribute { get; set; }
    }
    public class Amount
    {
        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

}
