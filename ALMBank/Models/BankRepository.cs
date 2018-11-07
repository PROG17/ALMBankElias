using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMBank.Models
{
    public class BankRepository
    {
        public BankRepository()
        {


            Customers.Add(new Customer
            {
                Name = "Elias",
                CustomerID=1
            });
            Customers.Add(new Customer
            {
                Name = "Adrian",
                CustomerID = 2

            });
            Customers.Add(new Customer
            {
                Name = "Charbel",
                CustomerID = 3

            });


            Accounts.Add(new Account()
            {
                AccountName = "Konto1",
                Balance = 10000,
                Customer = Customers[0]
            });

            Accounts.Add(new Account()
            {
                AccountName = "Konto2",
                Balance = 20000000,
                Customer = Customers[0]
            });

            Accounts.Add(new Account()
            {
                AccountName = "Konto1",
                Balance = 20000000,
                Customer = Customers[1]
            });
            Accounts.Add(new Account()
            {
                AccountName = "Konto1",
                Balance = 20,
                Customer = Customers[2]
            });
            Accounts.Add(new Account()
            {
                AccountName = "Konto2",
                Balance = 20,
                Customer = Customers[2]
            });
        }

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Account> Accounts { get; set; } = new List<Account>();
    }
}

