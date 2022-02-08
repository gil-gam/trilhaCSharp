using FluentValidation;
using WebSupplier.Domain.Models;
using WebSupplier.Domain.Models.enums;

namespace WebSupplier.Domain.Models.Validation
{
    public class PhoneValidation : AbstractValidator<Phone>
    {
        public PhoneValidation()
        {
            RuleFor(x => x.Ddd)
                .Length(2, 2)
                .WithMessage("The DDD must contain 2 characters.");

            When(x => x.PhoneType == PhoneType.Celular, () =>
            {
                RuleFor(x => x.Number)
                    .Length(9, 9)
                    .WithMessage("Cell phone must contain 9 characters.");
            });

            When(x => x.PhoneType == PhoneType.Comercial, () =>
            {
                RuleFor(x => x.Number)
                    .Length(8, 9)
                    .WithMessage("Commercial telephone must contain between 8 and 9 characters.");
            });

            When(x => x.PhoneType == PhoneType.Fixo, () =>
            {
                RuleFor(x => x.Number)
                    .Length(8, 8)
                    .WithMessage("The Phone must contain 8 characters.");
            });
        }
    }
}
