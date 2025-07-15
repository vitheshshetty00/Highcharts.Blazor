
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models
{
    public class Series
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("data")]
        public List<object>? Data { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
