using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai20
    {
        [TestMethod()]
        public void TestMethod1()
        {
            int expected = 1;
            int actual = MethodLibrary.Module03.Bai20('t');
            Assert.AreEqual(expected, actual);
        }
    }
}
