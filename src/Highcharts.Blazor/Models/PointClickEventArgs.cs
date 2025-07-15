
namespace Highcharts.Blazor.Models
{
    public class PointClickEventArgs
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int SeriesIndex { get; set; }
        public string? SeriesName { get; set; }
    }
}
