using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Options3D
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("alpha")]
    public int? Alpha { get; set; }

    [JsonPropertyName("beta")]
    public int? Beta { get; set; }

    [JsonPropertyName("depth")]
    public int? Depth { get; set; }

    [JsonPropertyName("viewDistance")]
    public int? ViewDistance { get; set; }

    [JsonPropertyName("fitToPlot")]
    public bool? FitToPlot { get; set; }

    public Options3D() { }

    public Options3D(bool? enabled = null, int? alpha = null, int? beta = null)
    {
        Enabled = enabled;
        Alpha = alpha;
        Beta = beta;
    }
}
