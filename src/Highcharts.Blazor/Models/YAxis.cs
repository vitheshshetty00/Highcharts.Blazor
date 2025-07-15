
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models
{
    public class YAxis
    {
        [JsonPropertyName("title")]
        public Title? Title { get; set; }

        [JsonPropertyName("min")]
        public double? Min { get; set; }

        [JsonPropertyName("labels")]
        public Labels? Labels { get; set; }

        [JsonPropertyName("className")]
        public string? ClassName { get; set; }

        [JsonPropertyName("max")]
        public double? Max { get; set; }

        [JsonPropertyName("lineWidth")]
        public int? LineWidth { get; set; }

        [JsonPropertyName("tickPositions")]
        public List<object>? TickPositions { get; set; }

        [JsonPropertyName("gridLineColor")]
        public string? GridLineColor { get; set; }

        [JsonPropertyName("stops")]
        public List<object>? Stops { get; set; }

        [JsonPropertyName("categories")]
        public List<string>? Categories { get; set; }

        [JsonPropertyName("lineColor")]
        public string? LineColor { get; set; }

        [JsonPropertyName("plotLines")]
        public List<PlotLine>? PlotLines { get; set; }

        [JsonPropertyName("gridLineWidth")]
        public int? GridLineWidth { get; set; }

        public YAxis()
        {
            Title = new Title();
            Labels = new Labels();
            ClassName = null;
        }

        public YAxis(Title? title = null, Labels? labels = null, string? className = null)
        {
            Title = title;
            Labels = labels;
            ClassName = className;
        }
    }
}
