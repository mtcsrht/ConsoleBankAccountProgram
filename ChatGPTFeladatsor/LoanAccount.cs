using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTFeladatsor
{
    class LoanAccount : BankAccount
    {
        private decimal loanAmount;
        private decimal interestRate;

        public decimal LoanAmount => loanAmount;
        public decimal InterestRate => interestRate;
        public LoanAccount(string row)
        {
            string[] tmp = row.Split(';');

            accountNumber = tmp[1];
            accountHolderName = tmp[2];
            balance = decimal.Parse(tmp[3]);
            loanAmount = decimal.Parse(tmp[6]);
            interestRate = decimal.Parse(tmp[4]);
        }

        public override void UpdateBalance()
        {
            loanAmount *= 1 + interestRate;
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Loan amount: {LoanAmount}$\nInterest Rate: {InterestRate*100}%");
        }
    }
}
