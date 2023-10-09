using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTFeladatsor
{
    class SavingsAccount : BankAccount
    {
        private decimal interestRate;

        public decimal InterestRate => interestRate;
        public SavingsAccount(string row)
        {
            string[] tmp = row.Split(';');

            accountNumber = tmp[1];
            accountHolderName = tmp[2];
            balance = decimal.Parse(tmp[3]);
            interestRate = decimal.Parse(tmp[4]);
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Interest Rate: {InterestRate * 100}%");
        }
        public override void UpdateBalance()
        {
            balance *= 1 + interestRate;
        }
    }
}
