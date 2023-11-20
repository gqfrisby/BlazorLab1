using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public interface IWeeklyForecast
    {
        public Dictionary<string, Forecast> WeekForecast { get; set; }
    }
}
