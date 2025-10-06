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
            String expected = "Triangle is Equilateral";
            String actual = MethodLibrary.Module03.Bai05(9, 9, 9);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            String expected = "Triangle is Isosceles";
            String actual = MethodLibrary.Module03.Bai05(8, 6, 6);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(8, 3, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(5, 12, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod5()
        {
            String expected = "Triangle is Isosceles";
            String actual = MethodLibrary.Module03.Bai05(5, 8, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod6()
        {
            String expected = "Triangle is Isosceles";
            String actual = MethodLibrary.Module03.Bai05(5, 5, 8);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod7()
        {
            String expected = "Triangle is Isosceles";
            String actual = MethodLibrary.Module03.Bai05(5, 5, 12);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod8()
        {
            String expected = "Triangle is Scalene";
            String actual = MethodLibrary.Module03.Bai05(5, 6, 7);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod9()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(5, 14, 6);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod10()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(14, 5, 6);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod11()
        {
            String expected = "Not a Triangle";
            String actual = MethodLibrary.Module03.Bai05(5, 6, 14);
            Assert.AreEqual(expected, actual);
        }
    }
}
