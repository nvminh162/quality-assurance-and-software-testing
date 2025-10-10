using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai03_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai03.csv", "TestBai03#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            int num = Convert.ToInt32(TestContext.DataRow[0]);
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            try
            {
                bool actualResult = o.primeCheck(num);
                bool expectedResult = Convert.ToBoolean(TestContext.DataRow[1]);
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception)
            {
                bool expectedException = TestContext.DataRow[1].ToString().ToLower() == "exception";
                Assert.IsTrue(expectedException, "Exception was expected but not thrown.");
            }
        }
    }
}
