using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Style
{
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    [JsonPropertyName("fontWeight")]
    public string? FontWeight { get; set; }

    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    [JsonPropertyName("textOutline")]
    public string? TextOutline { get; set; }

    [JsonPropertyName("textAlign")]
    public string? TextAlign { get; set; }

    public Style() { }

    public Style(string? color = null, string? fontSize = null, string? fontWeight = null)
    {
        Color = color;
        FontSize = fontSize;
        FontWeight = fontWeight;
    }
}
