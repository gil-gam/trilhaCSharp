using System;
using System.ComponentModel.DataAnnotations;
using WebSupplier.Domain.Tools;
using System.Collections.Generic;

namespace WebSupplier.Domain.Models
{
    public class Product : Entity
    {
        public Guid CategoryId { get; private set; }
        public Guid SupplierId { get; private set; }

        public string Name { get; private set; }
        public string BarCode { get; private set; }
        public int QuantityStock { get; private set; }
        public bool Active { get; private set; }
        public decimal PriceSales { get; private set; }
        public decimal PricePurchase { get; private set; }

        public Category Category { get; private set; }
        public Supplier Supplier { get; private set; }


        private List<Image> _image = new List<Image>();
        public IReadOnlyCollection<Image> Images => _image;

        protected Product() { }
        public Product(Guid supplierId, Guid categoryId, string name, string barCode, int quantityStock, bool active, decimal priceSales, decimal pricePurchase)
        {
            CategoryId = categoryId;
            SupplierId = supplierId;
            BarCode = barCode;
            Active = active;
            SetName(name);
            AddQuantity(quantityStock);
            SetPricePurchase(pricePurchase);

            SetPriceSales(priceSales);
        }

        public void AddImage(string path)
        {
            _image.Add(new Image(Id, path));
        }

        public void SetName(string value)
        {
            DomainValidation.ValidateIsNullOrEmpty(value, "Name cannot be null or empty.");
            Name = value;
        }
        public void AddQuantity(int quantity)
        {
            DomainValidation.ValidateIfTrue(quantity < 0, "The amount to be added cannot be less than zero.");
            QuantityStock += quantity;
        }
        public void RemoveQuantity(int quantity)
        {
            if (QuantityStock - quantity < 0)
            {
                QuantityStock = 0;
            }
            else
            {
                QuantityStock -= quantity;
            }
        }
        public void SetPriceSales(decimal value)
        {
            //O valor de venda sempre deve ser maior que o preço de compra
            DomainValidation.ValidateIfTrue(value <= PricePurchase, "The selling price may not be less than the buying-in price.");
            PriceSales = value;
        }

        public void Enable()
        {
            Active = true;
        }
        public void Disable()
        {
            Active = false;
        }

        private void SetPricePurchase(decimal value)
        {
            //O valor de compra não pode ser menor ou igual que zero
            DomainValidation.ValidateIfTrue(value <= 0, "The purchase price may not be less than or equal to 0.");
            PricePurchase = value;
        }
    }
}
