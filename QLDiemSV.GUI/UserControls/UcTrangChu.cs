using System.Drawing;
using System.Windows.Forms;

namespace QLDiemSV.GUI.UserControls
{
    /// <summary>
    /// Trang Tổng quan. Hiện là khung rỗng - sẽ thay bằng 4 thẻ thống kê,
    /// biểu đồ cột, biểu đồ tròn và bảng "Hoạt động gần đây".
    /// </summary>
    public class UcTrangChu : UserControl
    {
        public UcTrangChu()
        {
            BackColor = Color.FromArgb(252, 246, 251);
            Controls.Add(new Label
            {
                Text = "Trang chủ (UcTrangChu)",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14f),
                ForeColor = Color.FromArgb(90, 20, 95)
            });
        }
    }
}
