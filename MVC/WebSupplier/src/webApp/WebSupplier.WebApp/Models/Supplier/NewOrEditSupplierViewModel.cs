using WebSupplier.WebApp.Extensions.DataAnnotation.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebSupplier.Domain.Models;

namespace WebSupplier.WebApp.Models.Supplier
{
    public class NewOrEditSupplierViewModel
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }

        public string FantasyName { get; set; }

        [CompanyNameAttribute]
        public string CompanyName { get; set; }

        [CnpjAttribute]
        public string Cnpj { get; set; }

        [TodayCanNotAttribute]
        public DateTime OpenDate { get; set; }

        [FullNameAttribute]
        public string FullName { get; set; }

        [CpfAttribute]
        public string Cpf { get; set; }

        [TodayCanNotAttribute]
        public DateTime BirthDate { get; set; }

        public SupplierType SupplierType { get; set; }

        public AddressViewModel Address { get; set; }
        public EmailViewModel Email { get; set; }
        public ICollection<PhoneViewModel> Phones { get; set; } = new List<PhoneViewModel>();

        [StringLength(16, MinimumLength = 16, ErrorMessage = "Invalid Phone.")]
        public string Telephone { get; set; }
    }

    public enum SupplierType
    {
        Juridical = 1,
        Physical = 2,
    }
}
