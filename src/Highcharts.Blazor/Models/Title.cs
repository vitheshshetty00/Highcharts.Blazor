
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models
{
    public class Title
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("useHTML")]
        public bool? UseHTML { get; set; }

        [JsonPropertyName("verticalAlign")]
        public string? VerticalAlign { get; set; }

        [JsonPropertyName("align")]
        public string? Align { get; set; }

        [JsonPropertyName("floating")]
        public bool? Floating { get; set; }

        [JsonPropertyName("style")]
        public Style? Style { get; set; }

        [JsonPropertyName("y")]
        public double? Y { get; set; }

        [JsonPropertyName("x")]
        public double? X { get; set; }

        [JsonPropertyName("widthAdjust")]
        public double? WidthAdjust { get; set; }

        public Title() { }

        public Title(bool? enabled = null)
        {
            Enabled = enabled;
        }

        public Title(string? text = null)
        {
            Text = text;
        }
    }
}
