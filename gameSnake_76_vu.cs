using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakesgame_76_vu
{
    public partial class Snakes_76_vu : Form
    {
        // ==========================================
        // 1. KHAI BÁO CÁC BIẾN TOÀN CỤC SỬ DỤNG TRONG GAME
        // ==========================================

        // Danh sách (List) lưu trữ các điểm tọa độ tạo nên thân con rắn.
        // Phần tử đầu tiên Snake_76_vu[0] sẽ luôn là đầu rắn.
        private List<ViTri_76_vu> Snake_76_vu = new List<ViTri_76_vu>();

        // Biến lưu trữ tọa độ X, Y hiện tại của viên thức ăn trên màn hình
        private ViTri_76_vu doAn_76_vu = new ViTri_76_vu();

        // Giới hạn chiều rộng của sân chơi (lấy dữ liệu từ class Setting_76_vu)
        int maxChieuRong_76_vu = Setting_76_vu.chieuRong_76_vu;

        // Giới hạn chiều dài của sân chơi (lấy dữ liệu từ class Setting_76_vu)
        int maxChieuDai_76_vu = Setting_76_vu.chieuDai_76_vu;

        // Biến lưu trữ điểm số hiện tại của người chơi
        int diem_76_vu;

        // Đối tượng Random dùng để tạo các con số ngẫu nhiên (sử dụng khi tạo tọa độ mồi)
        Random rand_76_vu = new Random();

        // ==========================================
        // 2. KHỞI TẠO FORM GIAO DIỆN
        // ==========================================
        public Snakes_76_vu()
        {
            // Hàm mặc định của WinForms để khởi tạo các thành phần giao diện (nút bấm, label, timer...)
            InitializeComponent();
        }

        // ==========================================
        // 3. TÍNH NĂNG CHỤP ẢNH MÀN HÌNH (SNAPSHOT)
        // ==========================================
        public void TakeSnapShot_76_vu(object sender, EventArgs e)
        {
            try
            {
                // Tạo một bản vẽ ảo (Bitmap) trong RAM có kích thước bằng với vùng chơi (PictureBox)
                Bitmap anh_76_vu = new Bitmap(picb_76_vu.Width, picb_76_vu.Height);

                // Copy toàn bộ hình ảnh hiện tại trên PictureBox và dán lên bản vẽ ảo (Bitmap) vừa tạo
                picb_76_vu.DrawToBitmap(anh_76_vu, new Rectangle(0, 0, picb_76_vu.Width, picb_76_vu.Height));

                // Đặt tên file ảnh chứa thời gian thực để các ảnh chụp sau không bị đè lên ảnh chụp trước
                string tenFile_76_vu = "Anh_chụp_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

                // Lấy đường dẫn trỏ ra ngoài màn hình chính (Desktop) của máy tính và ghép với tên file
                string duongDan_76_vu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + tenFile_76_vu;

                // Xuất ảnh từ RAM ra file thực tế với định dạng PNG
                anh_76_vu.Save(duongDan_76_vu, System.Drawing.Imaging.ImageFormat.Png);

                // Hiển thị hộp thoại thông báo thành công cho người chơi
                MessageBox.Show("Ảnh đã được lưu trên Desktop với tên: " + tenFile_76_vu);
            }
            catch
            {
                // Bắt lỗi và thông báo nếu quá trình lưu ảnh thất bại (ví dụ: ổ cứng đầy, lỗi quyền...)
                MessageBox.Show("Lỗi khi lưu ảnh!");
            }
        }

        // ==========================================
        // 4. XỬ LÝ SỰ KIỆN KHI NGƯỜI CHƠI NHẤN PHÍM
        // ==========================================
        private void KeyIsDown_76_vu(object sender, KeyEventArgs e)
        {
            // Nếu người chơi bấm phím mũi tên Trái (Left)
            // Chỉ cho phép chuyển hướng sang Trái nếu rắn KHÔNG ĐANG ĐI SANG PHẢI (ngăn rắn quay đầu tự cắn mình)
            if (e.KeyCode == Keys.Left && Setting_76_vu.huong_76_vu != Huong_76_vu.Phai_76_vu)
            {
                // Thay đổi hướng di chuyển hiện tại sang Trái
                Setting_76_vu.huong_76_vu = Huong_76_vu.Trai_76_vu;
            }

            // Nếu người chơi bấm phím mũi tên Phải (Right)
            // Chỉ cho phép chuyển hướng sang Phải nếu rắn KHÔNG ĐANG ĐI SANG TRÁI
            if (e.KeyCode == Keys.Right && Setting_76_vu.huong_76_vu != Huong_76_vu.Trai_76_vu)
            {
                // Thay đổi hướng di chuyển hiện tại sang Phải
                Setting_76_vu.huong_76_vu = Huong_76_vu.Phai_76_vu;
            }

            // Nếu người chơi bấm phím mũi tên Lên (Up)
            // Chỉ cho phép chuyển hướng Lên nếu rắn KHÔNG ĐANG ĐI XUỐNG
            if (e.KeyCode == Keys.Up && Setting_76_vu.huong_76_vu != Huong_76_vu.Xuong_76_vu)
            {
                // Thay đổi hướng di chuyển hiện tại Lên trên
                Setting_76_vu.huong_76_vu = Huong_76_vu.Len_76_vu;
            }

            // Nếu người chơi bấm phím mũi tên Xuống (Down)
            // Chỉ cho phép chuyển hướng Xuống nếu rắn KHÔNG ĐANG ĐI LÊN
            if (e.KeyCode == Keys.Down && Setting_76_vu.huong_76_vu != Huong_76_vu.Len_76_vu)
            {
                // Thay đổi hướng di chuyển hiện tại Xuống dưới
                Setting_76_vu.huong_76_vu = Huong_76_vu.Xuong_76_vu;
            }
        }

        // ==========================================
        // 5. HÀM GỌI KHI NHẤN NÚT BẮT ĐẦU GAME
        // ==========================================
        public void StartGame_76_vu(object sender, EventArgs e)
        {
            // Gọi hàm thiết lập lại trạng thái game từ đầu
            ReStartGame_76_vu();
        }

        // ==========================================
        // 6. VÒNG LẶP CHÍNH CỦA TRÒ CHƠI (CHẠY LIÊN TỤC THEO TIMER)
        // ==========================================
        private void GamerTimeEvent_76_vu(object sender, EventArgs e)
        {
            // --- BƯỚC 1: Cập nhật vị trí của THÂN RẮN ---
            // Vòng lặp chạy ngược từ đốt đuôi cùng lên đến đốt kề đầu rắn
            // Đốt phía sau sẽ tiến lên, chiếm lấy tọa độ của đốt liền trước nó
            for (int i = Snake_76_vu.Count - 1; i > 0; i--)
            {
                // Gán tọa độ X của đốt trước cho đốt hiện tại
                Snake_76_vu[i].X_76_vu = Snake_76_vu[i - 1].X_76_vu;

                // Gán tọa độ Y của đốt trước cho đốt hiện tại
                Snake_76_vu[i].Y_76_vu = Snake_76_vu[i - 1].Y_76_vu;
            }

            // --- BƯỚC 2: Cập nhật vị trí của ĐẦU RẮN theo hướng đang đi ---
            switch (Setting_76_vu.huong_76_vu)
            {
                // Nếu đang đi sang Trái
                case Huong_76_vu.Trai_76_vu:
                    // Giảm tọa độ X (cột) đi 1 đơn vị
                    Snake_76_vu[0].X_76_vu--;
                    break;

                // Nếu đang đi sang Phải
                case Huong_76_vu.Phai_76_vu:
                    // Tăng tọa độ X (cột) lên 1 đơn vị
                    Snake_76_vu[0].X_76_vu++;
                    break;

                // Nếu đang đi Lên trên
                case Huong_76_vu.Len_76_vu:
                    // Giảm tọa độ Y (hàng) đi 1 đơn vị
                    Snake_76_vu[0].Y_76_vu--;
                    break;

                // Nếu đang đi Xuống dưới
                case Huong_76_vu.Xuong_76_vu:
                    // Tăng tọa độ Y (hàng) lên 1 đơn vị
                    Snake_76_vu[0].Y_76_vu++;
                    break;
            }

            // --- BƯỚC 3: Xử lý cơ chế XUYÊN TƯỜNG (khi đầu đi quá mép màn hình) ---
            // Nếu đầu rắn vượt qua mép bên trái màn hình (X < 0)
            if (Snake_76_vu[0].X_76_vu < 0)
            {
                // Xuất hiện lại ở mép bên phải
                Snake_76_vu[0].X_76_vu = maxChieuDai_76_vu;
            }

            // Nếu đầu rắn vượt qua mép phía trên màn hình (Y < 0)
            if (Snake_76_vu[0].Y_76_vu < 0)
            {
                // Xuất hiện lại ở mép phía dưới
                Snake_76_vu[0].Y_76_vu = maxChieuRong_76_vu;
            }

            // Nếu đầu rắn vượt qua mép bên phải màn hình
            if (Snake_76_vu[0].X_76_vu > maxChieuDai_76_vu)
            {
                // Xuất hiện lại ở mép bên trái
                Snake_76_vu[0].X_76_vu = 0;
            }

            // Nếu đầu rắn vượt qua mép phía dưới màn hình
            if (Snake_76_vu[0].Y_76_vu > maxChieuRong_76_vu)
            {
                // Xuất hiện lại ở mép phía trên
                Snake_76_vu[0].Y_76_vu = 0;
            }

            // --- BƯỚC 4: Kiểm tra xem rắn có ăn được mồi hay không ---
            EatFood_76_vu();

            // --- BƯỚC 5: Kiểm tra xem rắn CÓ TỰ CẮN VÀO THÂN MÌNH hay không ---
            // Duyệt từ đốt thứ 2 trở đi (index = 1) để so sánh với đầu rắn
            for (int i = 1; i < Snake_76_vu.Count; i++)
            {
                // Nếu tọa độ đầu rắn trùng khớp hoàn toàn với tọa độ của bất kỳ đốt thân nào
                if (Snake_76_vu[0].X_76_vu == Snake_76_vu[i].X_76_vu &&
                    Snake_76_vu[0].Y_76_vu == Snake_76_vu[i].Y_76_vu)
                {
                    // Gọi hàm kết thúc trò chơi (thua cuộc)
                    GameOver();
                }
            }

            // --- BƯỚC 6: Xóa đồ họa cũ và yêu cầu hệ thống vẽ lại bản đồ ---
            picb_76_vu.Invalidate();
        }

        // ==========================================
        // 7. XỬ LÝ ĐỒ HỌA: VẼ RẮN VÀ THỨC ĂN
        // ==========================================
        private void UpdatePictureBoxGraphic_76_vu(object sender, PaintEventArgs e)
        {
            // Đối tượng Graphics dùng để thao tác vẽ hình khối
            Graphics g_76_vu = e.Graphics;

            // Kích thước quy định của 1 đốt rắn và 1 viên thức ăn (20x20 pixels)
            int size_76_vu = 20;

            // Biến chứa màu sắc sẽ được sử dụng để vẽ
            Brush snakeColor_76_vu;

            // Vòng lặp duyệt qua danh sách để vẽ con rắn (đầu và thân)
            for (int i_76_vu = 0; i_76_vu < Snake_76_vu.Count; i_76_vu++)
            {
                // Nếu đang xét phần tử đầu tiên (đầu rắn)
                if (i_76_vu == 0)
                {
                    // Chọn cọ vẽ màu Xanh Lá Cây (Lime)
                    snakeColor_76_vu = Brushes.Lime;
                }
                // Nếu đang xét các phần tử còn lại (thân rắn)
                else
                {
                    // Chọn cọ vẽ màu Vàng (Yellow)
                    snakeColor_76_vu = Brushes.Yellow;
                }

                // Tiến hành vẽ một hình tròn (Ellipse) đại diện cho đốt rắn hiện tại
                // Tọa độ vẽ được tính bằng tọa độ lưới (X, Y) nhân với kích thước pixels (size)
                g_76_vu.FillEllipse(snakeColor_76_vu, new Rectangle
                   (
                   Snake_76_vu[i_76_vu].X_76_vu * size_76_vu,
                   Snake_76_vu[i_76_vu].Y_76_vu * size_76_vu,
                   size_76_vu, size_76_vu
                    ));
            }

            // Tiến hành vẽ viên thức ăn bằng một hình tròn màu Đỏ Sẫm (DarkRed)
            g_76_vu.FillEllipse(Brushes.DarkRed, new Rectangle
               (
               doAn_76_vu.X_76_vu * size_76_vu,
               doAn_76_vu.Y_76_vu * size_76_vu,
               size_76_vu, size_76_vu
                ));
        }

        // ==========================================
        // 8. HÀM THIẾT LẬP VÀ BẮT ĐẦU/BẮT ĐẦU LẠI GAME
        // ==========================================
        public void ReStartGame_76_vu()
        {
            // Cỡ của 1 đơn vị trên lưới (20 pixels)
            int size_76_vu = 20;

            // Tự động tính toán số cột (maxChieuDai) dựa trên chiều rộng PictureBox
            maxChieuDai_76_vu = picb_76_vu.Width / size_76_vu - 1;

            // Tự động tính toán số hàng (maxChieuRong) dựa trên chiều cao PictureBox
            maxChieuRong_76_vu = picb_76_vu.Height / size_76_vu - 1;

            // Xóa sạch toàn bộ dữ liệu thân rắn cũ (áp dụng cho trường hợp chơi lại)
            Snake_76_vu.Clear();

            // Vô hiệu hóa nút Bắt đầu để người chơi không bấm nhầm khi game đang chạy
            btnStart_76_vu.Enabled = false;

            // Vô hiệu hóa nút Chụp ảnh (nếu cần thiết) khi game đang chạy
            btnSnap_76_vu.Enabled = false;

            // Khởi tạo lại điểm số về 0
            diem_76_vu = 0;

            // Hiển thị điểm số mới lên màn hình
            lbDiemBatDau_76_vu.Text = diem_76_vu.ToString();

            // Khởi tạo điểm xuất phát của đầu rắn tại tọa độ (Cột 10, Hàng 5)
            ViTri_76_vu head_76_vu = new ViTri_76_vu { X_76_vu = 10, Y_76_vu = 5 };

            // Đưa đầu rắn vào danh sách List
            Snake_76_vu.Add(head_76_vu);

            // Vòng lặp tự động nối thêm 10 đốt thân xếp hàng ngang phía sau đầu rắn
            for (int i_76_vu = 1; i_76_vu <= 10; i_76_vu++)
            {
                // Tính tọa độ cho các đốt thân lùi dần về phía sau theo trục X
                Snake_76_vu.Add(new ViTri_76_vu
                {
                    X_76_vu = head_76_vu.X_76_vu - i_76_vu,
                    Y_76_vu = head_76_vu.Y_76_vu
                });
            }

            // Gọi logic Random để tạo ra tọa độ cho viên thức ăn đầu tiên
            doAn_76_vu = new ViTri_76_vu
            {
                X_76_vu = rand_76_vu.Next(1, maxChieuDai_76_vu),
                Y_76_vu = rand_76_vu.Next(1, maxChieuRong_76_vu)
            };

            // Khởi động đồng hồ đếm nhịp (Timer) để bắt đầu vòng lặp game
            timeGame_76_vu.Start();

            // Vẽ lại giao diện khởi điểm ngay lập tức
            picb_76_vu.Invalidate();

            // Cấp quyền tập trung (Focus) cho Form chính để sẵn sàng nhận lệnh từ bàn phím
            this.Focus();
        }

        // ==========================================
        // 9. LOGIC XỬ LÝ KHI RẮN ĂN ĐƯỢC THỨC ĂN
        // ==========================================
        private void EatFood_76_vu()
        {
            // Kiểm tra xem tọa độ đầu rắn có trùng khớp hoàn toàn với tọa độ thức ăn không
            if (Snake_76_vu[0].X_76_vu == doAn_76_vu.X_76_vu &&
                Snake_76_vu[0].Y_76_vu == doAn_76_vu.Y_76_vu)
            {
                // Cộng thêm 1 điểm
                diem_76_vu++;

                // Cập nhật điểm số lên giao diện người dùng
                lbDiemBatDau_76_vu.Text = diem_76_vu.ToString();

                // (Tùy chọn) Nếu điểm lớn hơn 8 (nghĩa là đạt 9 điểm) thì kích hoạt điều kiện dừng game
                if (diem_76_vu > 8)
                {
                    // Ngừng vòng lặp game
                    timeGame_76_vu.Stop();

                    // Mở khóa nút Start để có thể chơi lại
                    btnStart_76_vu.Enabled = true;

                    // Mở khóa nút chụp ảnh
                    btnSnap_76_vu.Enabled = true;
                }

                // Lấy tọa độ của đốt thân nằm ở cuối cùng (đốt đuôi)
                ViTri_76_vu dotRanMoi_76_vu = Snake_76_vu[Snake_76_vu.Count - 1];

                // Sinh thêm 1 đốt thân mới và đặt vào đúng vị trí của đốt đuôi đó
                Snake_76_vu.Add(new ViTri_76_vu
                {
                    X_76_vu = dotRanMoi_76_vu.X_76_vu,
                    Y_76_vu = dotRanMoi_76_vu.Y_76_vu
                });

                // Chạy hàm tạo ra một viên thức ăn mới trên bản đồ
                TaoThucAnMoi_76_vu();
            }
        }

        // ==========================================
        // 10. THUẬT TOÁN TẠO THỨC ĂN NGẪU NHIÊN VÀ AN TOÀN
        // ==========================================
        private void TaoThucAnMoi_76_vu()
        {
            // Biến cờ (flag) dùng để kiểm tra xem vị trí mồi có bị đè lên thân rắn không
            bool trung_76_vu;

            // Sử dụng vòng lặp Do...While để liên tục tạo lại mồi cho đến khi tìm được vị trí trống
            do
            {
                // Mặc định giả định ban đầu là mồi an toàn (không bị trùng)
                trung_76_vu = false;

                // Lấy ngẫu nhiên tọa độ X, Y mới trong giới hạn của sân chơi
                doAn_76_vu = new ViTri_76_vu
                {
                    X_76_vu = rand_76_vu.Next(1, maxChieuDai_76_vu),
                    Y_76_vu = rand_76_vu.Next(1, maxChieuRong_76_vu)
                };

                // Duyệt qua tất cả các đốt hiện có của con rắn
                for (int i_76_vu = 0; i_76_vu < Snake_76_vu.Count; i_76_vu++)
                {
                    // Nếu tọa độ mồi vừa sinh ra bị đè lên đúng tọa độ của một đốt rắn
                    if (Snake_76_vu[i_76_vu].X_76_vu == doAn_76_vu.X_76_vu &&
                        Snake_76_vu[i_76_vu].Y_76_vu == doAn_76_vu.Y_76_vu)
                    {
                        // Đánh dấu cờ lỗi là True (bị trùng)
                        trung_76_vu = true;

                        // Thoát ngay khỏi vòng lặp For để tiết kiệm thời gian
                        break;
                    }
                }

                // Nếu cờ lỗi vẫn là True thì vòng lặp Do...While sẽ chạy lại từ đầu để random vị trí khác
            } while (trung_76_vu);
        }

        // ==========================================
        // 11. XỬ LÝ TRẠNG THÁI KẾT THÚC GAME (GAME OVER)
        // ==========================================
        private void GameOver()
        {
            // Dừng bộ đếm Timer, rắn sẽ ngừng di chuyển
            timeGame_76_vu.Stop();

            // Kích hoạt lại nút Bắt đầu trên giao diện
            btnStart_76_vu.Enabled = true;

            // Kích hoạt lại nút Chụp ảnh
            btnSnap_76_vu.Enabled = true;

            // Hiển thị khung (Panel) thông báo người chơi đã thua cuộc
            pn_layout_76_vu.Visible = true;

            // Cập nhật điểm số chung cuộc lên Label thông báo
            lbDiem_76_vu.Text = diem_76_vu.ToString();
        }

        // ==========================================
        // 12. CÁC HÀM XỬ LÝ SỰ KIỆN NÚT BẤM CỦA GIAO DIỆN
        // ==========================================

        // Sự kiện khi nhấn nút Bắt Đầu ở Menu khởi động
        private void btnStart_76_vu_Click(object sender, EventArgs e)
        {
            // Ẩn bảng Menu đi
            pnlMenu_76_vu.Visible = false;

            // Chạy hàm thiết lập và khởi động game
            ReStartGame_76_vu();
        }

        // Sự kiện khi nhấn nút Bắt Đầu Lại ở bảng thông báo Game Over
        private void btnBatDauLai_76_vu_Click(object sender, EventArgs e)
        {
            // Ẩn bảng thông báo Game Over đi
            pn_layout_76_vu.Visible = false;

            // Chạy hàm thiết lập và khởi động lại game
            ReStartGame_76_vu();
        }

        // Sự kiện khi nhấn nút Thoát
        private void btThoatGame_76_vu_Click(object sender, EventArgs e)
        {
            // Ra lệnh cho hệ điều hành đóng hoàn toàn Form ứng dụng
            Application.Exit();
        }
    }
}