using Organizer.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    class InvoiceViewModel : ViewModelBase
    {
        private string _counterparty;
        public string Counterparty
        {
            get { return _counterparty; }
            set { _counterparty = value; OnPropertyChanged("Counterparty"); }
        }

        private DateTime _invoiceDate;
        public DateTime InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; OnPropertyChanged("InvoiceDate"); }
        }

        private DateTime _dueDate;
        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; OnPropertyChanged("DueDate"); }
        }

        private decimal _totalAmount;
        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; OnPropertyChanged("TotalAmount"); }
        }

        private InvoiceStatus _status;
        public InvoiceStatus Status
        {
            get { return _status; }
            set { _status = value; OnPropertyChanged("Status"); }
        }

        private string _invoiceCategory;
        public string InvoiceCategory
        {
            get { return _invoiceCategory; }
            set { _invoiceCategory = value; OnPropertyChanged("InvoiceCategory"); }
        }

        private ObservableCollection<PaymentViewModel> _payments;
        public ObservableCollection<PaymentViewModel> Payments
        {
            get { return _payments; }
            set { _payments = value; OnPropertyChanged("Payments"); }
        }
    }
}
