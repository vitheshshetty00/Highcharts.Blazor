
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class PlotOptions
{
    [JsonPropertyName("series")]
    public PlotOptionsSeries? Series { get; set; }

    [JsonPropertyName("area")]
    public PlotOptionsArea? Area { get; set; }

    [JsonPropertyName("bar")]
    public PlotOptionsBar? Bar { get; set; }

    [JsonPropertyName("pie")]
    public PlotOptionsPie? Pie { get; set; }

    [JsonPropertyName("scatter")]
    public PlotOptionsScatter? Scatter { get; set; }

    [JsonPropertyName("column")]
    public PlotOptionsColumn? Column { get; set; }

    [JsonPropertyName("columnrange")]
    public PlotOptionsColumnRange? ColumnRange { get; set; }

    [JsonPropertyName("line")]
    public PlotOptionsLine? Line { get; set; }

    [JsonPropertyName("spline")]
    public PlotOptionsSpline? Spline { get; set; }

    [JsonPropertyName("solidgauge")]
    public PlotOptionsSolidgauge? Solidgauge { get; set; }

    public PlotOptions()
    {
        Series = new PlotOptionsSeries();
    }

    public PlotOptions(PlotOptionsSeries? series = null)
    {
        Series = series;
    }
}
