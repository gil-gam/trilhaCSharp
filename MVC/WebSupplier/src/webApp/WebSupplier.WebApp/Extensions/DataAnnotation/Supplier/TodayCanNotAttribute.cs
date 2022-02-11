using System;
using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Extensions.DataAnnotation.Supplier
{
    public class TodayCanNotAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if(value != null)
            {
                DateTime date = DateTime.Parse(value.ToString());
                if (date.Date == DateTime.Now.Date) return new ValidationResult("Date can’t be today.");
            }
            return ValidationResult.Success;
        }
    }
}
