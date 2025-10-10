using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai13
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Exception expectedException = null;
            try
            {
                Boolean actual = MethodLibrary.Module03.Bai13(5, 1, 3, 2, 0, 0);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai13(0, 0, 10, 10, -1, 5));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai13(0, 0, 10, 10, 5, 11));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(MethodLibrary.Module03.Bai13(0, 0, 10, 10, 5, 5));
        }
    }
}
