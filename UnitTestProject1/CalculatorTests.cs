using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPNETCoreTest1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETCoreTest1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            Calculator calc = new Calculator();
            int result = calc.Sum(1, 3); // result should be 4
            Assert.AreEqual(4, result);

            result = calc.Sum(10, 3); // result should be 18
            Assert.AreEqual(16, result);
        }
    }
}