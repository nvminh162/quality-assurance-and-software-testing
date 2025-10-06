using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai03
    {
        [TestMethod()]
        public void TestMethod1()
        {
            double mean_actual;
            double mean_exp = 5;
            int max_exp = 6;
            int max_actual = MethodLibrary.Module03.Bai03(6, 5, 4, out mean_actual);
            Assert.AreEqual(max_exp, max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            double mean_actual;
            double mean_exp = 6;
            int max_exp = 7;
            int max_actual = MethodLibrary.Module03.Bai03(6, 5, 7, out mean_actual);
            Assert.AreEqual(max_exp, max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            double mean_actual;
            double mean_exp = 5;
            int max_exp = 6;
            int max_actual = MethodLibrary.Module03.Bai03(5, 6, 4, out mean_actual);
            Assert.AreEqual(max_exp, max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }

        [TestMethod()]
        public void TestMethod4()
        {
            double mean_actual;
            double mean_exp = 6;
            int max_exp = 7;
            int max_actual = MethodLibrary.Module03.Bai03(5, 6, 7, out mean_actual);
            Assert.AreEqual(max_exp, max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }
    }
}
