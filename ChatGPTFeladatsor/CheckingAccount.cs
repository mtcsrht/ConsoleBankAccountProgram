using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTFeladatsor
{
    class CheckingAccount : BankAccount
    {
        private  decimal overdraftLimit;

        public decimal OverdraftLimit { get => overdraftLimit;}

        public CheckingAccount(string row)
        {
            string[] tmp = row.Split(';');

            accountNumber = tmp[1];
            accountHolderName = tmp[2];
            balance = decimal.Parse(tmp[3]);
            overdraftLimit = decimal.Parse("-" +tmp[5]);
        }

        public override void Withdraw(decimal amount)
        {
            if (balance-amount < OverdraftLimit)
            {
                throw new Exception("You have exceeded the overdraft limit!");
            }
            else
            {
                balance = balance - amount;
            }
        }
        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit}$");
        }
    }
}
