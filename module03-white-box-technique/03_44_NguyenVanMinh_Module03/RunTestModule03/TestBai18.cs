using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai18
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai18("abc@domain"));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai18("a@b..com"));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai18("abc.def"));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsFalse(MethodLibrary.Module03.Bai18("a@.b.com"));
        }
        [TestMethod()]
        public void TestMethod5()
        {
            Assert.IsTrue(MethodLibrary.Module03.Bai18("alice.bob@example.com"));
        }
    }
}
