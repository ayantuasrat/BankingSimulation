using System;

namespace BankingSimulation
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name, decimal initialDeposit)
            : base(name, initialDeposit)
        {
        }

        public override void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override bool Transfer(Account toAccount, decimal amount)
        {
            if (Withdraw(amount))
            {
                toAccount.Deposit(amount);
                return true;
            }
            return false;
        }
    }
} 