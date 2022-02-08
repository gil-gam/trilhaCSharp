using System;
using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Models.Supplier
{
    public class AddressViewModel
    {
        [Required(ErrorMessage = "The field is mandatory.")]
        [Display(Name = "Zip Code")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "The field must contains 8 characters.")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "The field is mandatory.")]
        [Display(Name = "Street")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The field must contains between 5 e 100 characters.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "The field is mandatory.")]
        [Display(Name = "Number")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "The field must contains between 1 e 10 characters.")]
        public string Number { get; set; }

        [Display(Name = "Complement")]
        [StringLength(100, MinimumLength = 0, ErrorMessage = "The field must contain a maximum of 100 characters.")]
        public string Complement { get; set; }

        [Display(Name = "Reference")]
        [StringLength(100, MinimumLength = 0, ErrorMessage = "The field must contain a maximum of 100 characters.")]
        public string Reference { get; set; }

        [Required(ErrorMessage = "The field is mandatory.")]
        [Display(Name = "Neighborhood")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The field must contains betweene 2 e 100 characters.")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "The field is mandatory.")]
        [Display(Name = "City")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "The field must contains between 2 e 100 characters.")]
        public string City { get; set; }

        [Required(ErrorMessage = "The field is mandatory.")]
        [Display(Name = "State")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "The field must contains 2 characters.")]
        public string State { get; set; }

        public override string ToString()
        {
            return $"{Street}, {Number} - {Neighborhood}, {City} - {State}, {ZipCode}";
        }

    }
}
