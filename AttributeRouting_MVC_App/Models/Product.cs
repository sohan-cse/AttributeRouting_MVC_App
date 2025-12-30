using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AttributeRouting_MVC_App.Models
{
    public class Product
    {
        [DisplayName("Product Id")]
        [Required(ErrorMessage ="Product Id required")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        [StringLength(50)]
        [Required(ErrorMessage ="Product Name required")]
        public string Name { get; set; }
        [DisplayName("Product Price")]
        [Required(ErrorMessage ="Product Price required")]
        public decimal Price { get; set; }
        [DisplayName("Units in Stock")]
        [Required(ErrorMessage ="Units in Stock required")]
        public int Stock { get; set; }
    }
}
