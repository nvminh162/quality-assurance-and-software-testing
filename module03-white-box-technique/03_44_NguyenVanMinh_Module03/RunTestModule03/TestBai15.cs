using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai15
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai15(99));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsTrue(MethodLibrary.Module03.Bai15(2000));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai15(1900));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(MethodLibrary.Module03.Bai15(2024));
        }
        [TestMethod()]
        public void TestMethod5()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai15(2023));
        }
    }
}
