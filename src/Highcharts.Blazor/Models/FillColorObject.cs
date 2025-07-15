using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class FillColorObject
{
    [JsonPropertyName("animation")]
    public bool? Animation { get; set; }

    [JsonPropertyName("pattern")]
    public PatternOptionsObject? Pattern { get; set; }

    [JsonPropertyName("patternIndex")]
    public int? PatternIndex { get; set; }
}

public class PatternOptionsObject
{
    [JsonPropertyName("aspectRatio")]
    public double? AspectRatio { get; set; }

    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("patternTransform")]
    public string? PatternTransform { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("x")]
    public double? X { get; set; }

    [JsonPropertyName("y")]
    public double? Y { get; set; }
}
