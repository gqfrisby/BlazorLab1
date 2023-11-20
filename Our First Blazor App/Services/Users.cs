using Our_First_Blazor_App.Data;
namespace Our_First_Blazor_App.Services
{
    public class Users : IUsers
    {
        public Dictionary<int, User> CurrentUsers { get; set; } = new Dictionary<int, User>();

    }
}
