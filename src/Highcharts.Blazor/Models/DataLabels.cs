using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class DataLabels
{
    [JsonPropertyName("align")]
    public string? Align { get; set; }

    [JsonPropertyName("allowOverlap")]
    public bool? AllowOverlap { get; set; }

    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    [JsonPropertyName("borderColor")]
    public string? BorderColor { get; set; }

    [JsonPropertyName("borderRadius")]
    public int? BorderRadius { get; set; }

    [JsonPropertyName("borderWidth")]
    public int? BorderWidth { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("crop")]
    public bool? Crop { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("inside")]
    public bool? Inside { get; set; }

    [JsonPropertyName("overflow")]
    public string? Overflow { get; set; }

    [JsonPropertyName("padding")]
    public int? Padding { get; set; }

    [JsonPropertyName("position")]
    public string? Position { get; set; }

    [JsonPropertyName("rotation")]
    public int? Rotation { get; set; }

    [JsonPropertyName("shadow")]
    public bool? Shadow { get; set; }

    [JsonPropertyName("shape")]
    public string? Shape { get; set; }

    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    [JsonPropertyName("x")]
    public int? X { get; set; }

    [JsonPropertyName("y")]
    public int? Y { get; set; }

    [JsonPropertyName("z")]
    public int? Z { get; set; }

    public DataLabels() { }

    public DataLabels(bool? enabled = null)
    {
        Enabled = enabled;
    }
}
