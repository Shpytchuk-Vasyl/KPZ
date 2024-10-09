using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    class AccountViewModel : ViewModelBase
    {
        private string _accountName;
        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; OnPropertyChanged("AccountName"); }
        }

        private string _currency;
        public string Currency
        {
            get { return _currency; }
            set { _currency = value; OnPropertyChanged("Currency"); }
        }

        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; OnPropertyChanged("Balance"); }
        }

        private ObservableCollection<InvoiceViewModel> _invoices;
        public ObservableCollection<InvoiceViewModel> Invoices
        {
            get { return _invoices; }
            set { _invoices = value; OnPropertyChanged("Invoices"); }
        }
    }
}
