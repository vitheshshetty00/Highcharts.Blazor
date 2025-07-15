using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class States
{
    [JsonPropertyName("hover")]
    public Hover? Hover { get; set; }

    [JsonPropertyName("select")]
    public StateConfig? Select { get; set; }

    [JsonPropertyName("inactive")]
    public StateConfig? Inactive { get; set; }

    public States() { }

    public States(Hover? hover = null)
    {
        Hover = hover;
    }
}

public class StateConfig
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("radius")]
    public int? Radius { get; set; }

    [JsonPropertyName("lineWidth")]
    public int? LineWidth { get; set; }

    [JsonPropertyName("fillColor")]
    public string? FillColor { get; set; }

    [JsonPropertyName("lineColor")]
    public string? LineColor { get; set; }
}
