using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai12
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 2, 8, 1, 9, 4 };
            int actualResult = o.Largest(a);
            int expectedResult = 9;
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] a = {};
            int actualResult = o.Largest(a);
            int expectedResult = int.MaxValue;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] a = {5};
            int actualResult = o.Largest(a);
            int expectedResult = 5;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] a = {2, 8, 1, 9, 4, 9, 8, 7, 9};
            int actualResult = o.Largest(a);
            int expectedResult = 9;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
