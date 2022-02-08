using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Extensions.DataAnnotation.Supplier
{
    public class CompanyNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return ValidationResult.Success;
        }
    }
}
