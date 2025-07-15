
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models
{
    public class Tooltip
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("shared")]
        public bool? Shared { get; set; }

        [JsonPropertyName("useHTML")]
        public bool? UseHTML { get; set; }

        [JsonPropertyName("pointFormat")]
        public string? PointFormat { get; set; }

        [JsonPropertyName("formatter")]
        public string? Formatter { get; set; }

        [JsonPropertyName("headerFormat")]
        public string? HeaderFormat { get; set; }

        [JsonPropertyName("valuePrefix")]
        public string? ValuePrefix { get; set; }

        [JsonPropertyName("split")]
        public bool? Split { get; set; }

        [JsonPropertyName("distance")]
        public int? Distance { get; set; }

        [JsonPropertyName("padding")]
        public int? Padding { get; set; }

        [JsonPropertyName("valueSuffix")]
        public string? ValueSuffix { get; set; }

        [JsonPropertyName("outside")]
        public bool? Outside { get; set; }

        public Tooltip() { }

        public Tooltip(bool? enabled = null, string? pointFormat = null)
        {
            Enabled = enabled;
            PointFormat = pointFormat;
        }
    }
}
