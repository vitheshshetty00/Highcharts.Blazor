using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class SeriesEvents
{
    [JsonPropertyName("click")]
    public string? Click { get; set; }

    [JsonPropertyName("mouseOver")]
    public string? MouseOver { get; set; }

    [JsonPropertyName("mouseOut")]
    public string? MouseOut { get; set; }

    [JsonPropertyName("show")]
    public string? Show { get; set; }

    [JsonPropertyName("hide")]
    public string? Hide { get; set; }

    public SeriesEvents() { }
}

public class PointOptions
{
    [JsonPropertyName("events")]
    public PointEvents? Events { get; set; }

    public PointOptions() { }
}

public class PointEvents
{
    [JsonPropertyName("click")]
    public string? Click { get; set; }

    [JsonPropertyName("mouseOver")]
    public string? MouseOver { get; set; }

    [JsonPropertyName("mouseOut")]
    public string? MouseOut { get; set; }

    [JsonPropertyName("remove")]
    public string? Remove { get; set; }

    [JsonPropertyName("select")]
    public string? Select { get; set; }

    [JsonPropertyName("unselect")]
    public string? Unselect { get; set; }

    [JsonPropertyName("update")]
    public string? Update { get; set; }

    public PointEvents() { }
}
