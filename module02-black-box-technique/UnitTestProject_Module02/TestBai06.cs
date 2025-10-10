using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai06
    {
        // Valid partition
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(2, 4, 5);
            String ExpectedResult = "Scalene";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(2, 2, 2);
            String ExpectedResult = "Equilateral";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(4, 4, 2);
            String ExpectedResult = "Isosceles";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(2, 4, 4);
            String ExpectedResult = "Isosceles";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(4, 2, 4);
            String ExpectedResult = "Isosceles";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        // Invalid partition
        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(-2, 5, 6);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(2, -5, 6);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(2, 5, -6);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(1, 2, 5);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(1, 5, 2);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(5, 2, 1);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        // Valid boundary
        [TestMethod]
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(1, 1, 1);
            String ExpectedResult = "Equilateral";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(2, 2, 2);
            String ExpectedResult = "Equilateral";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        // Invalid boundary

        [TestMethod]
        public void TestMethod14()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(0, 0, 0);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod15()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(3, 2, 5);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod16()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(3, 5, 2);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod17()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.Triangle(5, 3, 2);
            String ExpectedResult = "";
            Assert.AreEqual(ExpectedResult, actualResult);
        }
    }
}
