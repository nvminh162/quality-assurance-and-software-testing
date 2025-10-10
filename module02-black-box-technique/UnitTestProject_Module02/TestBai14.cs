using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai14
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod1()
        {
            int[] actualResult = new int[] { };
            int[] expectedResult = new int[] { };
            o.QuickSort(actualResult, 1, 2);
            // actualResult.SequenceEqual(expectedResult);
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] actualResult = new int[] { 5 };
            int[] expectedResult = new int[] { 5 };
            o.QuickSort(actualResult, 1, 2);
            // actualResult.SequenceEqual(expectedResult);
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] actualResult = new int[] { 1, -2, 3, -4, 5 };
            int[] expectedResult = new int[] { -4, -2, 1, 3, 5 };
            o.QuickSort(actualResult, 2, 4);
            // actualResult.SequenceEqual(expectedResult);
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] actualResult = new int[] { 1, -2, 3, -4, 5 };
            int[] expectedResult = new int[] { 1, -2, 3, -4, 5 };
            o.QuickSort(actualResult, 7, 4);
            // actualResult.SequenceEqual(expectedResult);
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }
    }
}
