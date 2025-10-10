using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai11_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai11.csv", "TestBai11#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String s1 = Convert.ToString(TestContext.DataRow[0]);
            String s2 = Convert.ToString(TestContext.DataRow[1]);
            String s3 = Convert.ToString(TestContext.DataRow[2]);
            try
            {
                String actualResult = o.ThayThe(s1, s2, s3);
                String expectedResult = Convert.ToString(TestContext.DataRow[3]);
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch(Exception)
            {
                bool actualResultException = TestContext.DataRow[3].ToString().ToLower() == "exception";
                Assert.IsTrue(actualResultException);
            }
           
        }
    }
}
