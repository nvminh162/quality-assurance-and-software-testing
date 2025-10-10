using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RunTestModule03
{
    [TestClass]
    public class TestBai11
    {
        [TestMethod]
        public void TestMethod1() // invalid -> return false
        {
            float w = -1f, h = 2f, ww = 3f, wh = 4f, x = float.NaN, y = float.NaN;

            Assert.IsFalse(MethodLibrary.Module03.Bai11(out x, out y, w, h, ww, wh));
            Assert.IsTrue(float.IsNaN(x));
            Assert.IsTrue(float.IsNaN(y));
        }

        [TestMethod]
        public void TestMethod2() // w>ww, h>wh -> x=0, y=0
        {
            float w = 5f, h = 6f, ww = 4f, wh = 5f, x, y;

            Assert.IsTrue(MethodLibrary.Module03.Bai11(out x, out y, w, h, ww, wh));
            Assert.AreEqual(0f, x, 1e-6f);
            Assert.AreEqual(0f, y, 1e-6f);
        }

        [TestMethod]
        public void TestMethod3() // w>ww, h<=wh -> x=0, y=(wh-h)/2
        {
            float w = 5f, h = 2f, ww = 4f, wh = 5f, x, y;

            Assert.IsTrue(MethodLibrary.Module03.Bai11(out x, out y, w, h, ww, wh));
            Assert.AreEqual(0f, x, 1e-6f);
            Assert.AreEqual(1.5f, y, 1e-6f);
        }

        [TestMethod]
        public void TestMethod4() // w<=ww, h>wh -> x=(ww-w)/2, y=0
        {
            float w = 3f, h = 6f, ww = 5f, wh = 5f, x, y;

            Assert.IsTrue(MethodLibrary.Module03.Bai11(out x, out y, w, h, ww, wh));
            Assert.AreEqual(1f, x, 1e-6f);
            Assert.AreEqual(0f, y, 1e-6f);
        }

        [TestMethod]
        public void TestMethod5() // w<=ww, h<=wh -> x=(ww-w)/2, y=(wh-h)/2
        {
            float w = 3f, h = 4f, ww = 5f, wh = 5f, x, y;

            Assert.IsTrue(MethodLibrary.Module03.Bai11(out x, out y, w, h, ww, wh));
            Assert.AreEqual(1f, x, 1e-6f);
            Assert.AreEqual(0.5f, y, 1e-6f);
        }
    }
}
