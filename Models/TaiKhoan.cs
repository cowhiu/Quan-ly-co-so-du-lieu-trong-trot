namespace test2.Models
{
    /// <summary>
    /// Model ??i di?n cho Tài kho?n
    /// </summary>
    public class TaiKhoan
    {
        public int Id { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public int NguoiDungId { get; set; }
        public string? HoTen { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime? LanDangNhapCuoi { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}
