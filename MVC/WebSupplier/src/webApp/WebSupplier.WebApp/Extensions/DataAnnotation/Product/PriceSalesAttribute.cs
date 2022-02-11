using WebSupplier.WebApp.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Extensions.DataAnnotation.Product
{
    public class PriceSalesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                if(validationContext.ObjectInstance is NewProductViewModel)
                {
                    var model = (NewProductViewModel)validationContext.ObjectInstance;
                    if (decimal.Parse(value.ToString()) <= model.PricePurchase) return new ValidationResult("Preço de venda não pode ser menor ou igual a o preço de compra");
                }
                if (validationContext.ObjectInstance is EditProductViewModel)
                {
                    var model = (EditProductViewModel)validationContext.ObjectInstance;

                    if(decimal.Parse(value.ToString()) <= model.PricePurchase) return new ValidationResult("Selling price may not be less than or equal to the buying-in price.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
