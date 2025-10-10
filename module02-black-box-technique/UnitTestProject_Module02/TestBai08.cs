using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai08
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        // Valid partition
        [TestMethod]
        public void TestMethod01()
        {
            double actualResult = o.TinhTienDien(10, 20);
            Console.WriteLine(actualResult);
            double expectedResult = 16324;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod02()
        {
            double actualResult = o.TinhTienDien(20, 100);
            Console.WriteLine(actualResult);
            double expectedResult = 132209;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod03()
        {
            double actualResult = o.TinhTienDien(100, 250);
            Console.WriteLine(actualResult);
            double expectedResult = 264165;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod04()
        {
            double actualResult = o.TinhTienDien(250, 500);
            Console.WriteLine(actualResult);
            double expectedResult = 485705;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod05()
        {
            double actualResult = o.TinhTienDien(250, 600);
            Console.WriteLine(actualResult);
            double expectedResult = 746680;
            Console.WriteLine(expectedResult);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod06()
        {
            double actualResult = o.TinhTienDien(250, 700);
            Console.WriteLine(actualResult);
            double expectedResult = 1026630;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        // Invalid partition
        [TestMethod]
        public void TestMethod07()
        {
            double actualResult = o.TinhTienDien(-10, 20);
            Console.WriteLine(actualResult);
            double expectedResult = -1;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod08()
        {
            double actualResult = o.TinhTienDien(80, 20);
            Console.WriteLine(actualResult);
            double expectedResult = -1;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        // Valid boundary
        [TestMethod]
        public void TestMethod09()
        {
            double actualResult = o.TinhTienDien(0, 0);
            Console.WriteLine(actualResult);
            double expectedResult = 0;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod10()
        {
            double actualResult = o.TinhTienDien(100, 100);
            Console.WriteLine(actualResult);
            double expectedResult = 0;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        // Invalid boundary
        [TestMethod]
        public void TestMethod11()
        {
            double actualResult = o.TinhTienDien(-1, 50);
            Console.WriteLine(actualResult);
            double expectedResult = -1;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestMethod12()
        {
            double actualResult = o.TinhTienDien(20, 19);
            Console.WriteLine(actualResult);
            double expectedResult = -1;
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }
    }
}
