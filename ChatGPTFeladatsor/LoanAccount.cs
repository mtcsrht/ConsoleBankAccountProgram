using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTFeladatsor
{
    class LoanAccount : BankAccount
    {
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
    }
}
