using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai16
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai16("abcde"));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai16("abcdefghijk"));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai16("abcdef"));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(MethodLibrary.Module03.Bai16("abcde1"));
        }
    }
}
