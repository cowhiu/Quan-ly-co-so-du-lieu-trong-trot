namespace test2.Models
{
    /// <summary>
    /// Model ??i di?n cho Thu?c b?o v? th?c v?t
    /// </summary>
    public class ThuocBVTV
    {
        public int Id { get; set; }
        public string MaThuoc { get; set; } = string.Empty;
    public string TenThuoc { get; set; } = string.Empty;
        public string? TenHoatChat { get; set; }
   public string? HoatChat { get; set; }
        public string? HamLuong { get; set; }
    public string? DangThuoc { get; set; }
        public string? CongDung { get; set; }
     public string? DoiTuongPhongTru { get; set; }
        public string? HuongDanSuDung { get; set; }
    public string? NhaSanXuat { get; set; }
   public string? NuocSanXuat { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model t? ch?c ?? ?i?u ki?n s?n xu?t
 /// </summary>
    public class ToChucSanXuat
    {
        public int Id { get; set; }
        public string MaToChuc { get; set; } = string.Empty;
        public string TenToChuc { get; set; } = string.Empty;
        public string? DiaChi { get; set; }
     public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
     public string? SoGCN { get; set; }
    public DateTime? NgayCapPhep { get; set; }
        public DateTime? NgayHetHan { get; set; }
  public bool DangHoatDong { get; set; } = true;
  public bool TrangThai { get; set; } = true;
     public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model c? s? mua bán
    /// </summary>
    public class CoSoMuaBan
    {
        public int Id { get; set; }
        public string MaCoSo { get; set; } = string.Empty;
     public string TenCoSo { get; set; } = string.Empty;
   public string? DiaChi { get; set; }
        public int? XaId { get; set; }
        public string? TenXa { get; set; }
 public string? ChuCoSo { get; set; }
        public string? SoDienThoai { get; set; }
        public string? SoGiayPhep { get; set; }
        public DateTime? NgayCapPhep { get; set; }
        public bool DangHoatDong { get; set; } = true;
        public bool TrangThai { get; set; } = true;
      public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
 /// Model to chuc san xuat thuoc BVTV
  /// </summary>
    public class ToChucSanXuatThuoc
{
        public int Id { get; set; }
   public string MaToChuc { get; set; } = string.Empty;
  public string TenToChuc { get; set; } = string.Empty;
     public string? DiaChi { get; set; }
     public string? SoDienThoai { get; set; }
   public string? Email { get; set; }
 public string? SoGiayPhep { get; set; }
        public DateTime? NgayCapPhep { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model co so mua ban thuoc BVTV
    /// </summary>
    public class CoSoMuaBanThuoc
    {
   public int Id { get; set; }
        public string MaCoSo { get; set; } = string.Empty;
  public string TenCoSo { get; set; } = string.Empty;
        public string? DiaChi { get; set; }
  public int? XaId { get; set; }
        public string? TenXa { get; set; }
        public string? ChuCoSo { get; set; }
  public string? SoDienThoai { get; set; }
        public string? SoGiayPhep { get; set; }
        public DateTime? NgayCapPhep { get; set; }
        public bool TrangThai { get; set; } = true;
      public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}
