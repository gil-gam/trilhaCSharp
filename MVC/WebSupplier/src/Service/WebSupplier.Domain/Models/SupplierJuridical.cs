using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class SupplierJuridical : Supplier
    {
        public string CompanyName { get; private set; }
        public string Cnpj { get; private set; }                
        public DateTime OpenDate { get; private set; }


        protected SupplierJuridical() { }
        public SupplierJuridical(string companyName, string cnpj, bool active, string fantasyName, string zipCode, string street, string number, string neighborhood, string city, string state,
                                string complement, string reference, string emailAddress, string ddd, string celCelular)
                                    : base(active, fantasyName, zipCode, street, number, neighborhood, city, state,
                                                complement, reference, emailAddress, ddd, celCelular)
        {
            SetCompanyName(companyName);
            SetCnpj(cnpj);
        }

        public override void SetFantasyName(string value)
        {
            base.SetFantasyName(value);
        }

        public void SetCompanyName(string value)
        {
            DomainValidation.ValidateIsNullOrEmpty(value, "The Company Name is mandatory.");
            CompanyName = value;
        }
        private void SetCnpj(string value)
        {
            DomainValidation.ValidateIsNullOrEmpty(value, "The CNPJ is mandatory.");
            Cnpj = value;
        }

        public void SetOpenDate(DateTime value)
        {
            DomainValidation.ValidateIfTrue(value.Date == DateTime.Now.Date, "Opening date cannot be equal to today");
            OpenDate = value;
        }
    }
}
