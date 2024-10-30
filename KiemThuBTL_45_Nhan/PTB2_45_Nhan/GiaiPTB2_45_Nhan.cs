using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB2_45_Nhan
{
    public class GiaiPTB2_45_Nhan
    {
        // Khai báo thuộc tính của lớp gồm 3 biến STT_Ten: 45_Nhan
        private double a_45_Nhan, b_45_Nhan, c_45_Nhan;
        // Tạo phương thức khởi tạo có 3 tham số STT_Ten: 45_Nhan
        public GiaiPTB2_45_Nhan(double a_45_Nhan, double b_45_Nhan, double c_45_Nhan)
        {
            this.a_45_Nhan = a_45_Nhan;
            this.b_45_Nhan = b_45_Nhan;
            this.c_45_Nhan = c_45_Nhan;
        }
        // Tạo phương thức giải bài toán phương trình bậc 2 STT_Ten: 45_Nhan
        public string Giai_45_Nhan()
        {
            string kq_45_Nhan = "";
            if (a_45_Nhan != 0) // Phương trình bậc 2 số a khác 0 STT_Ten: 45_Nhan
            {
                // Math.Pow để tính lũy thừa STT_Ten: 45_Nhan
                double delta_45_Nhan = Math.Pow(b_45_Nhan, 2) - (4 * a_45_Nhan * c_45_Nhan);
                if (delta_45_Nhan > 0) // Phương trình có 2 nghiệm phân biệt STT_Ten: 45_Nhan
                {
                    //Math.Round để làm tròn số thực đến số thập phân thứ 2 STT_Ten: 45_Nhan
                    double x1_45_Nhan = Math.Round((-b_45_Nhan + Math.Sqrt(delta_45_Nhan)) / (2 * a_45_Nhan), 2);
                    double x2_45_Nhan = Math.Round((-b_45_Nhan - Math.Sqrt(delta_45_Nhan)) / (2 * a_45_Nhan), 2);
                    kq_45_Nhan = x1_45_Nhan.ToString() + "; " + x2_45_Nhan.ToString();
                }
                else if (delta_45_Nhan < 0) //Phương trình vô nghiệm STT_Ten: 45_Nhan
                {
                    kq_45_Nhan = "Phuong trinh vo nghiem";
                }
                else // delta_45_Nhan = 0 -> phương trình có 1 nghiệm kép STT_Ten: 45_Nhan
                {
                    double x_45_Nhan = Math.Round((-b_45_Nhan) / (2 * a_45_Nhan), 2);
                    kq_45_Nhan = x_45_Nhan.ToString();
                }
            }
            else
            {
                kq_45_Nhan = "Phuong trinh bac 2, a khac 0";
            }
            return kq_45_Nhan;
        }
    }
}
