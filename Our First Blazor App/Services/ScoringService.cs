using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public class ScoringService : IScoringService
    {
        public Dictionary<string, RobotScore> RobotScores { get; set; } = new Dictionary<string, RobotScore>();
    }
}
