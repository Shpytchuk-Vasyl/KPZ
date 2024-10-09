using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model.Models
{

    [Serializable]
    public class Account
    {
        public string AccountName { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public IEnumerable<Invoice> Invoices { get; set; }

    }


}
