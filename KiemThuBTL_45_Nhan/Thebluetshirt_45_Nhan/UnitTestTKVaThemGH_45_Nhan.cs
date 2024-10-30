using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Thebluetshirt_45_Nhan
{
    [TestClass]
    public class UnitTestTKVaThemGH_45_Nhan
    {
        // Biến cục bộ
        IWebDriver driver_45_Nhan = new ChromeDriver();
        // Phương thức này dùng để khởi chạy trang chủ và xóa đi thanh div che phủ các nút và nhấn vào TÌM KIẾM STT_Ten: 45_Nhan
        public void SetUpTK_45_Nhan()
        {
            // Chạy trang chủ STT_Ten: 45_Nhan
            driver_45_Nhan.Navigate().GoToUrl("https://thebluetshirt.com/");
            // Web nghỉ 3s STT_Ten: 45_Nhan
            Thread.Sleep(3000);
            // Xóa đi thanh div (nhấn vào dấu X) che phủ các nút STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.CssSelector("#popup-contact > div > div > div > " +
                "div.popup-right.flex-box.flex-c.justify-s > button")).Click();
            Thread.Sleep(3000);
            // Click nút "TÌM KIẾM" STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.ClassName("header-search-btn")).Click();
            Thread.Sleep(3000);

        }

        // Phương thức này dùng để tìm kiếm sản phẩm với biến STT_Ten: 45_Nhan
        public void TimKiem_45_Nhan(string key_45_Nhan)
        {
            SetUpTK_45_Nhan();
            // Nhập từ khóa tìm kiếm STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.CssSelector("body > div.mm-page > header > div.nav-top > " +
                "div.search-top.active > div > " +
                "div.search-form-box.flex-box.align-c.justify-c > form > input")).SendKeys(key_45_Nhan);
            // Trên thanh search nhấn nút enter của bàn phím STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);
        }

        // Phương thức này dùng để thêm sản phẩm vào giỏ hàng STT_Ten: 45_Nhan
        public void ThemSP_45_Nhan()
        {
            // Nhấn vào thanh div chứa sản phẩm STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.XPath("//*[@id=\"search\"]/div[2]/div[2]/div/div/div/div/div[1]/div")).Click();
            Thread.Sleep(3000);
            // Thực hiện 5 lần nhấn nút xuống trên bàn phím STT_Ten: 45_Nhan
            for (int i_45_Nhan =0;i_45_Nhan<5;i_45_Nhan++)
            {
                driver_45_Nhan.FindElement(By.TagName("body")).SendKeys(Keys.ArrowDown);
            }
            Thread.Sleep(3000);
            // Click nút thêm vào giỏ STT_Ten: 45_Nhan
            driver_45_Nhan.FindElement(By.Id("add-to-cart")).Click();
            Thread.Sleep(3000);
        }

        // Test case 1 STT_Ten: 45_Nhan
        [TestMethod]
        public void TestTKCoSPThemGH_45_Nhan()
        {
            string kw_45_Nhan = "blazer";
            TimKiem_45_Nhan(kw_45_Nhan);
            // Kết quả tìm kiếm STT_Ten: 45_Nhan
            string kq_45_Nhan = driver_45_Nhan.FindElement(By.XPath("//*[@id=\"search\"]/div[2]/div[1]/div/div[2]/div[1]")).Text;
            // Lấy chữ đầu tiên chuyển thành số STT_Ten: 45_Nhan
            int ac_45_Nhan = int.Parse(kq_45_Nhan.Substring(0, kq_45_Nhan.IndexOf(' ')));
            // Nếu số lớn hơn 0 thì trả về true STT_Ten: 45_Nhan
            Assert.IsTrue(ac_45_Nhan > 0);
            // Nếu tìm kiếm thành công -> thêm sản phẩm vào giỏ hàng STT_Ten: 45_Nhan
            if (true) 
            {
                ThemSP_45_Nhan();
            }
            driver_45_Nhan.Quit();
        }

        // Test case 2 STT_Ten: 45_Nhan
        [TestMethod]
        public void TestTKKhongSP_45_Nhan()
        {
            string kw_45_Nhan = "lovito";
            TimKiem_45_Nhan(kw_45_Nhan);
            // Lấy dòng chữ sau khi nhấn enter STT_Ten: 45_Nhan
            string kq_45_Nhan = driver_45_Nhan.FindElement(By.XPath("//*[@id=\"search\"]/div[2]/div[1]/div/div[2]/div[1]")).Text;
            // Lấy chữ đầu tiên chuyển thành số STT_Ten: 45_Nhan
            int ac_45_Nhan = int.Parse(kq_45_Nhan.Substring(0, kq_45_Nhan.IndexOf(' ')));
            // Nếu số = 0 thì trả về true STT_Ten: 45_Nhan
            Assert.IsTrue(ac_45_Nhan == 0);
            driver_45_Nhan.Quit();
        }

        // Test case 3 STT_Ten: 45_Nhan
        [TestMethod]
        public void TestTKRong_45_Nhan()
        {
            string kw_45_Nhan = "";
            TimKiem_45_Nhan(kw_45_Nhan);
            // Cảnh báo mong muốn STT_Ten: 45_Nhan
            string ex_45_Nhan = "Vui lòng nhập từ khóa tìm kiếm và thử lại.";
            // Lấy dòng chữ cảnh báo STT_Ten: 45_Nhan
            string ac_45_Nhan = driver_45_Nhan.FindElement(By.ClassName("search-error")).Text;
            Assert.AreEqual(ex_45_Nhan, ac_45_Nhan);
            driver_45_Nhan.Quit();
        }
    }
}
