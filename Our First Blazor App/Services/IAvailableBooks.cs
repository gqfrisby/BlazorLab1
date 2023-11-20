using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public interface IAvailableBooks
    {
        public Dictionary<int, Book> availableBooks { get; set; }
    }
}
