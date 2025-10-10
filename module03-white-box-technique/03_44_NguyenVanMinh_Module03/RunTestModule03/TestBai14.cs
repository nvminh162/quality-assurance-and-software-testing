using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai14
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Exception expectedException = null;
            try
            {
                float x, y, s;
                Boolean actual = MethodLibrary.Module03.Bai14(-1, 5, out s, out x, out y);
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
            float x, y, s;
            Assert.IsTrue(MethodLibrary.Module03.Bai14(10, 6, out s, out x, out y));
            Assert.AreEqual(2, x);
            Assert.AreEqual(0, y);
            Assert.AreEqual(6, s);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            float x, y, s;
            Assert.IsTrue(MethodLibrary.Module03.Bai14(6, 10, out s, out x, out y));
            Assert.AreEqual(0, x);
            Assert.AreEqual(2, y);
            Assert.AreEqual(6, s);
        }
    }
}
