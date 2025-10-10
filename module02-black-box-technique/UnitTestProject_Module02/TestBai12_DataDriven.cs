using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Module02
{
    [TestClass]
    public class TestBai12_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\TestBai12.csv", "TestBai12#csv",
            DataAccessMethod.Sequential), TestMethod]
        public void TestMethod()
        {
            // Lấy dữ liệu từ TestContext
            string inputString = TestContext.DataRow["Input"].ToString();
            int expectedResult = Convert.ToInt32(TestContext.DataRow["Expected"]);

            // Chuyển đổi chuỗi thành mảng số nguyên
            int[] inputArray;

            // Kiểm tra nếu chuỗi rỗng
            if (string.IsNullOrWhiteSpace(inputString))
            {
                inputArray = Array.Empty<int>(); // Sử dụng mảng rỗng
            }
            else
            {
                inputArray = Array.ConvertAll(inputString.Split(','), int.Parse);
            }

            // Gọi phương thức Largest
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int actualResult = o.Largest(inputArray);

            // Kiểm tra kết quả
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
