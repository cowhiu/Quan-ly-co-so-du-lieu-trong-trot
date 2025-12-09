namespace test2.Models
{
    /// <summary>
    /// Model dai dien cho Phan bon
    /// </summary>
    public class PhanBon
  {
        public int Id { get; set; }
        public string MaPhanBon { get; set; } = string.Empty;
        public string TenPhanBon { get; set; } = string.Empty;
    public string? LoaiPhanBon { get; set; }
 public string? LoaiPhan { get; set; }
        public string? ThanhPhan { get; set; }
        public string? HamLuong { get; set; }
      public string? CongDung { get; set; }
    public string? HuongDanSuDung { get; set; }
        public string? NhaSanXuat { get; set; }
        public string? NuocSanXuat { get; set; }
   public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
  /// Model to chuc du dieu kien san xuat phan bon
    /// </summary>
    public class ToChucSanXuatPhanBon
    {
        public int Id { get; set; }
    public string MaToChuc { get; set; } = string.Empty;
        public string TenToChuc { get; set; } = string.Empty;
    public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
public string? Email { get; set; }
        public string? SoGCN { get; set; }
        public string? SoGiayPhep { get; set; }
        public DateTime? NgayCapPhep { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public bool DangHoatDong { get; set; } = true;
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model co so mua ban phan bon
    /// </summary>
    public class CoSoMuaBanPhanBon
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
}
