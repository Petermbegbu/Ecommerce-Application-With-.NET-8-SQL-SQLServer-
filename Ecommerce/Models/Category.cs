using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Name is Required")]
        [MaxLength(100, ErrorMessage="Maximum length is 100 characters")]
        [DisplayName("Category Name")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Display Order is Required")]
        [Range(1, 30, ErrorMessage="The range must be between 1-30")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}

