using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class ChartOptions
{
    [JsonPropertyName("chart")]
    public Chart? Chart { get; set; }

    [JsonPropertyName("accessibility")]
    public Accessibility? Accessibility { get; set; }

    [JsonPropertyName("title")]
    public Title? Title { get; set; }

    [JsonPropertyName("subtitle")]
    public Subtitle? Subtitle { get; set; }

    [JsonPropertyName("xAxis")]
    public XAxis? XAxis { get; set; }

    [JsonPropertyName("yAxis")]
    public YAxis? YAxis { get; set; }

    [JsonPropertyName("tooltip")]
    public Tooltip? Tooltip { get; set; }

    [JsonPropertyName("legend")]
    public Legend? Legend { get; set; }

    [JsonPropertyName("plotOptions")]
    public PlotOptions? PlotOptions { get; set; }

    [JsonPropertyName("series")]
    public List<Series>? Series { get; set; }

    [JsonPropertyName("credits")]
    public Credits? Credits { get; set; }

    [JsonPropertyName("responsive")]
    public Responsive? Responsive { get; set; }

    [JsonPropertyName("exporting")]
    public Exporting? Exporting { get; set; }

    [JsonPropertyName("pane")]
    public Pane? Pane { get; set; }

    [JsonPropertyName("drilldown")]
    public Drilldown? Drilldown { get; set; }

    [JsonPropertyName("colors")]
    public List<string>? Colors { get; set; }

    [JsonPropertyName("animation")]
    public Animation? Animation { get; set; }
}
