using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model.Models
{
    [Serializable]
    public class Invoice
    {
        public string Counterparty { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public InvoiceStatus Status { get; set; }
        public string InvoiceCategory { get; set; }

        // Колекція пов'язаних платежів
        public IEnumerable<Payment> Payments { get; set; }

    }

    public enum InvoiceStatus
    {
        Unpaid,
        Paid,
        Overdue
    }

}
