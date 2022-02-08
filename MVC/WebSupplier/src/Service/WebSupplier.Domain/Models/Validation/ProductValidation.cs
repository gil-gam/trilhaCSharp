using FluentValidation;

namespace WebSupplier.Domain.Models.Validation
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name)
                .Length(2, 256)
                .WithMessage("O Name be must between 9 and 256 characters.");

            RuleFor(x => x.BarCode)
                .Length(12, 14)
                .WithMessage("The BarCode be must between 12 and 14 characters.");

            RuleFor(x => ValiditPriceSales(x.PriceSales, x.PricePurchase))
                .NotEqual(true)
                .WithMessage("The selling price may not be less than or equal to the buying-in price.");
        }

        private bool ValiditPriceSales(decimal sales, decimal purchase)
        {
            return sales <= purchase;
        }
    }
}
