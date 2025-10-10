using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai09
    {
        [TestMethod()]
        public void TestMethod1()
        {
            String expected = "Error";
            String actual = MethodLibrary.Module03.Bai09(6, 4, 8);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            String expected = "10";
            String actual = MethodLibrary.Module03.Bai09(10, 12, 4);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            String expected = "14";
            String actual = MethodLibrary.Module03.Bai09(10, 14, 18);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            String expected = "12";
            String actual = MethodLibrary.Module03.Bai09(10, 16, 12);
            Assert.AreEqual(expected, actual);
        }
    }
}
