using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai09
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        // Valid partition
        [TestMethod]
        public void TestMethod1()
        {
            long actualResult = o.Sum(9, out long s);
            long expectedResult = 4;
            long expectedS = 10;
            Console.Write(actualResult);
            Console.Write(s);
            Assert.AreEqual(expectedS, s);
            //Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            long actualResult = o.Sum(-20, out long s);
            long expectedResult = 1L;
            long expectedS = 0;
            Console.Write(actualResult);
            Console.Write(s);
            Assert.AreEqual(expectedS, s);
            //Assert.AreEqual(expectedResult, actualResult);
        }

        // Valid boundary
        [TestMethod]
        public void TestMethod3()
        {
            long actualResult = o.Sum(1, out long s);
            long expectedResult = 2;
            long expectedS = 3;
            Assert.AreEqual(expectedS, s);
            //Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            long actualResult = o.Sum(0, out long s);
            long expectedResult = 1;
            long expectedS = 1;
            Assert.AreEqual(expectedS, s);
            //Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
