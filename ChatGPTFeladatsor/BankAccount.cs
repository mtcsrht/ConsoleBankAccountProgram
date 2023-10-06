using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTFeladatsor
{
    class BankAccount
    {

        private decimal balance;

        readonly string AccountNumber;
        readonly string AccountHolderName;
        readonly decimal Balance;

        public virtual void Deposit(decimal amount)
        {

        }

        public virtual void Withdraw(decimal amount)
        {

        }
        public virtual void DisplayAccountInfo()
        {
            
        }
    }
}
