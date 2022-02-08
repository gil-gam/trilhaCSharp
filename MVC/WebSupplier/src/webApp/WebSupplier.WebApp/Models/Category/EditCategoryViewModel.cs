using System;
using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Models.Category
{
    public class EditCategoryViewModel
    {        
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Name is mandatory.")]
        [StringLength(256, MinimumLength = 2, ErrorMessage = "The Name must contain between 2 and 100 characters.")]
        public string Name { get; set; }
    }
}
