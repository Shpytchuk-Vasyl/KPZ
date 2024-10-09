using AutoMapper;
using KPZ_Lab2.Models;
using Organizer.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Model.Models;

namespace Organizer.UI.Base
{
    public class Mapping
    {
        private readonly IMapper _mapper;

        public Mapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Account, AccountViewModel>();
                cfg.CreateMap<AccountViewModel, Account>();

                cfg.CreateMap<Invoice, InvoiceViewModel>();
                cfg.CreateMap<InvoiceViewModel, Invoice>();

                cfg.CreateMap<Payment, PaymentViewModel>();
                cfg.CreateMap<PaymentViewModel, Payment>();
            });

            _mapper = config.CreateMapper();
        }

        public IMapper GetMapper()
        {
            return _mapper;
        }
    }

}
