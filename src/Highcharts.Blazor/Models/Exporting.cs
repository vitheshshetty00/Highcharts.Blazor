using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Exporting
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("buttons")]
    public ExportingButtons? Buttons { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("sourceWidth")]
    public int? SourceWidth { get; set; }

    [JsonPropertyName("sourceHeight")]
    public int? SourceHeight { get; set; }

    [JsonPropertyName("chartOptions")]
    public ChartOptions? ChartOptions { get; set; }

    public Exporting() { }

    public Exporting(bool? enabled = null, ExportingButtons? buttons = null, int? sourceWidth = null, 
                     int? sourceHeight = null, ChartOptions? chartOptions = null)
    {
        Enabled = enabled;
        Buttons = buttons;
        SourceWidth = sourceWidth;
        SourceHeight = sourceHeight;
        ChartOptions = chartOptions;
    }
}

public class ExportingButtons
{
    [JsonPropertyName("contextButton")]
    public ContextButton? ContextButton { get; set; }
}

public class ContextButton
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("menuItems")]
    public List<string>? MenuItems { get; set; }

    public ContextButton() { }

    public ContextButton(bool? enabled = null)
    {
        Enabled = enabled;
    }
}
