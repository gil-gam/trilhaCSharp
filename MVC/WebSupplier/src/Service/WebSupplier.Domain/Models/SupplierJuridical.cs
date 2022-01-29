using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class SupplierJuridical : Supplier
    {
        public string CompanyName { get; set; }
        public string FantasyName { get; set; }
        public string Cnpj { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime OpenDate { get; set; }
          

        public SupplierJuridical(string companyName, string fantasyName, string cnpj)
        {
            if ((!string.IsNullOrEmpty(companyName)) || (!string.IsNullOrEmpty(fantasyName)))
                    throw new DomainException("The Company and the Fantasy Name are mandatories!");
            if (cnpj.IsCnpj()) throw new DomainException("The CNPJ is mandatory!");

            CompanyName = companyName;
            Cnpj = cnpj;            
        }

        public void SetCompanyName(string value)
        {
            //validação
            CompanyName = value;
        }

        public void SetCnpj(string value)
        {
            if (value.IsCnpj()) throw new DomainException("The CNPJ is mandatory!");
            Cnpj = value;
        }
     

        public class SupplierJuridicalValidator : AbstractValidator<SupplierJuridical>
        {
            public SupplierJuridicalValidator()
            {
                RuleFor(x => x.CompanyName)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Company Name is mandatory")
                    .Length(5, 256)
                    .WithMessage("The Company Name field must contain 5 and 256 characters");

                RuleFor(x => x.Cnpj.IsCnpj())
                    .Equal(true)
                    .WithMessage("Invalid CNPJ");

            }
        }
    }
}
