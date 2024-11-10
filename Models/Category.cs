namespace Catinas_Darius_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory>? BookCateogries { get; set; }
    }
}
