namespace Oroian_Stefania_Lab2_1_.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
