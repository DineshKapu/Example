using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using MOQ_Project;
namespace MOQ_Test
{
    public class CalculatorTests
    {
        [Test]
        public void Add_2_Nos_Returns_CoreectTotal()
        {
            var mockCalculator = new Mock<Calculator>();
            mockCalculator.Setup(s=>s.Add(2,3)).Returns(5);

            //act
            var result = mockCalculator.Object.Add(2,3);

            //assert
            Assert.Equals(5, result);
        }
    }
}
