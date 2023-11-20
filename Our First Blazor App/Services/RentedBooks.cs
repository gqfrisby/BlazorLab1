using Our_First_Blazor_App.Data;

namespace Our_First_Blazor_App.Services
{
    public class RentedBooks : IRentedBooks
    {
        public Dictionary<int, Book> rentedBooks { get; set; } = new Dictionary<int, Book>();

    }
}
