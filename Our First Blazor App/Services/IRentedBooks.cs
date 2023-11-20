using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public interface IRentedBooks
    {
        public Dictionary<int, Book> rentedBooks { get; set; }
    }
}
