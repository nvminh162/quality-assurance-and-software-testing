using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai17
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai17(2023, 14, 15));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai17(2023, 10, 0));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai17(2023, 2, 30));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(MethodLibrary.Module03.Bai17(2023, 8, 23));
        }
    }
}
