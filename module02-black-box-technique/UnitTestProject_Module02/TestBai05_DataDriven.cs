using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai05_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai05.csv", "TestBai05#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String sbin = Convert.ToString(TestContext.DataRow[0]);
            try
            {
                long expectedResult = Convert.ToInt64(TestContext.DataRow[1]);
                long actualResult = o.BinToDec(sbin);
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception)
            {
                bool actualResultException = TestContext.DataRow[1].ToString().ToLower() == "formatexception";
                Assert.IsTrue(actualResultException);
            }

        }
    }
}
