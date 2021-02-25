using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubScribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; } //entity framework, for name convention, will use this properties as foreign key 

    }
}