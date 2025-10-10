using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai10
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            String actualResult = o.HuyChuoi("Hello ABC", 2, 1);
            String expectedResult = "llo ABC";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            String actualResult = o.HuyChuoi("Hello ABC", 2, 22);
            String expectedResult = "Hello ABC";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            String actualResult = o.HuyChuoi("Hello ABC", 17, 3);
            String expectedResult = "Hel";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            String actualResult = o.HuyChuoi("Hello ABC", 2, -5);
            String expectedResult = "Hello ABC";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            String actualResult = o.HuyChuoi("Hello ABC", -7, 4);
            String expectedResult = "Hello ABC";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            String actualResult = o.HuyChuoi("", 2, 1);
            String expectedResult = "";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
