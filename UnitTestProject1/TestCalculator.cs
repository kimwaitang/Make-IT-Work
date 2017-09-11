using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAddition()
        {
            var a = 232;
            var b = 23;
            var c = Operations.Addition(a, b);
            Assert.IsTrue(c > 1);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestException()
        {
            object o = null;
            Debug.WriteLine("This statement generate an null reference exception:" + o.ToString());
        }
    }
}
