using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class PlotOptionsSeries
{
    [JsonPropertyName("label")]
    public Label? Label { get; set; }

    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    [JsonPropertyName("pointStart")]
    public double? PointStart { get; set; }

    [JsonPropertyName("pointInterval")]
    public double? PointInterval { get; set; }

    [JsonPropertyName("fillOpacity")]
    public double? FillOpacity { get; set; }

    [JsonPropertyName("stacking")]
    public string? Stacking { get; set; }

    [JsonPropertyName("pointWidth")]
    public int? PointWidth { get; set; }

    [JsonPropertyName("lineWidth")]
    public int? LineWidth { get; set; }

    [JsonPropertyName("lineColor")]
    public string? LineColor { get; set; }

    [JsonPropertyName("animation")]
    public Animation? Animation { get; set; }

    [JsonPropertyName("enableMouseTracking")]
    public bool? EnableMouseTracking { get; set; }

    [JsonPropertyName("events")]
    public SeriesEvents? Events { get; set; }

    [JsonPropertyName("point")]
    public PointOptions? Point { get; set; }

    [JsonPropertyName("states")]
    public States? States { get; set; }

    public PlotOptionsSeries() { }

    public PlotOptionsSeries(Label? label = null, double? pointStart = null, int? pointWidth = null)
    {
        Label = label;
        PointStart = pointStart;
        PointWidth = pointWidth;
    }
}

public class PlotOptionsArea
{
    [JsonPropertyName("pointStart")]
    public double? PointStart { get; set; }

    [JsonPropertyName("stacking")]
    public string? Stacking { get; set; }

    [JsonPropertyName("lineWidth")]
    public int? LineWidth { get; set; }

    [JsonPropertyName("lineColor")]
    public string? LineColor { get; set; }

    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    [JsonPropertyName("enableMouseTracking")]
    public bool? EnableMouseTracking { get; set; }

    [JsonPropertyName("states")]
    public States? States { get; set; }

    public PlotOptionsArea() { }

    public PlotOptionsArea(double? pointStart = null, Marker? marker = null)
    {
        PointStart = pointStart;
        Marker = marker;
    }
}

public class PlotOptionsBar
{
    [JsonPropertyName("label")]
    public Label? Label { get; set; }

    [JsonPropertyName("dataLabels")]
    public Labels? DataLabels { get; set; }

    [JsonPropertyName("pointStart")]
    public double? PointStart { get; set; }

    [JsonPropertyName("fillOpacity")]
    public double? FillOpacity { get; set; }

    [JsonPropertyName("pointWidth")]
    public int? PointWidth { get; set; }

    [JsonPropertyName("lineWidth")]
    public int? LineWidth { get; set; }

    [JsonPropertyName("lineColor")]
    public string? LineColor { get; set; }

    [JsonPropertyName("animation")]
    public Animation? Animation { get; set; }

    public PlotOptionsBar() { }
}

public class PlotOptionsPie
{
    [JsonPropertyName("allowPointSelect")]
    public bool? AllowPointSelect { get; set; }

    [JsonPropertyName("showInLegend")]
    public bool? ShowInLegend { get; set; }

    [JsonPropertyName("borderColor")]
    public string? BorderColor { get; set; }

    [JsonPropertyName("borderWidth")]
    public int? BorderWidth { get; set; }

    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }

    [JsonPropertyName("depth")]
    public int? Depth { get; set; }

    [JsonPropertyName("center")]
    public string[]? Center { get; set; }

    [JsonPropertyName("dataLabels")]
    public Labels? DataLabels { get; set; }

    [JsonPropertyName("states")]
    public States? States { get; set; }

    [JsonPropertyName("startAngle")]
    public int? StartAngle { get; set; }

    [JsonPropertyName("endAngle")]
    public int? EndAngle { get; set; }

    [JsonPropertyName("innerSize")]
    public string? InnerSize { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    public PlotOptionsPie() { }

    public PlotOptionsPie(bool? allowPointSelect = null, bool? showInLegend = null, string? cursor = null, 
        Labels? dataLabels = null, States? states = null, int? startAngle = null, int? endAngle = null)
    {
        AllowPointSelect = allowPointSelect;
        ShowInLegend = showInLegend;
        Cursor = cursor;
        DataLabels = dataLabels;
        States = states;
        StartAngle = startAngle;
        EndAngle = endAngle;
    }
}

public class PlotOptionsColumn
{
    [JsonPropertyName("borderRadius")]
    public int? BorderRadius { get; set; }

    [JsonPropertyName("pointPadding")]
    public int? PointPadding { get; set; }

    [JsonPropertyName("groupPadding")]
    public int? GroupPadding { get; set; }

    [JsonPropertyName("stacking")]
    public string? Stacking { get; set; }

    [JsonPropertyName("borderWidth")]
    public int? BorderWidth { get; set; }

    [JsonPropertyName("shadow")]
    public bool? Shadow { get; set; }

    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    public PlotOptionsColumn() { }

    public PlotOptionsColumn(string? stacking)
    {
        Stacking = stacking;
    }

    public PlotOptionsColumn(int? borderRadius)
    {
        BorderRadius = borderRadius;
    }
}

public class PlotOptionsLine
{
    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("dashStyle")]
    public string? DashStyle { get; set; }

    [JsonPropertyName("label")]
    public Label? Label { get; set; }

    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    [JsonPropertyName("enableMouseTracking")]
    public bool? EnableMouseTracking { get; set; }

    public PlotOptionsLine() { }
}

public class PlotOptionsScatter
{
    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    [JsonPropertyName("states")]
    public States? States { get; set; }

    [JsonPropertyName("tooltip")]
    public Tooltip? Tooltip { get; set; }

    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    public PlotOptionsScatter() { }
}

public class PlotOptionsSpline
{
    [JsonPropertyName("marker")]
    public Marker? Marker { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("dashStyle")]
    public string? DashStyle { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("zIndex")]
    public int? ZIndex { get; set; }

    [JsonPropertyName("label")]
    public Label? Label { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    public PlotOptionsSpline() { }
}

public class PlotOptionsColumnRange
{
    [JsonPropertyName("borderRadius")]
    public int? BorderRadius { get; set; }

    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    [JsonPropertyName("grouping")]
    public bool? Grouping { get; set; }

    public PlotOptionsColumnRange() { }

    public PlotOptionsColumnRange(int? borderRadius)
    {
        BorderRadius = borderRadius;
    }
}

public class PlotOptionsSolidgauge
{
    [JsonPropertyName("dataLabels")]
    public DataLabels? DataLabels { get; set; }

    [JsonPropertyName("linecap")]
    public string? Linecap { get; set; }

    [JsonPropertyName("stickyTracking")]
    public bool? StickyTracking { get; set; }

    [JsonPropertyName("rounded")]
    public bool? Rounded { get; set; }

    public PlotOptionsSolidgauge() { }
}
