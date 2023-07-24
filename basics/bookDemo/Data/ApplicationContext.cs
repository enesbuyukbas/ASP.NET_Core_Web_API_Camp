using bookDemo.Models;

namespace bookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book(){Id=1,Title="Karagöz ve Hacivat",Price=150},
                new Book(){Id=2,Title="Lord of The Rings",Price=350},
                new Book(){Id=3,Title="Brave New World",Price=250}
            };
        }
    }
}
