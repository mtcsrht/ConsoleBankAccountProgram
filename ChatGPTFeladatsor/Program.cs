using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChatGPTFeladatsor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            using (var sr = new StreamReader(@"..\..\src\dataset.txt"))
            {
                string line = "";
                _ = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line.Split(';')[0].Equals("Savings"))
                    {
                        accounts.Add(new SavingsAccount(line));
                    }
                    else if (line.Split(';')[0].Equals("Checking"))
                    {
                        accounts.Add(new CheckingAccount(line));
                    }
                    else if (line.Split(';')[0].Equals("Loan"))
                    {
                        accounts.Add(new SavingsAccount(line));
                    }
                }
            }
            Console.WriteLine(accounts.Count);

            accounts[0].Deposit(2000);
            accounts[1].Withdraw(500);
            accounts[2].Withdraw(300);

            foreach (var item in accounts)
            {
                item.UpdateBalance();
                item.DisplayAccountInfo();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
