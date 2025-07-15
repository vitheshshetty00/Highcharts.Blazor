using Highcharts.Blazor.Models;

namespace Highcharts.Blazor.Services;

public interface IHighchartsService
{
    Task RenderChartAsync(string containerId, ChartOptions options);
    Task RenderChartAsync(string containerId, string chartOptions);
    Task AddSeriesAsync(string chartId, string seriesJson);
    Task RemoveSeriesAsync(string chartId, int seriesIndex);
    Task AddPointAsync(string chartId, int seriesIndex, string pointJson, bool redraw = true, bool shift = false);
    Task UpdateSeriesDataAsync(string chartId, int seriesIndex, string dataJson);
    Task UpdateSeriesAtIndexAsync(string chartId, int seriesIndex, string seriesData);
    Task UpdateTitleAsync(string chartId, string titleText, string titleColor);
    Task UpdateXAxisPlotLineValueAsync(string chartId, double plotlineVal, int plotlineIndex);
    Task UpdateYAxisPlotLineValueAsync(string chartId, double plotlineVal, int plotlineIndex);
    Task UpdateXAxisCategoriesAsync(string chartId, string[] categories);
    Task UpdateChartAsync(string chartId, string newChart);
    Task RedrawAsync(string chartId);
    Task DestroyChartsAsync();
    Task DisposeChartAsync(string chartId);
    
    // Convenience methods for strongly-typed operations
    Task UpdateSeriesDataAsync<T>(string chartId, int seriesIndex, List<T> data);
    Task UpdateChartAsync(string chartId, ChartOptions chartOptions);
    Task UpdateXAxisCategoriesAsync(string chartId, List<string> categories);
}
