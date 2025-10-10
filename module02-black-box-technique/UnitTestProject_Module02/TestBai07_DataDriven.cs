using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai07_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai07.csv", "TestBai07#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);
            String actualResult = o.SolveQuadratic(0, 0, 0, out float x1, out float x2).Normalize();
            String expectedResult = Convert.ToString(TestContext.DataRow[3]).Normalize();
            float expectedX1 = Convert.ToSingle(TestContext.DataRow[4]);
            float expectedX2 = Convert.ToSingle(TestContext.DataRow[5]);
            Assert.AreEqual(expectedX1, x1);
            Assert.AreEqual(expectedX2, x2);
            //Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
