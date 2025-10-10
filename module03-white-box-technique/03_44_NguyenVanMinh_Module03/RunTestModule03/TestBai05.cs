using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai05
    {
        [TestMethod()]
        public void TestMethod1()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(1, 2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(3, 1, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(2, 3, 1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            String expected = "Triangle is Scalene";
            String actual = MethodLibrary.Module03.Bai05(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod5()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(3, 3, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod6()
        {
            String expected = "Triangle is Isosceles";
            String actual = MethodLibrary.Module03.Bai05(3, 3, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod7()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(1, 3, 1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod8()
        {
            String expected = "Triangle is Isosceles";
            String actual = MethodLibrary.Module03.Bai05(3, 2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod9()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(7, 3, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod10()
        {
            String expected = "Triangle is Isosceles";
            String actual = MethodLibrary.Module03.Bai05(3, 2, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod11()
        {
            String expected = "Triangle is Equilateral";
            String actual = MethodLibrary.Module03.Bai05(3, 3, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
