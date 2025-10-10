using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai12
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Exception expectedException = null;
            try
            {
                float actual = MethodLibrary.Module03.Bai12(-1, 1, 2, 3);
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
            float expected = 80;
            float actual = MethodLibrary.Module03.Bai12(80, 1, 2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            float expected = 140;
            float actual = MethodLibrary.Module03.Bai12(120, 1, 2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            float expected = 260;
            float actual = MethodLibrary.Module03.Bai12(170, 1, 2, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
