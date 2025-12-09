namespace test2.Models
{
    /// <summary>
    /// Model c? s? ?? ATTP VietGap
    /// </summary>
  public class CoSoVietGap
 {
   public int Id { get; set; }
        public string MaCoSo { get; set; } = string.Empty;
     public string TenCoSo { get; set; } = string.Empty;
       public string? DiaChi { get; set; }
      public int? XaId { get; set; }
    public string? TenXa { get; set; }
 public string? ChuCoSo { get; set; }
    public string? SoDienThoai { get; set; }
        public double? DienTich { get; set; }
  public string? LoaiSanPham { get; set; }
      public string? SanPham { get; set; }
        public string? SoChungNhan { get; set; }
    public string? SoGCN { get; set; }
public DateTime? NgayCapChungNhan { get; set; }
   public DateTime? NgayHetHan { get; set; }
        public string? ToChucChungNhan { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
 }

    /// <summary>
    /// Model vùng tr?ng
    /// </summary>
    public class VungTrong
    {
        public int Id { get; set; }
   public string MaVung { get; set; } = string.Empty;
 public string TenVung { get; set; } = string.Empty;
   public int? XaId { get; set; }
     public string? TenXa { get; set; }
     public string? DiaDiem { get; set; }
   public string? CayTrong { get; set; }
        public double? DienTich { get; set; }
        public string? LoaiCayTrong { get; set; }
    public string? MoTa { get; set; }
     public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model sinh v?t gây h?i
    /// </summary>
    public class SinhVatGayHai
  {
        public int Id { get; set; }
     public string MaSinhVat { get; set; } = string.Empty;
     public string TenSinhVat { get; set; } = string.Empty;
  public string? TenKhoaHoc { get; set; }
  public string? Loai { get; set; }
  public string? CayBiHai { get; set; }
  public string? MucDo { get; set; }
  public string? LoaiSinhVat { get; set; } // Sâu, B?nh, C? d?i, etc.
        public string? CayTrongBiHai { get; set; }
public string? TrieuChung { get; set; }
 public string? BienPhapPhongTru { get; set; }
    public string? HinhAnh { get; set; }
    public bool TrangThai { get; set; } = true;
    public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model c?p nh?t tình hình sinh v?t gây h?i
    /// </summary>
    public class TinhHinhSinhVatGayHai
  {
      public int Id { get; set; }
        public int SinhVatGayHaiId { get; set; }
        public string? TenSinhVat { get; set; }
        public int? VungTrongId { get; set; }
   public string? TenVung { get; set; }
        public DateTime NgayPhatHien { get; set; }
       public double? DienTichNhiem { get; set; }
    public int? CapDoNhiem { get; set; } // 1-5
   public string? MoTa { get; set; }
 public string? BienPhapXuLy { get; set; }
      public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model tu?i sâu, c?p ?? ph? bi?n
    /// </summary>
    public class TuoiSauCapDo
    {
     public int Id { get; set; }
        public string MaCapDo { get; set; } = string.Empty;
 public string TenCapDo { get; set; } = string.Empty;
   public int? TuoiSau { get; set; }
        public string? MoTa { get; set; }
        public int? MucDoPhoBien { get; set; } // 1-5
        public bool TrangThai { get; set; } = true;
  }
}
