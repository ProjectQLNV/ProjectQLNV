using QLNV.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLNV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        QLNVNhanVienEntities ef = new QLNVNhanVienEntities();
        public void DangNhapbutton_Click(object sender, EventArgs e)
        {
            Login.LoginUser(txtTaiKhoan.Text, txtMatKhau.Text);
            if (Login.isLoginSess == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show(Login.ErrorLogin);
            }
        }
    }
}
