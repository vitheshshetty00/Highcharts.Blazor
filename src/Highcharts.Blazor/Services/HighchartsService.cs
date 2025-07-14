using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using Highcharts.Blazor.Models;

namespace Highcharts.Blazor.Services;

public partial class HighchartsService
{
    public async Task RenderChartAsync(string containerId, ChartOptions options)
    {
        var optionsJson = JsonSerializer.Serialize(options, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
        });

        await JSHost.ImportAsync("highcharts-blazor", "../_content/Highcharts.Blazor/highcharts-blazor.js");
        await RenderChart(containerId, optionsJson);
    }

    [JSImport("initializeChart", "highcharts-blazor")]
    private static partial Task RenderChart(string containerId, string options);
}
