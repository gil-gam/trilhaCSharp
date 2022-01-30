using System;
using System.ComponentModel.DataAnnotations;

namespace WebSupplier.Domain.Models
{
    public class Phone
    {
        public Guid Id { get; set; }
        public string Ddd { get; set; }
        public string Number { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime InsertDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime UpdateDate { get; set; }
       
    }
}
