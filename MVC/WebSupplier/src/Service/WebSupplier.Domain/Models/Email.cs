using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebSupplier.Domain.Models
{
    public class Email
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime InsertDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime UpdateDate { get; set; }



        public void SetEmailAddress(string value)
        {
            EmailAddress = value;
        }

        public class EmailValidator : AbstractValidator<Email>
        {
            public EmailValidator()
            {
                RuleFor(x => x.EmailAddress)
                .NotEmpty()
                .WithMessage("The Email is mandatory")
                .EmailAddress()
                .WithMessage("Invalid Email");
            }
        }

    }
}
