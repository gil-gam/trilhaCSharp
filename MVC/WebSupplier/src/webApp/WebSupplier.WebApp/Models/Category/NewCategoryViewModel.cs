using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Models.Category
{
    public class NewCategoryViewModel
    {
        [Required(ErrorMessage = "The field is mandatory.")]
        [StringLength(256, MinimumLength = 2, ErrorMessage = "The field must contain between 2 and 100 characters.")]
        public string Name { get; set; }
    }
}
