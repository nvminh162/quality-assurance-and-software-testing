using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai08_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai08.csv", "TestBai08#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int soCu = Convert.ToInt32(TestContext.DataRow[0]);
            int soMoi = Convert.ToInt32(TestContext.DataRow[1]);

            double actualResult = o.TinhTienDien(soCu, soMoi);
            Console.WriteLine(actualResult);
            double expectedResult = Convert.ToDouble(TestContext.DataRow[2]);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }
    }
}
