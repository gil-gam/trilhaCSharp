using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSupplier.WebApp.Models.Supplier
{
    public class SupplierViewModel
    {
        public const string Juridical = "Juridical";
        public const string Physical = "Physical";
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public string FantasyName { get; set; }

        public string CompanyName { get; set; }
        public string Cnpj { get; set; }
        public DateTime OpenDate { get; set; }


        public string FullName { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }

        public DateTime InsertDate { get; set; }

        public EmailViewModel Email { get; set; }
        public ICollection<PhoneViewModel> Phones { get; set; } = new List<PhoneViewModel>();

        public AddressViewModel Address { get; set; }

        public string GetFullNameOrCompanyName()
        {
            return string.IsNullOrEmpty(CompanyName) ? FullName : CompanyName;
        }

        public string GetCnpjOrCpf()
        {
            return string.IsNullOrEmpty(Cnpj) ? Cpf : Cnpj;
        }
                
        public string PersonType { get; set; }

        public string Telephone { get; set; }        
                 

        public void SetTypePerson()
        {
            PersonType = string.IsNullOrEmpty(Cpf) ? Juridical : Physical;
        }
    }
}
