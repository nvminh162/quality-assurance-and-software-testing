using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai14_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai14.csv", "TestBai14#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod1()
        {
            // Lấy dữ liệu từ TestContext
            string inputString = TestContext.DataRow["a"].ToString();
            int[] actualResult;

            // Chuyển đổi chuỗi thành mảng số nguyên
            if (string.IsNullOrEmpty(inputString))
            {
                actualResult = Array.Empty<int>();
            }
            else
            {
                actualResult = Array.ConvertAll(inputString.Split(','), int.Parse);
            }

            // Lấy chỉ số left và right
            int left = Convert.ToInt32(TestContext.DataRow["left"]);
            int right = Convert.ToInt32(TestContext.DataRow["right"]);

            // Kết quả mong đợi từ tệp CSV
            string expectedString = TestContext.DataRow["exp"].ToString();
            int[] expectedResult;

            if (string.IsNullOrEmpty(expectedString))
            {
                expectedResult = Array.Empty<int>();
            }
            else
            {
                expectedResult = Array.ConvertAll(expectedString.Split(','), int.Parse);
            }

            // Gọi phương thức QuickSort
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            o.QuickSort(actualResult, left, right);

            // So sánh kết quả thực tế với kết quả mong đợi
            CollectionAssert.AreEqual(expectedResult, actualResult);
        
        }
    }
}
