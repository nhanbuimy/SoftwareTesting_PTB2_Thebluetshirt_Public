using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB2_45_Nhan
{
    public partial class Form1_45_Nhan : Form
    {
        public Form1_45_Nhan()
        {
            InitializeComponent();
        }
        // Khai báo biến STT_Ten: 45_Nhan
        double a_45_Nhan, b_45_Nhan, c_45_Nhan;
        string kq_45_Nhan;
        private void btnGiai_45_Nhan_Click(object sender, EventArgs e)
        {
            try // Bảo đảm người dùng nhập đúng định dạng (số) mới tính toán STT_Ten: 45_Nhan
            {
                a_45_Nhan = double.Parse(txtA_45_Nhan.Text);
                b_45_Nhan = double.Parse(txtB_45_Nhan.Text);
                c_45_Nhan = double.Parse(txtC_45_Nhan.Text);
                GiaiPTB2_45_Nhan pt_45_Nhan = new GiaiPTB2_45_Nhan(a_45_Nhan, b_45_Nhan, c_45_Nhan);
                // Gọi phương thức Giai_45_Nhan() của class PTB2_45_Nhan STT_Ten: 45_Nhan
                kq_45_Nhan = pt_45_Nhan.Giai_45_Nhan();
                // Ghi kết quả giải được vào txt_45_Nhan STT_Ten: 45_Nhan
                txtKq_45_Nhan.Text = kq_45_Nhan;
            }
            catch (Exception ex)
            {
                // Trả về câu thông báo lỗi nhập không đúng định dạng STT_Ten: 45_Nhan
                txtKq_45_Nhan.Text = ex.Message;
            }
            
        }
    }
}
