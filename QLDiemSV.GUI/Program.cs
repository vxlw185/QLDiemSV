using System;
using System.Windows.Forms;
using QLDiemSV.BLL;
using QLDiemSV.DTO;

namespace QLDiemSV.GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO: thay bằng FrmDangNhap. Tạm thời giả lập đăng nhập Admin.
            PhienLamViec.DangNhap(new TaiKhoanDTO { MaTK = 1, TenDangNhap = "admin", HoTen = "Admin", VaiTro = "Admin" });

            Application.Run(new FrmMain());
        }
    }
}
