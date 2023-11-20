using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public interface IScoringService
    {
        public Dictionary<string, RobotScore> RobotScores { get; set;  }
    }
}
