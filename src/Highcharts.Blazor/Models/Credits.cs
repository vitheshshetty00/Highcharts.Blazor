using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Credits
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("href")]
    public string? Href { get; set; }

    [JsonPropertyName("position")]
    public Position? Position { get; set; }

    public Credits() { }

    public Credits(bool? enabled = null, string? text = null, string? href = null)
    {
        Enabled = enabled;
        Text = text;
        Href = href;
    }
}
