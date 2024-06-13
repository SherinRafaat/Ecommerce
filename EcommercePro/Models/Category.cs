using System.ComponentModel.DataAnnotations;

namespace EcommercePro.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The Name of Category is Reqiured")]
        [UniqueCategory]
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Product>? Products { get; set; }
    }
}
