using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; private set; }

        private List<Product> _products = new List<Product>();
        public IReadOnlyCollection<Product> Products => _products;

        protected Category() { }

        public Category(string name)
        {
            SetName(name);
        }

        public void SetName(string value)
        {
            //DomainValidation.ValidateIsNullOrEmpty(value, "The Name is mandatory.");
            Name = value;
        }

    }
}
