
using Highcharts.Blazor.Models;
using Highcharts.Blazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Highcharts.Blazor
{
    public partial class HighchartsChart : IAsyncDisposable
    {
        [Inject]
        private IHighchartsService HighchartsService { get; set; } = default!;

        [Inject]
        private IJSRuntime JSRuntime { get; set; } = default!;

        public string ChartContainerId { get; } = $"highcharts-chart-{Guid.NewGuid()}";
        private DotNetObjectReference<HighchartsChart>? objRef;

        [Parameter]
        public ChartOptions? Options { get; set; }

        [Parameter]
        public EventCallback<PointClickEventArgs> OnPointClick { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && Options != null)
            {
                objRef = DotNetObjectReference.Create(this);
                await HighchartsService.RenderChartAsync(ChartContainerId, Options);
                await SetEvents(ChartContainerId, objRef);
            }
        }

        [JSInvokable]
        public async Task HandlePointClick(PointClickEventArgs args)
        {
            await OnPointClick.InvokeAsync(args);
        }

        public async ValueTask DisposeAsync()
        {
            if (objRef != null)
            {
                await HighchartsService.DisposeChartAsync(ChartContainerId);
                objRef.Dispose();
            }
        }

        private async Task SetEvents(string chartId, DotNetObjectReference<HighchartsChart> component)
        {
            await JSRuntime.InvokeVoidAsync("setEvents", chartId, component);
        }
    }
}
