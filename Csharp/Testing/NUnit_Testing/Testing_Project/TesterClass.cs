using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnit_Testing;

namespace Testing_Project
{
    [TestFixture]
    public class TesterClass
    {
            //arange
            //[SetUp]
            [Test]
            public void TestDepositMethod()
            {
            Account acc = new Account("12345");
            //act
            acc.Deposit(1000);

                //assert
                ClassicAssert.AreEqual(1000, acc.checkBalance());
            }
   
    }
}
