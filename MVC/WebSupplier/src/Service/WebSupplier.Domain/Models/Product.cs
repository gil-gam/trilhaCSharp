using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSupplier.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime InsertDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime UpdateTime { get; set; }
        
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int QuantityStock { get; set; }
        public bool Active { get; set; }
        public decimal PriceSales { get; set; }
        public decimal PricePurchase { get; set; }
      

        public Product(Guid id, DateTime insertDate, DateTime updateTime, string name, 
                       string barcode, int quantityStock, bool active, decimal priceSales, 
                       decimal pricePurchase, Supplier supplier, Category category, Image image)
        {
            Id = id;
            InsertDate = insertDate;
            UpdateTime = updateTime;
            Name = name;
            Barcode = barcode;
            QuantityStock = quantityStock;
            Active = active;
            PriceSales = priceSales;
            PricePurchase = pricePurchase;
        }
    }
}
