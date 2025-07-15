
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models
{
    public class Subtitle
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("style")]
        public object? Style { get; set; }
    }
}
