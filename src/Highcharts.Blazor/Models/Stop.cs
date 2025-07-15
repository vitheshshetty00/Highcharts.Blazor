using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Stop
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    public Stop() { }

    public Stop(double? value, string? color)
    {
        Value = value;
        Color = color;
    }
}
