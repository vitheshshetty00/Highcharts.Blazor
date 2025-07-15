using System.Text.Json.Serialization;

namespace Highcharts.Blazor.Models;

public class Animation
{
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    [JsonPropertyName("defer")]
    public int? Defer { get; set; }

    public Animation() { }

    public Animation(int? duration)
    {
        Duration = duration;
    }
}
