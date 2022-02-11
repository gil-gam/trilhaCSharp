using System;
using System.ComponentModel.DataAnnotations;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class Phone : Entity
    {
        public Guid SupplierId { get; private set; }

        public string Ddd { get; private set; }
        public string Number { get; private set; }

        public Supplier Supplier { get; private set; }

        protected Phone() { }

        public Phone(Guid supplierId, string ddd, string number)
        {
            SupplierId = supplierId;
            SetPhone(ddd, number);
        }

     
        public void SetPhone(string ddd, string number)
        {
            //DomainValidation.ValidateIsNullOrEmpty(ddd, "The DDD is mandatory.");
            //DomainValidation.ValidateIsNullOrEmpty(number, "The Number is mandatory.");

            Ddd = ddd;
            Number = number;            
        }
    }
}
