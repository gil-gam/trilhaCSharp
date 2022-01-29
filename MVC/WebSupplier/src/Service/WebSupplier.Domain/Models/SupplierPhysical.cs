using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class SupplierPhysical : Supplier, IAggregateRoot
    {
        public string FullName { get; set; }
        public string Cpf { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }


        public SupplierPhysical(string fullName, string cpf)
        {
            SetFullName(fullName);
            SetCpf(cpf);
            Enable();
            //IsValid();
        }

        protected SupplierPhysical() { }

        public void SetFullName(string value)
        {
            //validação
            if (!string.IsNullOrEmpty(value)) throw new DomainException("The Full Name is mandatory!");
            FullName = value;
        }

        public void SetCpf(string value)
        {
            if (value.IsCpf()) throw new DomainException("The CPF is mandatory!");
            Cpf = value;
        }

        public static bool Over18Years(DateTime BirthDate)
        {
            return BirthDate <= DateTime.Now.AddYears(-18);
        }


        //public override bool IsValid()
        //{
        //    //if (!string.IsNullOrEmpty(FullName)) throw new DomainException("The fullname is mandatory!");
        //    //if (Cpf.IsCpf()) throw new DomainException("The cpf is mandatory!");
        //    return true;
        //}

        public class SupplierPhysicalValidator : AbstractValidator<SupplierPhysical>
        {
            public SupplierPhysicalValidator()
            {
                RuleFor(x => x.FullName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Full Name is mandatory")
                    .Length(5, 256)
                    .WithMessage("The Full Name field must contain 5 and 256 characters");

                RuleFor(x => x.Cpf.IsCpf())
                    .Equal(true)
                    .WithMessage("Invalid CPF");

                RuleFor(x => x.BirthDate)
                    .NotEmpty()
                    .WithMessage("The Birth Date is mandatory")
                    .Must(Over18Years)
                    .WithMessage("Personal supplier must be over 18 years old");

            }
        }

    }
}
