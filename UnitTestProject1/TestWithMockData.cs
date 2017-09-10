using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class TestWithMockData
    {
        [TestMethod]
        public void TestMockConnection()
        {
            Mock<IDbConnection> connection = new Mock<IDbConnection>();
            connection.Setup(x => x.Open()).Callback(this.Open);
            connection.Object.Open();
        }

        public void Open()
        {

        }
    }
}
