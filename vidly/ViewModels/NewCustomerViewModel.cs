using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;
using Vidly.Models;

namespace vidly.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; } //ho deciso di usare Ienumerable invece di list perchè nella view non vogliamo usare .add o altro, voglio solo iterare. In questo modo possiamo usare qualsiasi cosa che implementi Ienumerable ed il nostro codice sarà più flessibile
        public Customer Customer { get; set; }
    }
}