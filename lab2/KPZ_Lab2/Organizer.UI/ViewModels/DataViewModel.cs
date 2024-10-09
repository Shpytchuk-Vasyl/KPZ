using AutoMapper;
using KPZ_Lab2.Models;
using Organizer.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Organizer.UI.Base;

namespace Organizer.UI.ViewModels
{
    class DataViewModel : ViewModelBase
    {
        private string _visibleControl="Accounts";

        public string VisibleControl
        {
            get { return _visibleControl; }
            set { _visibleControl = value; OnPropertyChanged("VisibleControl"); }
        }

        private ObservableCollection<AccountViewModel> _accounts;

        public ObservableCollection<AccountViewModel> Accounts
        {
            get { return _accounts; }
            set { _accounts = value; OnPropertyChanged("Accounts"); }
        }

        private ObservableCollection<InvoiceViewModel> _invoices;

        public ObservableCollection<InvoiceViewModel> Invoices
        {
            get { return _invoices; }
            set { _invoices = value; OnPropertyChanged("Invoices"); }
        }

        private ObservableCollection<PaymentViewModel> _payments;

        public ObservableCollection<PaymentViewModel> Payments
        {
            get { return _payments; }
            set { _payments = value; OnPropertyChanged("Payments"); }
        }


        public ICommand NavigateToInvoicesCommand { get; set; }
        public ICommand NavigateToPaymentsCommand { get; set; }
        public ICommand NavigateTo { get; set; }

        public DataViewModel()
        {
            NavigateToInvoicesCommand = new Command(NavigateToInvoices);
            NavigateToPaymentsCommand = new Command(NavigateToPayments);
            NavigateTo = new Command((o =>  VisibleControl = (string)o!));
        }

        private void NavigateToInvoices(object account)
        {
            if (account is AccountViewModel accountViewModel)
            {
                if (accountViewModel.Invoices == null)
                    accountViewModel.Invoices = new ObservableCollection<InvoiceViewModel>();
                Invoices = accountViewModel.Invoices;
                VisibleControl = "Invoices";    
            }
            else
            {
                Console.WriteLine("Received incorrect type in CommandParameter");
            }
        }

        private void NavigateToPayments(object invoince)
        {
           if (invoince is InvoiceViewModel invoiceViewModel)
                {
                    if (invoiceViewModel.Payments == null)
                        invoiceViewModel.Payments = new ObservableCollection<PaymentViewModel>();

                    Payments = invoiceViewModel.Payments;
                        
                    VisibleControl = "Payments";
            }
                else
                {
                    Console.WriteLine("Received incorrect type in CommandParameter");
                }
        }


    }
}
