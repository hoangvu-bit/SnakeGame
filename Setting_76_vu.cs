using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakesgame_76_vu
{
    public class Setting_76_vu
    {
        // Số lượng ô giới hạn theo chiều dọc (chiều cao) của lưới sân chơi. Mặc định là 16 ô.
        public static int chieuRong_76_vu { get; set; } = 16;

        // Số lượng ô giới hạn theo chiều ngang (chiều dài) của lưới sân chơi. Mặc định là 16 ô.
        public static int chieuDai_76_vu { get; set; } = 16;

        // Thiết lập hướng di chuyển ban đầu của đầu rắn ngay khi vừa mở game. Mặc định là đi sang Phải.
        public static Huong_76_vu huong_76_vu { get; set; } = Huong_76_vu.Len_76_vu;

    }
    public enum Huong_76_vu
    {
        // Trạng thái rắn đang di chuyển sang Trái
        Trai_76_vu,

        // Trạng thái rắn đang di chuyển sang Phải
        Phai_76_vu,

        // Trạng thái rắn đang di chuyển Lên trên
        Len_76_vu,

        // Trạng thái rắn đang di chuyển Xuống dưới
        Xuong_76_vu
    }
}
