using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    public class Account
    {
        string accountNo;
        float balance;
        public Account(string accno)
        {
            accountNo = accno;
        }
        public void Deposit(float amt)
        {
            balance += amt;
        }
        public void Withdraw(float amt)
        {
            if (balance >= amt)
            {
                balance -= amt;
            }
            else
                throw new Exception("Not Enough Balance..");
        }
        public float checkBalance()
        {
            return balance;
        }
    }
}
