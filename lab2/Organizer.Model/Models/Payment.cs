using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model.Models
{
    [Serializable]
    public class Payment
    {
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
