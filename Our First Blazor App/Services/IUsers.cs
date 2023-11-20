using Our_First_Blazor_App.Data;
namespace Our_First_Blazor_App.Services
{
    public interface IUsers
    {
        public Dictionary<int, User> CurrentUsers { get; set; }
    }
}
