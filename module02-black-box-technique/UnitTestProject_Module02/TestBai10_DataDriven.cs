using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai10_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai10.csv", "TestBai10#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String s = Convert.ToString(TestContext.DataRow[0]);
            int n = Convert.ToInt32(TestContext.DataRow[1]);
            int p = Convert.ToInt32(TestContext.DataRow[2]);
            String actualResult = o.HuyChuoi(s, n, p);
            String expectedResult = Convert.ToString(TestContext.DataRow[3]);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
