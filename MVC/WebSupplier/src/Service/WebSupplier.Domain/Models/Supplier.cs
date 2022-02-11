using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public abstract class Supplier : Entity
    {
        public bool Active { get; private set; }
        public string FantasyName { get; protected set; }

        public Address Address { get; private set; }
        public Email Email { get; private set; }


        private List<Phone> _phones = new List<Phone>();
        public IReadOnlyCollection<Phone> Phones => _phones;

        private List<Product> _products = new List<Product>();
        public IReadOnlyCollection<Product> Products => _products;

        protected Supplier() { }
        protected Supplier(bool active, string fantasyName, string zipCode, string street, string number, string neighborhood, string city, string state,
                        string complement, string reference, string emailAddress, string ddd, string celCelular)
        {
            Active = active;
            FantasyName = fantasyName;
            AddAddress(new Address(Id, zipCode, street, number, neighborhood, city, state, complement, reference));
            AddEmail(new Email(Id, emailAddress));
            AddPhone(new Phone(Id, ddd, celCelular));
        }

        public virtual void SetFantasyName(string value)
        {
            DomainValidation.ValidateIsNullOrEmpty(value, "The Fantasy Name is mandatory.");
            FantasyName = value;
        }

        public virtual void AddPhone(Phone phone)
        {          
            _phones.Add(phone);
        }
        public virtual void UpdatePhone(string ddd, string phone)
        {            
            var phoneExist = _phones.FirstOrDefault();
            phoneExist.SetPhone(ddd, phone);

        }
        public virtual void RemovePhone(string ddd, string number)
        {            
            var phoneExist = _phones.FirstOrDefault();
            _phones.Remove(phoneExist);

        }
        public bool PhoneExist(string ddd, string number)
        {
            return _phones.FirstOrDefault() == null;
        }

        public virtual void UpdateAddress(string zipCode, string street, string number, string neighborhood, string city, string state,
                        string complement = null, string reference = null)
        {
            Address.SetAddress(zipCode, street, number, neighborhood, city, state,
                         complement, reference);
        }
        private void AddAddress(Address address)
        {
            Address = address;
        }

        public virtual void UpdateEmail(string email)
        {
            Email.SetEmail(email);
        }
        private void AddEmail(Email email)
        {
            Email = email;
        }


    }
}
