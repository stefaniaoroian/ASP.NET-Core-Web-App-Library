using Oroian_Stefania_Lab2_1_.Models;

namespace Oroian_Stefania_Lab2_1_.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<BookCategory> BookCategories { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
