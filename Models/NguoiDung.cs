namespace test2.Models
{
    /// <summary>
  /// Model dai dien cho Nguoi dung
    /// </summary>
    public class NguoiDung
    {
    public int Id { get; set; }
     public string MaNguoiDung { get; set; } = string.Empty;
     public string HoTen { get; set; } = string.Empty;
     public string TenNguoiDung { get; set; } = string.Empty;
     public string Email { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
  public string? DiaChi { get; set; }
      public int? NhomNguoiDungId { get; set; }
    public string? TenNhomNguoiDung { get; set; }
   public string? TenTrangThai { get; set; }
   public TrangThaiNguoiDungEnum TrangThai { get; set; } = TrangThaiNguoiDungEnum.HoatDong;
     public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
    }

    /// <summary>
    /// Enum tr?ng thái ng??i dùng
    /// </summary>
    public enum TrangThaiNguoiDungEnum
    {
   HoatDong = 1,
        TamKhoa = 2,
        DaXoa = 3
}

    /// <summary>
    /// Model tr?ng thái ng??i dùng
    /// </summary>
    public class TrangThaiNguoiDung
    {
        public int Id { get; set; }
        public string MaTrangThai { get; set; } = string.Empty;
        public string TenTrangThai { get; set; } = string.Empty;
        public string? MoTa { get; set; }
  public bool IsActive { get; set; } = true;
    }

   /// <summary>
  /// Model ??i di?n cho Nhóm ng??i dùng
    /// </summary>
    public class NhomNguoiDung
    {
        public int Id { get; set; }
   public string MaNhom { get; set; } = string.Empty;
        public string TenNhom { get; set; } = string.Empty;
        public string? TenTrangThai { get; set; }
        public string? MoTa { get; set; }
        public bool TrangThai { get; set; } = true;
     public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model ??i di?n cho Quy?n
    /// </summary>
    public class Quyen
    {
        public int Id { get; set; }
      public string MaQuyen { get; set; } = string.Empty;
 public string TenQuyen { get; set; } = string.Empty;
        public string? Module { get; set; }
        public string? MoTa { get; set; }
        public string? NhomQuyen { get; set; }
    }

    /// <summary>
/// Model phân quy?n cho nhóm ng??i dùng
/// </summary>
    public class PhanQuyenNhom
    {
      public int Id { get; set; }
        public int NhomNguoiDungId { get; set; }
        public int QuyenId { get; set; }
  public string? TenNhom { get; set; }
  public string? TenQuyen { get; set; }
    }

    /// <summary>
    /// Model phân quy?n cho ng??i dùng
    /// </summary>
    public class PhanQuyenNguoiDung
    {
      public int Id { get; set; }
        public int NguoiDungId { get; set; }
      public int QuyenId { get; set; }
        public string? TenNguoiDung { get; set; }
        public string? TenQuyen { get; set; }
    }
}
