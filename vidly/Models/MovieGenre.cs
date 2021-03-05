using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Models
{
    public class MovieGenre
    {
        [Key]
        public int MovieGenreID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Movie> movies { get; set; }
    }
}