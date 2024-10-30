using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PTB2_45_Nhan;

namespace PTB2Tester_45_Nhan
{
    [TestClass]
    public class UnitTestPTB2_45_Nhan
    {
        private GiaiPTB2_45_Nhan g_45_Nhan;
        // Phương trình ax2 + bx + c = 0, nếu a khác 0 STT_Ten: 45_Nhan
        //Test Case 1 phương trình có 2 nghiệm STT_Ten: 45_Nhan
        [TestMethod]
        public void Test2Nghiem_45_Nhan()
        {
            string ex_45_Nhan, ac_45_Nhan;
            g_45_Nhan = new GiaiPTB2_45_Nhan(1, 5, 4);
            // Kết quả mong đợi STT_Ten: 45_Nhan
            ex_45_Nhan = "-1; -4";
            // Kết quả thực tế STT_Ten: 45_Nhan
            ac_45_Nhan = g_45_Nhan.Giai_45_Nhan();
            // So sánh 2 kết quả có bằng nhau hay không STT_Ten: 45_Nhan
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
        }

        //Test Case 2 phương trình vô nghiệm STT_Ten: 45_Nhan
        [TestMethod]
        public void TestVoNghiem_45_Nhan()
        {
            string ex_45_Nhan, ac_45_Nhan;
            g_45_Nhan = new GiaiPTB2_45_Nhan(1, 2, 2);
            ex_45_Nhan = "Phuong trinh vo nghiem";
            ac_45_Nhan = g_45_Nhan.Giai_45_Nhan();
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
        }

        //Test Case 3 phương trình có nghiệm kép STT_Ten: 45_Nhan
        [TestMethod]
        public void TestNghiemKep_45_Nhan()
        {
            string ex_45_Nhan, ac_45_Nhan;
            g_45_Nhan = new GiaiPTB2_45_Nhan(1, 0, 0);
            ex_45_Nhan = "0";
            ac_45_Nhan = g_45_Nhan.Giai_45_Nhan();
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
        }

        //Test Case 4 kiểm thử trường hợp a = 0 STT_Ten: 45_Nhan
        [TestMethod]
        public void TestAKhac0_45_Nhan()
        {
            string ex_45_Nhan, ac_45_Nhan;
            g_45_Nhan = new GiaiPTB2_45_Nhan(0, 2, 3);
            ex_45_Nhan = "Phuong trinh bac 2, a khac 0";
            ac_45_Nhan = g_45_Nhan.Giai_45_Nhan();
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
        }

        //Test với file DataPTB2_45_Nhan.csv STT_Ten: 45_Nhan
        // Tạo đối tượng TestContext STT_Ten: 45_Nhan
        public TestContext TestContext { get; set; }
        // Khai báo DataSource STT_Ten: 45_Nhan
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_45_Nhan\DataPTB2_45_Nhan.csv",
            "DataPTB2_45_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestPTB2_45_Nhan()
        {
            // Đọc dữ liệu cột 1 STT_Ten: 45_Nhan
            double a_45_Nhan = double.Parse(TestContext.DataRow[0].ToString());
            // Đọc dữ liệu cột 2 STT_Ten: 45_Nhan
            double b_45_Nhan = double.Parse(TestContext.DataRow[1].ToString());
            // Đọc dữ liệu cột 3 STT_Ten: 45_Nhan
            double c_45_Nhan = double.Parse(TestContext.DataRow[2].ToString());
            // Đọc dữ liệu cột 4, là kết quả kì vọng STT_Ten: 45_Nhan
            string expected_45_Nhan = TestContext.DataRow[3].ToString();
            GiaiPTB2_45_Nhan giai_45_Nhan = new GiaiPTB2_45_Nhan(a_45_Nhan, b_45_Nhan, c_45_Nhan);
            // Kết quả thực tế STT_Ten: 45_Nhan
            string actual_45_Nhan = giai_45_Nhan.Giai_45_Nhan();
            // So sánh kết quả kì vọng và thực tế
            Assert.AreEqual(expected_45_Nhan, actual_45_Nhan);
        }
    }
}
