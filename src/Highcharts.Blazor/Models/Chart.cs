
using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models
{
    public class Chart
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("backgroundColor")]
        public object? BackgroundColor { get; set; }

        [JsonPropertyName("styledMode")]
        public bool? StyledMode { get; set; }

        [JsonPropertyName("zoomType")]
        public string? ZoomType { get; set; }

        [JsonPropertyName("spacing")]
        public List<int?>? Spacing { get; set; }

        [JsonPropertyName("polar")]
        public bool? Polar { get; set; }

        [JsonPropertyName("margin")]
        public List<int?>? Margin { get; set; }

        [JsonPropertyName("animation")]
        public Animation? Animation { get; set; }

        [JsonPropertyName("options3d")]
        public Options3D? Options3d { get; set; }

        public Chart() { }

        public Chart(string? type = null, bool? styledMode = null, string? zoomType = null, 
                    int? width = null, int? height = null, List<int?>? spacing = null, 
                    List<int?>? margin = null, object? backgroundColor = null, 
                    Animation? animation = null, Options3D? options3d = null)
        {
            Type = type;
            StyledMode = styledMode;
            ZoomType = zoomType;
            Width = width;
            Height = height;
            Spacing = spacing;
            Margin = margin;
            BackgroundColor = backgroundColor;
            Animation = animation;
            Options3d = options3d;
        }
    }
}
