using FluentValidation;

namespace WebSupplier.Domain.Models.Validation
{
    public class SupplierPhysicalValidation : AbstractValidator<SupplierPhysical>
    {
        public SupplierPhysicalValidation()
        {
            RuleFor(x => x.FantasyName)
                .Length(10, 256)
                .WithMessage("The Fantasy Name be must between 10 and 256 characters.");

            RuleFor(x => x.FullName)
                .Length(10, 256)
                .WithMessage("The Full Name be must between 10 and 256 characters.");
        }
    }
}
