using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.Helpers
{
    class Login
    {
        static QLNVNhanVienEntities db = new QLNVNhanVienEntities();
        public static bool isLoginSess= false;
        public static string ErrorLogin;
        public static void LoginUser(string taiKhoan, string matKhau)
        {
            BangAdmin User= db.BangAdmins.SingleOrDefault(x => x.TaiKhoan == taiKhoan && x.MatKhau == matKhau);
            if(User == null)
            {
                isLoginSess = false;
                ErrorLogin = "Không tìm thấy tài khoản hoặc mật khẩu";
                return;
            }
            else
            {
                isLoginSess = true;
                return;
            }
        }
        
    }
}
