namespace Our_First_Blazor_App.Data
{
    public class Forecast
    {
        public string DayOfWeek { get; set; }
        public double TemperatureInF { get; set; }
        public double PrecipitationChance { get; set; }

        public override string ToString()
        {
            return $"On {DayOfWeek}, it will be " +
                $"{TemperatureInF} Degrees Farenheit. There will" +
                $"be a {PrecipitationChance:F2} chance of rain.";
        }
    }
}
