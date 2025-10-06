using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai06
    {
        [TestMethod()]
        public void TestMethod1()
        {
            double sum = 16;
            double count = 1;
            double expected = 16;
            double actual = MethodLibrary.Module03.Bai06(sum, count);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            double sum = 16;
            double count = 2;
            double expected = 8;
            double actual = MethodLibrary.Module03.Bai06(sum, count);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            double sum = 16;
            double count = -2;
            double expected = 0;
            double actual = MethodLibrary.Module03.Bai06(sum, count);

            Assert.AreEqual(expected, actual);
        }
    }
}
