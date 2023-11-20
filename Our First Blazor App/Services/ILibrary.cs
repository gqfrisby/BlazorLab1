using Our_First_Blazor_App.Data;
namespace Our_First_Blazor_App.Services
{
    public interface ILibrary
    {
        public Dictionary<int, Book> currentBooks { get; set; }
    }
}
