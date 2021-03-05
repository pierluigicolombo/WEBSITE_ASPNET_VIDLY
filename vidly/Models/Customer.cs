﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using vidly.Models;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubScribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [ForeignKey("MembershipType")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } 

        [Display(Name ="Date of Birth")]
        public string Birthdate { get; set; }

    }
}