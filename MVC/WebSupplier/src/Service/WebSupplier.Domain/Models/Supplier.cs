using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSupplier.Domain.Models
{
    public class Supplier
    {
        public Guid Id { get; private set; }

        public bool Active { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime InsertDate { get; private set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? UpdateDate { get; private set; }


        public Supplier()
        {
            Id = Guid.NewGuid();                        
        }


        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }


        public void Enable()
        {
            Active = true;
        }

        public void Disable()
        {
            Active = false;
        }


        //public virtual bool IsValid()
        //{
        //    throw new NotImplementedException();
        //}


    }
}
