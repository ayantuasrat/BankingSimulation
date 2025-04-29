using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSimulation
{
    public class Transaction
    {
        public string AccountNumber {  get; set; }
        public string Type {  get; set; }
        public decimal Amount {  get; set; }
        public DateTime Date { get; set; }
        public string Note {  get; set; }
        
        public Transaction(string accountNumber,string type,decimal amount, string note = "")
        {
            AccountNumber = accountNumber;
            Type = type;
            Amount = amount;
            Date = DateTime.Now;
            Note = note;
        }

    }
}
