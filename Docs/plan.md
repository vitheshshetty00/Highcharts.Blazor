# Highcharts.Blazor Implementation Plan

This document outlines a phased approach to developing the `Highcharts.Blazor` library. The goal is to create a high-performance, enterprise-grade Blazor wrapper for Highcharts.js, optimized for .NET 9.

## Core Principles

- **Performance First:** Employ modern .NET 9 features, including Ahead-of-Time (AOT) compilation, optimized JS Interop, and efficient data serialization to ensure minimal performance overhead.
- **Lightweight & Efficient:** The library should be a thin, yet powerful, wrapper around Highcharts.js. Avoid heavy abstractions and focus on providing a strongly-typed API that maps directly to Highcharts options.
- **Developer Experience:** Provide a clean, intuitive, and strongly-typed C# API that makes it easy for Blazor developers to use Highcharts without writing JavaScript.
- **Testability:** Each feature should be testable. The project will include a comprehensive test suite.

## Phased Implementation Prompts

Below are the high-level prompts for each phase of development. Each section is designed to be used as a detailed request for an AI programming assistant to generate the necessary code and explanations.

---

### Phase 1: Project Scaffolding and Core Component Setup

**AI Prompt:**

"Create the foundational structure for the `Highcharts.Blazor` library.

1.  **Solution and Projects:**

    - Create a new solution named `Highcharts.Blazor`.
    - Inside the solution, create a Razor Class Library (RCL) project named `Highcharts.Blazor` targeting `.NET 9`. Configure it for AOT compatibility and to generate a NuGet package.
    - Create a Blazor Server project named `Highcharts.Blazor.Demo` targeting `.NET 9` to act as a testbed and example application.
    - Create an xUnit test project named `Highcharts.Blazor.Tests` targeting `.NET 9`.
    - Reference the `Highcharts.Blazor` project from both the `Highcharts.Blazor.Demo` and `Highcharts.Blazor.Tests` projects.

2.  **Core Component & JS Interop:**

    - In `Highcharts.Blazor`, create the main `HighchartsChart.razor` component. This component will have a `[Parameter]` for `ChartOptions` and will render a `div` element that will serve as the chart container.
    - Create a JavaScript file (`highcharts-blazor.js`) in the `wwwroot` of the RCL. This file will contain the core JS function to initialize a Highcharts chart.
    - Implement a basic JS Interop service (`HighchartsService.cs`) to call the JavaScript function, passing the chart options. Use the `[JSImport]` attribute for optimized interop.

3.  **Demo Application:**
    - In the `Highcharts.Blazor.Demo` project, add the necessary service registration for the `HighchartsService`.
    - In the `Home.razor` page, use the `<HighchartsChart>` component, pass a basic set of `ChartOptions`, and render a simple line chart."

---

### Phase 2: Strongly-Typed Chart Configuration API

**AI Prompt:**

"Implement the strongly-typed C# API for Highcharts configuration options within the `Highcharts.Blazor` project.

1.  **Base `ChartOptions` Class:**

    - Create the main `ChartOptions.cs` class. This will be the root object for all chart configurations.

2.  **Core Configuration Classes:**

    - Implement the following configuration classes with their most common properties. Use C# properties with appropriate types.
      - `Chart.cs` (e.g., `Type`, `Height`, `Width`, `BackgroundColor`)
      - `Title.cs` (e.g., `Text`, `Style`)
      - `Subtitle.cs` (e.g., `Text`, `Style`)
      - `XAxis.cs` & `YAxis.cs` (e.g., `Title`, `Categories`)
      - `Tooltip.cs` (e.g., `Enabled`, `Shared`, `Formatter`)
      - `Legend.cs` (e.g., `Enabled`, `Layout`, `Align`)
      - `PlotOptions.cs`
    - Ensure all classes are serializable to JSON with property names that match the Highcharts API (e.g., using `[JsonPropertyName("...")]`).

3.  **Series Configuration:**

    - Create a base `Series.cs` class.
    - Implement specific series types inheriting from the base class, starting with:
      - `LineSeries.cs`
      - `ColumnSeries.cs`
      - `PieSeries.cs`
    - The `Series` classes should include a `Data` property, which should be a `List<object>` to accommodate various data formats supported by Highcharts.

4.  **Update Demo:**
    - Modify the `Home.razor` page in the `Highcharts.Blazor.Demo` project to use these new strongly-typed classes to configure the chart, demonstrating a more complex chart setup."

---

### Phase 3: Dynamic Chart Updates and Interactivity

**AI Prompt:**

"Enhance the `Highcharts.Blazor` library with capabilities for real-time chart updates and event handling.

1.  **Chart Instance Reference:**

    - In the `HighchartsChart.razor` component, expose a public method to get a reference to the underlying Highcharts chart instance in JavaScript.

2.  **Dynamic Update Methods:**

    - In the `HighchartsService` (or a new dedicated service), implement methods to dynamically update the chart. These methods will call the corresponding functions on the Highcharts chart instance via JS Interop.
      - `AddSeriesAsync(string chartId, Series newSeries)`
      - `RemoveSeriesAsync(string chartId, int seriesIndex)`
      - `AddPointAsync(string chartId, int seriesIndex, object point, bool redraw, bool shift)`
      - `UpdateSeriesDataAsync(string chartId, int seriesIndex, IEnumerable<object> data)`
      - `RedrawAsync(string chartId)`

3.  **Event Handling:**

    - In `HighchartsChart.razor`, add `[Parameter]` properties for `EventCallback` delegates corresponding to common Highcharts events (e.g., `OnPointClick`, `OnSeriesClick`, `OnChartLoad`).
    - Use `[JSInvokable]` methods in a .NET object reference that can be passed to JavaScript when the chart is created. This will allow JavaScript to invoke .NET methods when chart events occur.
    - Create simple C# record types for event arguments (e.g., `PointClickEventArgs`) to pass event data back to the Blazor component.

4.  **Update Demo:**
    - In the demo app, create a new page that demonstrates these features. Add buttons to dynamically add/remove series and points. Display information about clicked points or series."

---

### Phase 4: Performance Optimization, AOT, and Packaging

**AI Prompt:**

"Finalize the `Highcharts.Blazor` library for release by focusing on performance, AOT compatibility, and NuGet packaging.

1.  **Performance Analysis & Optimization:**

    - Review all JS Interop calls. Ensure they are using the `[JSImport]` attribute for maximum performance with .NET 9 AOT.
    - Use source-generated JSON serialization (`JsonSerializerContext`) to avoid reflection and improve serialization/deserialization performance.
    - Benchmark the component rendering and update speeds.

2.  **AOT Compatibility:**

    - Thoroughly test the library in a Blazor WebAssembly project with AOT compilation enabled.
    - Resolve any AOT-related warnings or errors. Ensure all code is trimmer-friendly and AOT-compatible.

3.  **NuGet Package Configuration:**

    - In the `Highcharts.Blazor.csproj` file, configure all necessary NuGet package metadata:
      - `PackageId`, `Version`, `Authors`, `Description`, `PackageTags`
      - `PackageProjectUrl`, `RepositoryUrl`, `PackageLicenseExpression`
      - Include a `README.md` and an icon in the package.

4.  **Documentation:**

    - Write a comprehensive `README.md` file that covers installation, quick start, configuration options, and advanced features.
    - Create a simple GitHub Pages site for documentation if desired.

5.  **Build and Pack:**
    - Run the final build in `Release` configuration and use `dotnet pack` to create the NuGet package (`.nupkg`) and symbols package (`.snupkg`)."
