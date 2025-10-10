using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai09_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai09.csv", "TestBai09#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long s0 = Convert.ToInt64(TestContext.DataRow[0]);
            long actualResult = o.Sum(s0, out long s);
            long expectedS = Convert.ToInt64(TestContext.DataRow[1]);
            long expectedResult = Convert.ToInt64(TestContext.DataRow[2]);

            Console.Write(actualResult);
            Console.Write(s);

            Assert.AreEqual(expectedS, s);
            //Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
