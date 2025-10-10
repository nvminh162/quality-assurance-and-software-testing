using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai04
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.IsLeapYear(2000);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.IsLeapYear(-1996);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.IsLeapYear(2025);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4() 
        {
            Exception expectedException = null;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            try
            {
                o.IsLeapYear(1400);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool actualResult = o.IsLeapYear(1582);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Exception expectedException = null;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            try
            {
                o.IsLeapYear(1581);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
