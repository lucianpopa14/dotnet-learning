using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class BankAccount
    {
        public int AccountNumber;
        public double Balance=0;
        public static double InterestRate;
        public string AccountType = "Checking";
        public readonly string CustomerId;
        private static int s_nextAccountNumber = 1;

        static BankAccount()
        {
            Random random = new Random();
            s_nextAccountNumber = random.Next(10000000, 20000000);
            InterestRate = 0;
        }

        public BankAccount(string customerIdNumber)
        {
            this.AccountNumber = s_nextAccountNumber++;
            this.CustomerId = customerIdNumber;
        }
        public BankAccount(string customerIdNumber, double balance, string accountType)
        {
            this.AccountNumber = s_nextAccountNumber++;
            this.CustomerId = customerIdNumber;
            this.Balance = balance;
            this.AccountType = accountType;
        }
    }
}
