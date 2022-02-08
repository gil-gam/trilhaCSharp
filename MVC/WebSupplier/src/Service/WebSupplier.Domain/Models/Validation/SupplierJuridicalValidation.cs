using FluentValidation;

namespace WebSupplier.Domain.Models.Validation
{
    public class SupplierJuridicalValidation : AbstractValidator<SupplierJuridical>
    {
        public SupplierJuridicalValidation()
        {
            RuleFor(x => x.FantasyName)
                .Length(10, 256)
                .WithMessage("The Fantasy Name be must between 10 and 256 characters.");

            RuleFor(x => x.CompanyName)
                .Length(10, 256)
                .WithMessage("The Company Name be must between 10 and 256 characters.");
        }
    }
}
