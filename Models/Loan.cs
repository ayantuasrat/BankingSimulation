using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSimulation
{
    public class Loan
    {
        public string AccountNumber {  get; set; }
        public decimal Amount { get; set; }
        public double InterestRate {  get; set; }
        public bool IsApproved { get; set; }
        public Loan() { }

        public Loan(string accountNumber,decimal amount)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            InterestRate = 0.09;
            IsApproved = true;
        }
    }
}
