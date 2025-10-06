using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai07
    {
        [TestMethod()]
        public void TestMethod1()
        {
            ushort year = 2025;
            byte month = 10;
            int expected = 31;
            int actual = MethodLibrary.Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            ushort year = 2025;
            byte month = 4;
            int expected = 30;
            int actual = MethodLibrary.Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            ushort year = 2025;
            byte month = 13;
            int expected = 0;
            int actual = MethodLibrary.Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            ushort year = 2000;
            byte month = 2;
            int expected = 29;
            int actual = MethodLibrary.Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod5()
        {
            ushort year = 1900;
            byte month = 2;
            int expected = 28;
            int actual = MethodLibrary.Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod6()
        {
            ushort year = 2024;
            byte month = 2;
            int expected = 29;
            int actual = MethodLibrary.Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod7()
        {
            ushort year = 2025;
            byte month = 2;
            int expected = 28;
            int actual = MethodLibrary.Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
    }
}
