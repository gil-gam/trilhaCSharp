using FluentValidation;

namespace WebSupplier.Domain.Models.Validation
{
    public class EmailValidation : AbstractValidator<Email>
    {
        public EmailValidation()
        {
            RuleFor(x => x.EmailAddress)
                .EmailAddress()
                .WithMessage("Invalid Email.");
        }
    }
}
