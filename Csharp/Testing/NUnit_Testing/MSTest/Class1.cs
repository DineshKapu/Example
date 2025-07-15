using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using NUnit_Testing;
namespace MSTest
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void Method1()
        {
            Debug.WriteLine("Test Method 1");
        }
        [TestMethod]
        public void Withdraw()
        {
            Account acc = new Account("1111");
            acc.Deposit(100);
            acc.Withdraw(50000);
            acc.checkBalance();
        }
        [TestMethod]
        public void TestAccountWithdrawal_Exception()
        {
            Assert.Throws<Exception>(Withdraw);
            //Assert.IsFalse

        }
    }
}
