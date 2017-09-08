using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 232;
            var b = 23;
            var c = Operations.Addition(a, b);
            Assert.IsTrue(c > 1);
        }
    }
}
