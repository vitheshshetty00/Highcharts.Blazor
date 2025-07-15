using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class SeriesElement
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("color")]
    public object? Color { get; set; }

    [JsonPropertyName("fillColor")]
    public object? FillColor { get; set; }

    [JsonPropertyName("fillOpacity")]
    public double? FillOpacity { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    [JsonPropertyName("data")]
    public List<object?>? Data { get; set; }

    [JsonPropertyName("colorByPoint")]
    public bool? ColorByPoint { get; set; }

    [JsonPropertyName("showInLegend")]
    public bool? ShowInLegend { get; set; }

    [JsonPropertyName("lineWidth")]
    public int? LineWidth { get; set; }

    [JsonPropertyName("lineColor")]
    public string? LineColor { get; set; }

    [JsonPropertyName("dashStyle")]
    public string? DashStyle { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("innerSize")]
    public string? InnerSize { get; set; }

    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }

    [JsonPropertyName("stack")]
    public string? Stack { get; set; }

    public SeriesElement() { }

    public SeriesElement(string? name = null, List<object?>? data = null, string? type = null, bool? colorByPoint = null)
    {
        Name = name;
        Data = data;
        Type = type;
        ColorByPoint = colorByPoint;
    }
}
