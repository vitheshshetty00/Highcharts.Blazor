using Highcharts.Blazor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Highcharts.Blazor;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHighchartsBlazor(this IServiceCollection services)
    {
        return services.AddScoped<IHighchartsService, HighchartsService>();
    }
}
