using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Datum
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("y")]
    public double? Y { get; set; }

    [JsonPropertyName("x")]
    public double? X { get; set; }

    [JsonPropertyName("drilldown")]
    public string? Drilldown { get; set; }

    [JsonPropertyName("radius")]
    public string? Radius { get; set; }

    [JsonPropertyName("innerRadius")]
    public string? InnerRadius { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    public Datum() { }

    public Datum(string? name, double? y, string? color = null, string? radius = null, string? innerRadius = null, Marker? marker = null)
    {
        Name = name;
        Y = y;
        Radius = radius;
        InnerRadius = innerRadius;
        Color = color;
        Marker = marker;
    }
}
