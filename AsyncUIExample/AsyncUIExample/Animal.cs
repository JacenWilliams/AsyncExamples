using System.Text.Json.Serialization;

namespace AsyncUIExample
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("latin_name")]
        public string LatinName { get; set; }

        [JsonPropertyName("animal_type")]
        public string Type { get; set; }

        [JsonPropertyName("active_time")]
        public string ActiveTime { get; set; }

        [JsonPropertyName("length_min")]
        public double MinLength { get; set; }

        [JsonPropertyName("length_max")]
        public double MaxLength { get; set; }

        [JsonPropertyName("weight_min")]
        public double MinWeight { get; set; }

        [JsonPropertyName("weight_max")]
        public double MaxWeight { get; set; }
        public int Lifespan { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        [JsonPropertyName("geo_range")]
        public string GeoRange { get; set; }

        [JsonPropertyName("image_link")]
        public string ImageLink { get; set; }

    }
}
