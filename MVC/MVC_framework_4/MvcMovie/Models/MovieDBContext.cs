using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("MovieDbContext")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
        public DbSet<Log> Log { get; set; }

        public System.Data.Entity.DbSet<MvcMovie.ViewModels.LogInfo> LogInfoes { get; set; }
    }
}