using ALMBank.Models;
using System;
using Xunit;

namespace ALMBankTest
{
    public class BankRepoTester
    {
        [Fact]
        public void WithdrawlTest()
        {
            BankRepository repo = new BankRepository();
            Customer cust1 = new Customer { Name="cust1", CustomerID = 22};
            Account acc = new Account { AccountName = "namn1", Customer = cust1, Balance = 1000 };

            repo.Accounts.Add(acc);

            var result = repo.Withdrawl(22, "namn1");

            Assert.Equal("Det gick bra", result);
            Assert.Equal(978, acc.Balance);

        }


        [Fact]
        public void WithdrawlTest_Denied()
        {
            BankRepository repo = new BankRepository();
            Customer cust1 = new Customer { Name = "cust1", CustomerID = 22 };
            Account acc = new Account { AccountName = "namn1", Customer = cust1, Balance = 1000 };

            repo.Accounts.Add(acc);

            var result = repo.Withdrawl(2000000, "namn1");

            Assert.Equal("Finns inte tillräckligt med stålar", result);
            Assert.Equal(1000, acc.Balance);

        }


        [Fact]
        public void DepositTest()
        {
            BankRepository repo = new BankRepository();
            Customer cust1 = new Customer { Name = "cust1", CustomerID = 22 };
            Account acc = new Account { AccountName = "namn1", Customer = cust1, Balance = 1 };

            repo.Accounts.Add(acc);

            var result = repo.Deposit(1, "namn1");

            Assert.Equal("Bra stålar", result);

            Assert.Equal(2, acc.Balance);

        }
    }
}
