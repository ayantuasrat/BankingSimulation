using System;

namespace BankingSimulation
{
    public interface IAccountOperations
    {
        void Deposit(decimal amount);
        bool Withdraw(decimal amount);
        bool Transfer(Account toAccount, decimal amount);
    }
} 