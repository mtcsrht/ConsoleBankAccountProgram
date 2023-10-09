using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTFeladatsor
{
    class BankAccount
    {
        protected decimal balance;
        protected string accountHolderName;
        protected string accountNumber;

        protected string AccountNumber => accountNumber; 
        protected string AccountHolderName => accountHolderName; 
        protected decimal Balance => balance;


        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        public virtual void UpdateBalance()
        {
        }
        public virtual void DisplayAccountInfo()
        {
            Console.Write($"Account Number: {AccountNumber}\nAccount Holder Name: {AccountHolderName}\nBalance: {Balance:0.00}$\n");
        }
    }
}
