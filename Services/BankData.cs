﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSimulation
{//DO THE DATABASE LATER BUT FOR NOW THIS IS WHERE THE ACCOUNTS ARE TEMPORARILY STORED

    public static class BankData
    {
        public static List<Account> Accounts = new List<Account>();
        public static List<Loan> Loans = new List<Loan>();
        public static List<Transaction> Transactions = new List<Transaction>();
    }
}
