using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai04_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai04.csv", "TestBai04#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int n = Convert.ToInt32(TestContext.DataRow[0]);
            bool expectedResult = Convert.ToBoolean(TestContext.DataRow[1]);
            try
            {
                bool actualResult = o.IsLeapYear(n);
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception)
            {
                bool actualResultException = TestContext.DataRow[1].ToString().ToLower() == "exception";
                Assert.IsTrue(actualResultException, "Exception was expected but not thrown.");
            }
        }
    }
}
