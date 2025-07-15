using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Drilldown
{
    [JsonPropertyName("activeAxisLabelStyle")]
    public object? ActiveAxisLabelStyle { get; set; }

    [JsonPropertyName("activeDataLabelStyle")]
    public object? ActiveDataLabelStyle { get; set; }

    [JsonPropertyName("animation")]
    public Animation? Animation { get; set; }

    [JsonPropertyName("drillUpButton")]
    public DrillUpButton? DrillUpButton { get; set; }

    [JsonPropertyName("series")]
    public List<Series>? Series { get; set; }

    public Drilldown() 
    { 
        Series = new List<Series>();
    }
}

public class DrillUpButton
{
    [JsonPropertyName("position")]
    public Position? Position { get; set; }

    [JsonPropertyName("relativeTo")]
    public string? RelativeTo { get; set; }

    [JsonPropertyName("theme")]
    public object? Theme { get; set; }
}
