using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai07
    {
        // Valid partition
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.SolveQuadratic(0, 0, 0, out float x1, out float x2);
            String expectedResult = "Vô số nghiệm";
            float expectedX1 = float.NaN;
            float expectedX2 = float.NaN;
            Assert.AreEqual(expectedX1, x1);
            Assert.AreEqual(expectedX2, x2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.SolveQuadratic(1, 2, 5, out float x1, out float x2);
            String expectedResult = "Vô nghiệm";
            float expectedX1 = float.NaN;
            float expectedX2 = float.NaN;
            Assert.AreEqual(expectedX1, x1);
            Assert.AreEqual(expectedX2, x2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.SolveQuadratic(0, 0, 90, out float x1, out float x2);
            String expectedResult = "Vô nghiệm";
            float expectedX1 = float.NaN;
            float expectedX2 = float.NaN;
            Assert.AreEqual(expectedX1, x1);
            Assert.AreEqual(expectedX2, x2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.SolveQuadratic(0, 3, -6, out float x1, out float x2);
            String expectedResult = "Có 1 nghiệm";
            float expectedX1 = 2;
            float expectedX2 = float.NaN;
            Assert.AreEqual(expectedX1, x1);
            Assert.AreEqual(expectedX2, x2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.SolveQuadratic(1, 5, 6, out float x1, out float x2);
            String expectedResult = "Có 2 nghiệm phân biệt";
            float expectedX1 = -3;
            float expectedX2 = -2;
            Assert.AreEqual(expectedX1, x1);
            Assert.AreEqual(expectedX2, x2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String actualResult = o.SolveQuadratic(1, -4, 4, out float x1, out float x2);
            String expectedResult = "Có nghiệm kép";
            Console.WriteLine($"x1 = x2 = {x1}");
            Console.WriteLine(actualResult);
            float expectedX1 = 2;
            float expectedX2 = 2;
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedX1, x1);
            Assert.AreEqual(expectedX2, x2);
        }




    }
}
