using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai10
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai10(0, 2, 3));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai10(1, 2, 5));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai10(1, 5, 2));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai10(2, 3, 6));
        }
        [TestMethod()]
        public void TestMethod5()
        {
            Assert.IsTrue(MethodLibrary.Module03.Bai10(3, 4, 5));
        }
    }
}
