using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Responsive
{
    [JsonPropertyName("rules")]
    public List<Rule>? Rules { get; set; }

    public Responsive() { }

    public Responsive(Rule rule)
    {
        Rules = new List<Rule> { rule };
    }

    public Responsive(List<Rule>? rules = null)
    {
        Rules = rules;
    }
}

public class Rule
{
    [JsonPropertyName("condition")]
    public Condition? Condition { get; set; }

    [JsonPropertyName("chartOptions")]
    public ChartOptions? ChartOptions { get; set; }

    public Rule() { }

    public Rule(Condition? condition = null, ChartOptions? chartOptions = null)
    {
        Condition = condition;
        ChartOptions = chartOptions;
    }
}

public class Condition
{
    [JsonPropertyName("maxWidth")]
    public int? MaxWidth { get; set; }

    [JsonPropertyName("minWidth")]
    public int? MinWidth { get; set; }

    [JsonPropertyName("maxHeight")]
    public int? MaxHeight { get; set; }

    [JsonPropertyName("minHeight")]
    public int? MinHeight { get; set; }

    public Condition() { }

    public Condition(int? maxWidth = null, int? minWidth = null, int? maxHeight = null, int? minHeight = null)
    {
        MaxWidth = maxWidth;
        MinWidth = minWidth;
        MaxHeight = maxHeight;
        MinHeight = minHeight;
    }
}
