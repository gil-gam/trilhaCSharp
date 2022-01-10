﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
   public class Genre
   {
      public int GenreID { get; set; }

      [Required]
      public string Name { get; set; }

      [DataType(DataType.MultilineText)]
      public string Description { get; set; }

      public virtual ICollection<Movie> Movies { get; set; }
              
   }
}