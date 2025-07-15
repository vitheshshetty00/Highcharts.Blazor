using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Accessibility
{
    [JsonPropertyName("rangeDescription")]
    public string? RangeDescription { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    public Accessibility() { }

    public Accessibility(string? rangeDescription = null, string? description = null)
    {
        RangeDescription = rangeDescription;
        Description = description;
    }
}
