using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai03
    {
        //Test return True False
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.primeCheck(17);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.primeCheck(25);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.primeCheck(0);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.primeCheck(1000);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Test return Exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            o.primeCheck(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
                o.primeCheck(1020);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Exception expectedException = null;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            try
            {
                o.primeCheck(-1);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Exception expectedException = null;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            try
            {
                o.primeCheck(1001);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
