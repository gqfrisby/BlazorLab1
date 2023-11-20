using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public class AvailableBooks : IAvailableBooks
    {
        public Dictionary<int, Book> availableBooks { get; set; } = new Dictionary<int, Book>();

    }
}
