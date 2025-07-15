
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Legend
{
    [JsonPropertyName("align")]
    public string? Align { get; set; }

    [JsonPropertyName("alignColumns")]
    public bool? AlignColumns { get; set; }

    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    [JsonPropertyName("borderColor")]
    public string? BorderColor { get; set; }

    [JsonPropertyName("borderRadius")]
    public int? BorderRadius { get; set; }

    [JsonPropertyName("borderWidth")]
    public int? BorderWidth { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("floating")]
    public bool? Floating { get; set; }

    [JsonPropertyName("itemDistance")]
    public int? ItemDistance { get; set; }

    [JsonPropertyName("itemMarginBottom")]
    public int? ItemMarginBottom { get; set; }

    [JsonPropertyName("itemMarginTop")]
    public int? ItemMarginTop { get; set; }

    [JsonPropertyName("itemWidth")]
    public int? ItemWidth { get; set; }

    [JsonPropertyName("labelFormat")]
    public string? LabelFormat { get; set; }

    [JsonPropertyName("layout")]
    public string? Layout { get; set; }

    [JsonPropertyName("margin")]
    public int? Margin { get; set; }

    [JsonPropertyName("maxHeight")]
    public int? MaxHeight { get; set; }

    [JsonPropertyName("padding")]
    public int? Padding { get; set; }

    [JsonPropertyName("reversed")]
    public bool? Reversed { get; set; }

    [JsonPropertyName("rtl")]
    public bool? Rtl { get; set; }

    [JsonPropertyName("shadow")]
    public bool? Shadow { get; set; }

    [JsonPropertyName("squareSymbol")]
    public bool? SquareSymbol { get; set; }

    [JsonPropertyName("symbolHeight")]
    public int? SymbolHeight { get; set; }

    [JsonPropertyName("symbolPadding")]
    public int? SymbolPadding { get; set; }

    [JsonPropertyName("symbolRadius")]
    public int? SymbolRadius { get; set; }

    [JsonPropertyName("symbolWidth")]
    public int? SymbolWidth { get; set; }

    [JsonPropertyName("title")]
    public Title? Title { get; set; }

    [JsonPropertyName("useHTML")]
    public bool? UseHTML { get; set; }

    [JsonPropertyName("verticalAlign")]
    public string? VerticalAlign { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("x")]
    public int? X { get; set; }

    [JsonPropertyName("y")]
    public int? Y { get; set; }

    public Legend() { }

    public Legend(bool? enabled = null, string? layout = null, string? align = null, 
                  string? verticalAlign = null, bool? floating = null, int? x = null, 
                  int? y = null, int? borderWidth = null)
    {
        Enabled = enabled;
        Floating = floating;
        Layout = layout;
        Align = align;
        VerticalAlign = verticalAlign;
        X = x;
        Y = y;
        BorderWidth = borderWidth;
    }
}
