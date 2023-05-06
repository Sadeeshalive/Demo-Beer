using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Beer.Core.Entities.Beer
{
    public class Beer
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; }

        [JsonPropertyName("first_brewed")]
        public string FirstBrewed { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("abv")]
        public double Abv { get; set; }

        [JsonPropertyName("ibu")]
        public double Ibu { get; set; }

        [JsonPropertyName("target_fg")]
        public int TargetFg { get; set; }

        [JsonPropertyName("target_og")]
        public double TargetOg { get; set; }

        [JsonPropertyName("ebc")]
        public int Ebc { get; set; }

        [JsonPropertyName("srm")]
        public double Srm { get; set; }

        [JsonPropertyName("ph")]
        public double Ph { get; set; }

        [JsonPropertyName("attenuation_level")]
        public double AttenuationLevel { get; set; }

        [JsonPropertyName("volume")]
        public Volume Volume { get; set; }

        [JsonPropertyName("boil_volume")]
        public BoilVolume BoilVolume { get; set; }

        [JsonPropertyName("method")]
        public Method Method { get; set; }

        [JsonPropertyName("ingredients")]
        public Ingredients Ingredients { get; set; }

        [JsonPropertyName("food_pairing")]
        public List<string> FoodPairing { get; set; }

        [JsonPropertyName("brewers_tips")]
        public string BrewersTips { get; set; }

        [JsonPropertyName("contributed_by")]
        public string ContributedBy { get; set; }
    }
}
