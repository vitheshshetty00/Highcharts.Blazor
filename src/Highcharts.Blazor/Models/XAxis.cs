
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models
{
    public class XAxis
    {
        [JsonPropertyName("accessibility")]
        public Accessibility? Accessibility { get; set; }

        [JsonPropertyName("allowDecimals")]
        public bool? AllowDecimals { get; set; }

        [JsonPropertyName("startOnTick")]
        public bool? StartOnTick { get; set; }

        [JsonPropertyName("endOnTick")]
        public bool? EndOnTick { get; set; }

        [JsonPropertyName("showLastLabel")]
        public bool? ShowLastLabel { get; set; }

        [JsonPropertyName("tickPositions")]
        public List<double?>? TickPositions { get; set; }

        [JsonPropertyName("categories")]
        public List<object>? Categories { get; set; }

        [JsonPropertyName("minTickInterval")]
        public double? MinTickInterval { get; set; }

        [JsonPropertyName("tickInterval")]
        public double? TickInterval { get; set; }

        [JsonPropertyName("minRange")]
        public int? MinRange { get; set; }

        [JsonPropertyName("min")]
        public int? Min { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }

        [JsonPropertyName("tickmarkPlacement")]
        public string? TickmarkPlacement { get; set; }

        [JsonPropertyName("labels")]
        public Labels? Labels { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("title")]
        public Title? Title { get; set; }

        [JsonPropertyName("plotLines")]
        public List<PlotLine>? PlotLines { get; set; }

        [JsonPropertyName("gridLineColor")]
        public string? GridLineColor { get; set; }

        [JsonPropertyName("lineColor")]
        public string? LineColor { get; set; }

        [JsonPropertyName("gridLineWidth")]
        public int? GridLineWidth { get; set; }

        [JsonPropertyName("lineWidth")]
        public int? LineWidth { get; set; }

        public XAxis() { }

        public XAxis(Accessibility? accessibility = null, bool? allowDecimals = null, bool? startOnTick = null, 
            bool? endOnTick = null, bool? showLastLabel = null, Labels? labels = null, string? type = null, Title? title = null)
        {
            Accessibility = accessibility;
            AllowDecimals = allowDecimals;
            StartOnTick = startOnTick;
            EndOnTick = endOnTick;
            ShowLastLabel = showLastLabel;
            Labels = labels;
            Type = type;
            Title = title;
        }

        public XAxis(string? type = null)
        {
            Type = type;
        }
    }
}
