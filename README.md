# Highcharts.Blazor

A high-performance, enterprise-grade Blazor wrapper for Highcharts.js with .NET 9 optimization.

[![NuGet Version](https://img.shields.io/nuget/v/Highcharts.Blazor.svg)](https://www.nuget.org/packages/Highcharts.Blazor/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Highcharts.Blazor.svg)](https://www.nuget.org/packages/Highcharts.Blazor/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Features

- 🚀 **High Performance**: Optimized for .NET 9 with AOT compilation support
- 📊 **Complete Highcharts API**: Full wrapper around Highcharts.js functionality
- 🎨 **Blazor Native**: Built specifically for Blazor Server and WebAssembly
- 🔧 **Type Safe**: Strongly-typed C# API with IntelliSense support
- 📱 **Responsive**: Mobile-friendly charts with touch support
- 🎯 **Easy Integration**: Simple setup with dependency injection

## Installation

Install the package via NuGet Package Manager:

```bash
dotnet add package Highcharts.Blazor
```

Or via Package Manager Console:

```powershell
Install-Package Highcharts.Blazor
```

## Quick Start

### 1. Add Service Registration

In your `Program.cs`:

```csharp
using Highcharts.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add Highcharts.Blazor services
builder.Services.AddHighchartsBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
```

### 2. Add Component Reference

In your `_Imports.razor`:

```razor
@using Highcharts.Blazor
```

### 3. Use in Components

```razor
@page "/charts"
@using Highcharts.Blazor

<h3>Sample Chart</h3>

<HighchartsChart @ref="chart" Options="@chartOptions" />

@code {
    private HighchartsChart chart;
    private ChartOptions chartOptions;

    protected override void OnInitialized()
    {
        chartOptions = new ChartOptions
        {
            Title = new Title { Text = "Sample Chart" },
            Chart = new Chart { Type = ChartType.Line },
            XAxis = new XAxis
            {
                Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" }
            },
            YAxis = new YAxis
            {
                Title = new AxisTitle { Text = "Values" }
            },
            Series = new List<Series>
            {
                new LineSeries
                {
                    Name = "Sample Data",
                    Data = new object[] { 1, 3, 2, 4, 3, 5 }
                }
            }
        };
    }
}
```

## Chart Types Supported

- Line Charts
- Area Charts
- Column Charts
- Bar Charts
- Pie Charts
- Scatter Charts
- Bubble Charts
- Heatmaps
- Treemaps
- And many more...

## Configuration Options

The library provides strongly-typed configuration options that mirror the Highcharts.js API:

```csharp
var options = new ChartOptions
{
    Chart = new Chart
    {
        Type = ChartType.Column,
        Height = 400,
        BackgroundColor = "#f8f9fa"
    },
    Title = new Title
    {
        Text = "Monthly Sales",
        Style = new Style { Color = "#333" }
    },
    Tooltip = new Tooltip
    {
        Enabled = true,
        Shared = true
    },
    Legend = new Legend
    {
        Enabled = true,
        Position = LegendPosition.Bottom
    }
};
```

## Advanced Features

### Real-time Updates

```csharp
// Add point to existing series
await chart.AddPointAsync(0, new { x = DateTime.Now.Ticks, y = newValue });

// Update series data
await chart.UpdateSeriesAsync(0, newDataArray);

// Redraw chart
await chart.RedrawAsync();
```

### Event Handling

```razor
<HighchartsChart @ref="chart"
                 Options="@chartOptions"
                 OnPointClick="HandlePointClick"
                 OnSeriesClick="HandleSeriesClick" />

@code {
    private void HandlePointClick(PointClickEventArgs args)
    {
        Console.WriteLine($"Point clicked: {args.Point.X}, {args.Point.Y}");
    }
}
```

## Browser Support

- Chrome 88+
- Firefox 85+
- Safari 14+
- Edge 88+

## Requirements

- .NET 9.0 or later
- Blazor Server or Blazor WebAssembly
- Highcharts.js license (for commercial use)

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

**Note**: This library is a wrapper for Highcharts.js. Commercial use of Highcharts.js requires a license from Highsoft. See [Highcharts License](https://www.highcharts.com/products/highcharts/#licensing) for more information.

## Support

- 📖 [Documentation](https://github.com/vitheshshetty00/Highcharts.Blazor/wiki)
- 🐛 [Issue Tracker](https://github.com/vitheshshetty00/Highcharts.Blazor/issues)
- 💬 [Discussions](https://github.com/vitheshshetty00/Highcharts.Blazor/discussions)

## Acknowledgments

- [Highcharts.js](https://www.highcharts.com/) - The powerful charting library this wrapper is built upon
- [Microsoft Blazor Team](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) - For the amazing Blazor framework

---

Made with ❤️ by [Vithesh Shetty](https://github.com/vitheshshetty00)
