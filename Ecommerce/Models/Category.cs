using System.ComponentModel;

namespace Ecommerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}

