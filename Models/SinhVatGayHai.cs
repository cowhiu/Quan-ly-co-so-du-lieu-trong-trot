namespace test2.Models
{
    /// <summary>
    /// Bang SinhVatGayHai - Sinh vat gay hai
    /// </summary>
    public class SinhVatGayHai
    {
   public int Id { get; set; }
public string? Ten { get; set; }
        public string? PhanLoai { get; set; }
        public string? CayAH { get; set; }
      public int? VTId { get; set; }
    }

    /// <summary>
    /// Bang CapNhat_SVGH - Cap nhat tinh hinh sinh vat gay hai
    /// </summary>
    public class CapNhat_SVGH
    {
        public int Id { get; set; }
public DateTime? NgayGioCN { get; set; }
public string? TienDo { get; set; }
    public int? SVId { get; set; }
  }

  /// <summary>
    /// Bang TuoiSau - Tuoi sau va do pho bien
    /// </summary>
    public class TuoiSau
    {
        public int Id { get; set; }
     public string? Ten { get; set; }
        public int? TuoiSauValue { get; set; }
        public string? DoPhoBien { get; set; }
        public int? SVId { get; set; }
    }

    /// <summary>
 /// Bang CS_VG - Co so Viet Gap
    /// </summary>
    public class CS_VG
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
    public string? DiaChi { get; set; }
        public int? BanDoId { get; set; }
    }
}
