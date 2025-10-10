using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai05
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long actualResult = o.BinToDec("1010");
            long expectedResult = 10;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            o.BinToDec(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            o.BinToDec("123456");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            o.BinToDec("1A001");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            o.BinToDec("10 20");
        }
    }
}
