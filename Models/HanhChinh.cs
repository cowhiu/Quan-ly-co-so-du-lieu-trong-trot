namespace test2.Models
{
    /// <summary>
    /// Bang BanDoPhanBo - Luu toa do ban do
    /// </summary>
    public class BanDoPhanBo
    {
        public int Id { get; set; }
        public double? ToaDoX { get; set; }
        public double? ToaDoY { get; set; }
 }

    /// <summary>
    /// Bang HanhChinh - Don vi hanh chinh
    /// </summary>
    public class HanhChinh
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
      public int? TrucThuocId { get; set; }
    }

    /// <summary>
    /// Bang DonVi - Don vi
    /// </summary>
    public class DonVi
    {
   public int Id { get; set; }
        public string? Ten { get; set; }
    public int? HanhChinhId { get; set; }
     public string? TenHanhChinh { get; set; }
 public int? TrucThuocId { get; set; }
    }

  /// <summary>
    /// Bang PhanLoai
    /// </summary>
    public class PhanLoai
 {
     public int Id { get; set; }
        public string? Loai { get; set; }
    }

/// <summary>
    /// Bang VungTrong - Vung trong
    /// </summary>
    public class VungTrong
    {
        public int Id { get; set; }
        public double? QuyMo { get; set; }
  public string? DiaChi { get; set; }
        public int? BanDoId { get; set; }
    }
}
