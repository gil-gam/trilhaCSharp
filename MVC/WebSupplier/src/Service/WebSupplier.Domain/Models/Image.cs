using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class Image : Entity
    {
        public Guid ProductId { get; private set; }

        public string ImagePath { get; private set; }

        public Product Product { get; private set; }

        protected Image() { }
        public Image(Guid productId, string imagePath)
        {
            ProductId = productId;
            SetImage(imagePath);
        }

        public void SetImage(string value)
        {
            DomainValidation.ValidateIsNullOrEmpty(value, "The Image is invalid.");
            ImagePath = value;
        }

    }
}
