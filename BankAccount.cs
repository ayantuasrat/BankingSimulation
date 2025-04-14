using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSimulation
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }

        public BankAccount(string name, string accountType, decimal initialDeposit)
        {
            Name = name;
            AccountType = accountType;
            Balance = initialDeposit;
            AccountNumber = GenerateAccountNumber();
        }

        private string GenerateAccountNumber() 
        {
            Random rnd = new Random();
            return "AC" + rnd.Next(100000,999999).ToString();
        }
    }
}
