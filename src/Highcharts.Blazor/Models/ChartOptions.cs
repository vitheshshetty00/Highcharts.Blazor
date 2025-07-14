namespace Highcharts.Blazor.Models;

public class ChartOptions
{
    // This will be expanded in Phase 2.
    // For now, we just need the class to exist.
    // We will add a dummy property to allow serialization.
    public Title Title { get; set; } = new();
}

public class Title
{
    public string Text { get; set; } = "My First Chart";
}
