using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSimulation
{
    public abstract class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set;

        public Account(string name, decimal initialDeposit)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));
            Name = name;
            Balance = initialDeposit;
            AccountNumber = GenerateAccountNumber();
            AccountType = GetType().Name.Replace("Account", "");
        }

        private string GenerateAccountNumber()
        {
            Random rnd = new Random();
            return "AC" + rnd.Next(100000, 999999).ToString();
        }

        public abstract void Deposit(decimal amount);
        public abstract bool Withdraw(decimal amount);
        public abstract bool Transfer(Account toAccount, decimal amount);
    }
}
