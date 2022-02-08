using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Extensions.DataAnnotation.Supplier
{
    public class CnpjAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }
    }
}
