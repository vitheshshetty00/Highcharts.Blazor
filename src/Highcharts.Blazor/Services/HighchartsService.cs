using System.Text.Json;
using Highcharts.Blazor.Models;
using Microsoft.JSInterop;

namespace Highcharts.Blazor.Services;

public class HighchartsService : IHighchartsService
{
    private readonly IJSRuntime _jsRuntime;

    public HighchartsService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task RenderChartAsync(string containerId, ChartOptions options)
    {
        var optionsJson = JsonSerializer.Serialize(options, HighchartsJsonSerializerContext.Default.ChartOptions);
        await RenderChartAsync(containerId, optionsJson);
    }

    public async Task RenderChartAsync(string containerId, string chartOptions)
    {
        await _jsRuntime.InvokeVoidAsync("renderHighchartChart", containerId, chartOptions);
    }

    public async Task AddSeriesAsync(string chartId, string seriesJson)
    {
        await _jsRuntime.InvokeVoidAsync("addSeries", chartId, seriesJson);
    }

    public async Task RemoveSeriesAsync(string chartId, int seriesIndex)
    {
        await _jsRuntime.InvokeVoidAsync("removeSeries", chartId, seriesIndex);
    }

    public async Task AddPointAsync(string chartId, int seriesIndex, string pointJson, bool redraw = true, bool shift = false)
    {
        await _jsRuntime.InvokeVoidAsync("addPoint", chartId, seriesIndex, pointJson, redraw, shift);
    }

    public async Task UpdateSeriesDataAsync(string chartId, int seriesIndex, string dataJson)
    {
        await _jsRuntime.InvokeVoidAsync("updateSeriesData", chartId, seriesIndex, dataJson);
    }

    public async Task UpdateSeriesAtIndexAsync(string chartId, int seriesIndex, string seriesData)
    {
        await _jsRuntime.InvokeVoidAsync("updateSeriesAtIndexHighchartChart", chartId, seriesIndex, seriesData);
    }

    public async Task UpdateTitleAsync(string chartId, string titleText, string titleColor)
    {
        await _jsRuntime.InvokeVoidAsync("updateTitleHighchartChart", chartId, titleText, titleColor);
    }

    public async Task UpdateXAxisPlotLineValueAsync(string chartId, double plotlineVal, int plotlineIndex)
    {
        await _jsRuntime.InvokeVoidAsync("updateXAxisPlotLineValue", chartId, plotlineVal, plotlineIndex);
    }

    public async Task UpdateYAxisPlotLineValueAsync(string chartId, double plotlineVal, int plotlineIndex)
    {
        await _jsRuntime.InvokeVoidAsync("updateYAxisPlotLineValue", chartId, plotlineVal, plotlineIndex);
    }

    public async Task UpdateXAxisCategoriesAsync(string chartId, string[] categories)
    {
        await _jsRuntime.InvokeVoidAsync("updateXAxisCategories", chartId, categories);
    }

    public async Task UpdateChartAsync(string chartId, string newChart)
    {
        await _jsRuntime.InvokeVoidAsync("updateChart", chartId, newChart);
    }

    public async Task RedrawAsync(string chartId)
    {
        await _jsRuntime.InvokeVoidAsync("redraw", chartId);
    }

    public async Task DestroyChartsAsync()
    {
        await _jsRuntime.InvokeVoidAsync("destroyCharts");
    }

    public async Task DisposeChartAsync(string chartId)
    {
        await _jsRuntime.InvokeVoidAsync("disposeHighchartChart", chartId);
    }

    // Convenience methods for strongly-typed operations
    public async Task UpdateSeriesDataAsync<T>(string chartId, int seriesIndex, List<T> data)
    {
        var jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        await UpdateSeriesDataAsync(chartId, seriesIndex, jsonData);
    }

    public async Task UpdateChartAsync(string chartId, ChartOptions chartOptions)
    {
        var optionsJson = JsonSerializer.Serialize(chartOptions, HighchartsJsonSerializerContext.Default.ChartOptions);
        await UpdateChartAsync(chartId, optionsJson);
    }

    public async Task UpdateXAxisCategoriesAsync(string chartId, List<string> categories)
    {
        await UpdateXAxisCategoriesAsync(chartId, categories.ToArray());
    }
}
