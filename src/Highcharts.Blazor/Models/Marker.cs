using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Marker
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

    [JsonPropertyName("radius")]
    public int? Radius { get; set; }

    [JsonPropertyName("states")]
    public States? States { get; set; }

    [JsonPropertyName("lineWidth")]
    public int? LineWidth { get; set; }

    [JsonPropertyName("lineColor")]
    public string? LineColor { get; set; }

    [JsonPropertyName("fillColor")]
    public string? FillColor { get; set; }

    public Marker() { }

    public Marker(bool? enabled = null, string? symbol = null, int? radius = null, States? states = null)
    {
        Enabled = enabled;
        Symbol = symbol;
        Radius = radius;
        States = states;
    }
}
