using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public class WeeklyForecast : IWeeklyForecast
    {
        public Dictionary<string, Forecast> WeekForecast { get; set; } = new Dictionary<string, Forecast>();

        public WeeklyForecast() {
        }
    }
}
