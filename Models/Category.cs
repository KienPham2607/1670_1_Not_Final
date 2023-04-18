using System.ComponentModel.DataAnnotations;

namespace _1670_1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50), MaxLength(50), MinLength(1)]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Status { get; set; }
        public virtual ICollection<Book>? Books { get; set; }
    }
}
