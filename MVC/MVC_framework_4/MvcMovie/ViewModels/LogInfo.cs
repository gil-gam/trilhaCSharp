using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcMovie.Models;
using MvcMovie.Controllers;


namespace MvcMovie.ViewModels
{
    public class LogInfo
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Data { get; set; }

        [Display(Name = "User")]
        public string Usuario { get; set; }

        [Display(Name = "Operation")]
        public string Operacao { get; set; }

    }
}
