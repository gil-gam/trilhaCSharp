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
        public new bool Active { get; }
        public string ZipCode { get; }
        public string Street { get; }
        public string Number { get; }
        public string Neighborhood { get; }
        public string City { get; }
        public string State { get; }
        public string Complement { get; }
        public string Reference { get; }
        public string EmailAddress { get; }

        protected SupplierPhysical() { }

        public SupplierPhysical(string fullName, string cpf, bool active, string fantasyName, string zipCode, string street, string number, string neighborhood, string city, string state,
                                string complement, string reference, string emailAddress, string ddd, string celCelular)
                                    : base(active, fantasyName, zipCode, street, number, neighborhood, city, state,
                                                complement, reference, emailAddress, ddd, celCelular)
        {
            SetFullName(fullName);
            SetCpf(cpf);
        }

        public SupplierPhysical(string fullName, string cpf, bool active, string fantasyName, string zipCode, string street, string number, string neighborhood, string city, string state, string complement, string reference, string emailAddress)
        {
            FullName = fullName;
            Cpf = cpf;
            Active = active;
            FantasyName = fantasyName;
            ZipCode = zipCode;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Complement = complement;
            Reference = reference;
            EmailAddress = emailAddress;
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
            DomainValidation.ValidateIfTrue(value.Date == DateTime.Now.Date, "BirthDate cannot be equal to today.");
            DomainValidation.ValidateIfTrue(value.Date.AddYears(18) > DateTime.Now.Date, "Supplier must be at least 18 years old.");
                        
            BirthDate = value;
        }

    }
}
