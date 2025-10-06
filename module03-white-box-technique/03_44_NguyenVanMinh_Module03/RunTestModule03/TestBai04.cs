using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai04
    {
        [TestMethod()]
        public void TestMethod1()
        {
            int expected = 7;
            int actual = MethodLibrary.Module03.Bai04(5, 6, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            int expected = 7;
            int actual = MethodLibrary.Module03.Bai04(7, 6, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            int expected = 0;
            int actual = MethodLibrary.Module03.Bai04(0, 6, 7);

            Assert.AreEqual(expected, actual);
        }
    }
}
