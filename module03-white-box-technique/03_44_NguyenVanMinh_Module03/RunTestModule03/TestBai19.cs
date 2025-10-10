using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai19
    {
        [TestMethod()]
        public void TestMethod1()
        {
            sbyte expected = -1;
            sbyte actual = MethodLibrary.Module03.Bai19(-7, 56);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            sbyte expected = -1;
            sbyte actual = MethodLibrary.Module03.Bai19(168, -8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            sbyte expected = 2;
            sbyte actual = MethodLibrary.Module03.Bai19(180, 55);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod4()
        {
            sbyte expected = 1;
            sbyte actual = MethodLibrary.Module03.Bai19(160, 60);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod5()
        {
            sbyte expected = 0;
            sbyte actual = MethodLibrary.Module03.Bai19(170, 55);
            Assert.AreEqual(expected, actual);
        }
    }
}
