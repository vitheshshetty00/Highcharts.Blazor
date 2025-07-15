using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Labels
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("formatter")]
    public string? Formatter { get; set; }

    [JsonPropertyName("style")]
    public Style? Style { get; set; }

    [JsonPropertyName("useHTML")]
    public bool? UseHTML { get; set; }

    [JsonPropertyName("align")]
    public string? Align { get; set; }

    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    [JsonPropertyName("x")]
    public int? X { get; set; }

    [JsonPropertyName("y")]
    public int? Y { get; set; }

    [JsonPropertyName("rotation")]
    public int? Rotation { get; set; }

    [JsonPropertyName("step")]
    public int? Step { get; set; }

    [JsonPropertyName("staggerLines")]
    public int? StaggerLines { get; set; }

    [JsonPropertyName("maxStaggerLines")]
    public int? MaxStaggerLines { get; set; }

    [JsonPropertyName("overflow")]
    public string? Overflow { get; set; }

    [JsonPropertyName("padding")]
    public int? Padding { get; set; }

    [JsonPropertyName("distance")]
    public int? Distance { get; set; }

    public Labels() { }

    public Labels(bool? enabled = null)
    {
        Enabled = enabled;
    }
}
