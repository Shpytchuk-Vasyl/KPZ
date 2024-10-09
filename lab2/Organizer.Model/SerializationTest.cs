using KPZ_Lab2.Models;
using KPZ_Lab2.Serialization;
using Organizer.Model.Models;
using Xunit;


namespace Lab2Test
{
    public class SerializationTest
    {
        [Fact]
        public void Serialize_WhenDataIsValid_Success()
        {
            var model = GenerateTestModel();
            DataSerializer.SerializeData(@"../SerializationTest.dat", model);
        }

        [Fact]
        public void Deserialize_WhenDataIsValid_Success()
        {
            var model = DataSerializer.DeserializeData(@"../SerializationTest.dat");
            Assert.NotNull(model);
            Assert.NotEmpty(model.Accounts);
        }

        public static DataModel GenerateTestModel()
        {
            return new DataModel
            {
                Accounts = new List<Account>
                {
                    new Account
                    {
                        AccountName = "Main Account",
                        Currency = "USD",
                        Balance = 1000,
                        Invoices = new List<Invoice>
                        {
                            new Invoice
                            {
                                Counterparty = "ABC Corp",
                                InvoiceDate = DateTime.Now.AddDays(-30),
                                DueDate = DateTime.Now.AddDays(30),
                                TotalAmount = 500,
                                Status = InvoiceStatus.Unpaid,
                                InvoiceCategory = "Services",
                                Payments = new List<Payment>
                                {
                                    new Payment { PaymentDate = DateTime.Now.AddDays(-10), PaymentAmount = 250 }
                                }
                            },
                            new Invoice
                            {
                                Counterparty = "XYZ Corp",
                                InvoiceDate = DateTime.Now.AddDays(-60),
                                DueDate = DateTime.Now.AddDays(10),
                                TotalAmount = 1000,
                                Status = InvoiceStatus.Unpaid,
                                InvoiceCategory = "Goods",
                                Payments = new List<Payment>
                                {
                                    new Payment { PaymentDate = DateTime.Now.AddDays(-5), PaymentAmount = 500 }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}