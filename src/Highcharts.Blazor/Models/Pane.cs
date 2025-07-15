using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Pane
{
    [JsonPropertyName("center")]
    public List<string>? Center { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("startAngle")]
    public int? StartAngle { get; set; }

    [JsonPropertyName("endAngle")]
    public int? EndAngle { get; set; }

    [JsonPropertyName("background")]
    public List<PaneBackground>? Background { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    public Pane() { }
}

public class PaneBackground
{
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    [JsonPropertyName("borderWidth")]
    public int? BorderWidth { get; set; }

    [JsonPropertyName("outerRadius")]
    public string? OuterRadius { get; set; }

    [JsonPropertyName("innerRadius")]
    public string? InnerRadius { get; set; }

    [JsonPropertyName("shape")]
    public string? Shape { get; set; }
}
