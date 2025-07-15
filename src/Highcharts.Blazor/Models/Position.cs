using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Position
{
    [JsonPropertyName("align")]
    public string? Align { get; set; }

    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    [JsonPropertyName("x")]
    public int? X { get; set; }

    [JsonPropertyName("y")]
    public int? Y { get; set; }
}
