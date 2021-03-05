
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vidly.Models;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        
        public DateTime? DateAdded { get; set; }

        [Required]
        public int numberInStock { get; set; }

        [ForeignKey("MovieGenre")]
        public int MovieGenreID { get; set; }

        public virtual MovieGenre MovieGenre { get; set; }


    }
}