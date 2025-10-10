using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai11
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod1()
        {
            String actualResult = o.ThayThe("", "", "");
            String expectedResult = "";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            String actualResult = o.ThayThe("Truong dh cong nghiep", "", "dai hoc");
            String expectedResult = "Truong dh cong nghiep";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            String actualResult = o.ThayThe("Truong dh cong nghiep", "dh", "");
            String expectedResult = "Truong cong nghiep";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            String actualResult = o.ThayThe("Truong dh cong nghiep", "abc", "dai hoc");
            String expectedResult = "Truong dh cong nghiep";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            String actualResult = o.ThayThe("Truong dh cong nghiep", "dh", "dai hoc");
            String expectedResult = "Truong dai hoc cong nghiep";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            String actualResult = o.ThayThe("", "dh", "");
            String expectedResult = "";
            Assert.AreEqual(expectedResult, actualResult);
        }








    }
}
