﻿
using System;
using System.ComponentModel.DataAnnotations;

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
    }
}