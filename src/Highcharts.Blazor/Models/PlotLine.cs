using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class PlotLine
{
    [JsonPropertyName("color")]
    public string? Color { get; set; } = "red";

    [JsonPropertyName("dashStyle")]
    public string? DashStyle { get; set; } = Constants.DashStyle.LongDashDot;

    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; } = 1;

    [JsonPropertyName("zIndex")]
    public int? ZIndex { get; set; } = 5;

    [JsonPropertyName("label")]
    public Label? Label { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    public PlotLine() { }
}
