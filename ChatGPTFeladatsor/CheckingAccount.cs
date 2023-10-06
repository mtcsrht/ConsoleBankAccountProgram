using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTFeladatsor
{
    class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }
    }
}
