using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;


namespace MvcMovie.Models 
{
    public class Log 
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Data { get; set; }
                
        public string Usuario { get; set; }
                
        public string Operacao { get; set; }

                
    }


    public class ConsultaLog : System.Data.Entity.CreateDatabaseIfNotExists<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            var logs = new List<Log>
            {
                new Log { Id = Int32.Parse("Id"), Data = DateTime.Parse("Date", new CultureInfo("en-US")), Usuario = "User", Operacao = "Operation" },
                
             };

            logs.ForEach(s => context.Log.Add(s));
            context.SaveChanges();

            
        }
    }


}
