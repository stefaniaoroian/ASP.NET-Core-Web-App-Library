using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Oroian_Stefania_Lab2_1_.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return AuthorFirstName + " " + AuthorLastName;
            }
        }
        public ICollection<Book>? Books { get; set; }
    }
}
