using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Label
{
    [JsonPropertyName("connectorAllowed")]
    public bool? ConnectorAllowed { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("align")]
    public string? Align { get; set; }

    [JsonPropertyName("textAlign")]
    public string? TextAlign { get; set; }

    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    [JsonPropertyName("y")]
    public double? Y { get; set; }

    [JsonPropertyName("x")]
    public double? X { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("style")]
    public Style? Style { get; set; }

    public Label() { }

    public Label(bool? connectorAllowed = null)
    {
        ConnectorAllowed = connectorAllowed;
    }
}
