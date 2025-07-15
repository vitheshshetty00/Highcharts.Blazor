using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Hover
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("halo")]
    public bool? Halo { get; set; }

    [JsonPropertyName("lineColor")]
    public string? LineColor { get; set; }

    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    [JsonPropertyName("lineWidth")]
    public int? LineWidth { get; set; }

    public Hover() { }

    public Hover(bool? enabled = null)
    {
        Enabled = enabled;
    }
}
