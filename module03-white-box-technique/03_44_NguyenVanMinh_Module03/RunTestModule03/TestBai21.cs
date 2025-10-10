using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai21
    {
        [TestMethod()]
        public void TestMethod1()
        {
            long expected = 427;
            long actual = MethodLibrary.Module03.Bai21("1aBx");
            Assert.AreEqual(expected, actual);
        }
    }
}
