using System;
using System.ComponentModel.DataAnnotations;

namespace WebSupplier.WebApp.Models.Supplier
{
    public class EmailViewModel
    {        
        [EmailAddress(ErrorMessage = "Invalid Email.")]
        public string EmailAddress { get; set; }

    }
}
