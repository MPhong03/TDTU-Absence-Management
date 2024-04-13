namespace DTO
{
    public class DTO_QuanTriVien
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public DTO_QuanTriVien(string TenDangNhap, string MatKhau)
        {
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }
    }
}