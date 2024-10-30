using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Thebluetshirt_45_Nhan
{
    [TestClass]
    public class UnitTestDangNhap_45_Nhan
    {
        // Tạo biến cục bộ STT_Ten: 45_Nhan
        IWebDriver driver_45_Nhan = new ChromeDriver();

        // Phương thức này dùng để khởi chạy trang chủ và xóa đi thanh div che phủ các nút và nhấn vào TÀI KHOẢN STT_Ten: 45_Nhan
        public void SetUp_45_Nhan()
        {
            // Chạy trang chủ STT_Ten: 45_Nhan
            driver_45_Nhan.Navigate().GoToUrl("https://thebluetshirt.com/");
            // Web nghỉ 3s STT_Ten: 45_Nhan
            Thread.Sleep(3000);
            // Xóa đi thanh div (nhấn vào dấu X) che phủ các nút STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.CssSelector("#popup-contact > div > div > div > " +
                "div.popup-right.flex-box.flex-c.justify-s > button")).Click();
            Thread.Sleep(3000);
            // Click vào nút "TÀI KHOẢN" để đăng nhập STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.LinkText("TÀI KHOẢN")).Click();
            Thread.Sleep(3000);

        }
        // Phương thức này dùng để đăng nhập trang web với biến STT_Ten: 45_Nhan
        public void DangNhap_45_Nhan(string email_45_Nhan, string pass_45_Nhan)
        {
            SetUp_45_Nhan();
            // Tự động nhập thông tin vào input Email STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.Id("customer_email")).SendKeys(email_45_Nhan);
            // Tự động nhập thông tin vào input Mật khẩu STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.XPath("//*[@id=\"customer_password\"]")).SendKeys(pass_45_Nhan);
            // Nhấn nút "ĐĂNG NHẬP" STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.ClassName("btn")).Click();
        }

        //Test với file DataPTB2_45_Nhan.csv STT_Ten: 45_Nhan
        // Tạo đối tượng TestContext STT_Ten: 45_Nhan
        public TestContext TestContext { get; set; }


        // Test case 1 email đúng pass đúng STT_Ten: 45_Nhan
        // Khai báo DataSource STT_Ten: 45_Nhan
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @".\DataLogin_45_Nhan\DataDNThanhCong_45_Nhan.csv",
            "DataDNThanhCong_45_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDNThanhCong_45_Nhan()
        {
            string e_45_Nhan = TestContext.DataRow[0].ToString();
            string p_45_Nhan = TestContext.DataRow[1].ToString();
            DangNhap_45_Nhan(e_45_Nhan,p_45_Nhan);
            // Nếu đăng nhập thành công đường dẫn url kì vọng sẽ là https://thebluetshirt.com/account STT_Ten: 45_Nhan
            string ex_45_Nhan = "https://thebluetshirt.com/account";
            // Lấy đường dẫn trang web sau khi nhấn "ĐĂNG NHẬP" STT_Ten: 45_Nhan
            string ac_45_Nhan = driver_45_Nhan.Url;
            // So sánh giữa 2 đường dẫn kiểu string STT_Ten: 45_Nhan
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
            // Đóng các sửa sổ liên quan
            driver_45_Nhan.Quit();
        }


        // Test case 2 email sai pass đúng/sai STT_Ten: 45_Nhan
        // Khai báo DataSource STT_Ten: 45_Nhan
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataLogin_45_Nhan\DataDNSaiEmail_45_Nhan.csv",
            "DataDNSaiEmail_45_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDNSaiEmail_45_Nhan()
        {
            string e_45_Nhan = TestContext.DataRow[0].ToString();
            string p_45_Nhan = TestContext.DataRow[1].ToString();
            DangNhap_45_Nhan(e_45_Nhan, p_45_Nhan);
            // Cảnh báo kì vọng STT_Ten: 45_Nhan
            string ex_45_Nhan = "Thông tin đăng nhập không hợp lệ.";
            // Lấy cảnh báo sau khi nhấn "ĐĂNG NHẬP" STT_Ten: 45_Nhan
            string ac_45_Nhan = driver_45_Nhan.FindElement(By.ClassName("errors")).Text;
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
            driver_45_Nhan.Quit();
        }


        // Test case 3 email đúng pass sai STT_Ten: 45_Nhan
        // Khai báo DataSource STT_Ten: 45_Nhan
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataLogin_45_Nhan\DataDNSaiMatKhau_45_Nhan.csv",
            "DataDNSaiMatKhau_45_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDNSaiMatKhau_45_Nhan()
        {
            string e_45_Nhan = TestContext.DataRow[0].ToString();
            string p_45_Nhan = TestContext.DataRow[1].ToString();
            DangNhap_45_Nhan(e_45_Nhan, p_45_Nhan);
            // Cảnh báo kì vọng STT_Ten: 45_Nhan
            string ex_45_Nhan = "Thông tin đăng nhập không hợp lệ.";
            // Lấy cảnh báo sau khi nhấn "ĐĂNG NHẬP" STT_Ten: 45_Nhan
            string ac_45_Nhan = driver_45_Nhan.FindElement(By.XPath("//*[@id=\"customer_login\"]/div[1]")).Text;
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
            driver_45_Nhan.Quit();
        }


        // Test case 4 email rỗng pass đúng/sai/rỗng STT_Ten: 45_Nhan
        // Khai báo DataSource STT_Ten: 45_Nhan
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataLogin_45_Nhan\DataDNEmailRong_45_Nhan.csv",
            "DataDNEmailRong_45_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDNEmailRong_45_Nhan()
        {
            string e_45_Nhan = TestContext.DataRow[0].ToString();
            string p_45_Nhan = TestContext.DataRow[1].ToString();
            DangNhap_45_Nhan(e_45_Nhan, p_45_Nhan);
            // Nếu có thuộc tính bắt buộc nhập STT_Ten: 45_Nhan
            string ex_45_Nhan = "true";
            // Kiểm tra thuộc tính của thanh input Email có bắt buộc nhập hay không  STT_Ten: 45_Nhan
            string ac_45_Nhan = driver_45_Nhan.FindElement(By.Id("customer_email")).GetAttribute("required");
            // Nếu ac_45_Nhan không null -> trả về giá trị True
            Assert.IsNotNull(ac_45_Nhan);
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan.ToLower());
            driver_45_Nhan.Quit();
        }


        // Test case 5 email đúng/sai/rỗng pass rỗng STT_Ten: 45_Nhan
        // Khai báo DataSource STT_Ten: 45_Nhan
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataLogin_45_Nhan\DataDNMatKhauRong_45_Nhan.csv",
            "DataDNMatKhauRong_45_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDNMatKhauRong_45_Nhan()
        {
            string e_45_Nhan = TestContext.DataRow[0].ToString();
            string p_45_Nhan = TestContext.DataRow[1].ToString();
            DangNhap_45_Nhan(e_45_Nhan, p_45_Nhan);
            // Nếu có thuộc tính bắt buộc nhập STT_Ten: 45_Nhan
            string ex_45_Nhan = "true";
            // Kiểm tra thuộc tính của thanh input Email có bắt buộc nhập hay không  STT_Ten: 45_Nhan
            string ac_45_Nhan = driver_45_Nhan.FindElement(By.CssSelector("#customer_password")).GetAttribute("required");
            // Nếu ac_45_Nhan không null -> trả về giá trị True
            Assert.IsNotNull(ac_45_Nhan);
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan.ToLower());
            driver_45_Nhan.Quit();
        }
    }
}
