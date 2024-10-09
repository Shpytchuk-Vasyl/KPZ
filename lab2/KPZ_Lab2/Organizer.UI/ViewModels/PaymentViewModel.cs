using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    class PaymentViewModel : ViewModelBase
    {
        private DateTime _paymentDate;
        public DateTime PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; OnPropertyChanged("PaymentDate"); }
        }

        private decimal _paymentAmount;
        public decimal PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; OnPropertyChanged("PaymentAmount"); }
        }
    }
}
