using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class SupplierPhysical : Supplier
    {
        public string FullName { get; private set; }
        public string Cpf { get; private set; }
        public DateTime BirthDate { get; private set; }

        protected SupplierPhysical() { }

        public SupplierPhysical(string fullName, string cpf, bool active, string fantasyName, string zipCode, string street, string number, string neighborhood, string city, string state,
                                string complement, string reference, string emailAddress, string ddd, string celCelular)
                                    : base(active, fantasyName, zipCode, street, number, neighborhood, city, state,
                                                complement, reference, emailAddress, ddd, celCelular)
        {
            SetFullName(fullName);
            SetCpf(cpf);
        }
        public override void SetFantasyName(string value)
        {
            base.SetFantasyName(value);
        }
        public void SetFullName(string value)
        {
            DomainValidation.ValidateIsNullOrEmpty(value, "The Full Name is mandatory.");
            FullName = value;
        }
        private void SetCpf(string value)
        {
            DomainValidation.ValidateIsNullOrEmpty(value, "The CPF is mandatory.");
            Cpf = value;
        }
        public void SetBirthDate(DateTime value)
        {
            DomainValidation.ValidateIfTrue(value.Date == DateTime.Now.Date, "BirthDate cannot be equal to today");
            BirthDate = value;
        }

    }
}
