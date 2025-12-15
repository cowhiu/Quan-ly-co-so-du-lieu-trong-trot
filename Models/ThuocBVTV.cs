namespace test2.Models
{
    /// <summary>
    /// Bang ThuocBVTV - Thuoc bao ve thuc vat
    /// </summary>
    public class ThuocBVTV
    {
        public int Id { get; set; }
      public string? Ten { get; set; }
   public DateTime? NgaySX { get; set; }
        public DateTime? HanSD { get; set; }
        public int? VTId { get; set; }
    }

    /// <summary>
    /// Bang CoSoBanThuocBVTV - Co so ban thuoc BVTV
    /// </summary>
    public class CoSoBanThuocBVTV
    {
        public int Id { get; set; }
    public string? Ten { get; set; }
        public string? DiaChi { get; set; }
        public int? BanDoId { get; set; }
 public int? LoaiId { get; set; }
    }

    /// <summary>
    /// Bang CoSoSanXuatThuocBVTV - Co so san xuat thuoc BVTV
    /// </summary>
    public class CoSoSanXuatThuocBVTV
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
  public string? DiaChi { get; set; }
 public int? BanDoId { get; set; }
        public int? LoaiId { get; set; }
    }

    /// <summary>
    /// Bang ThuocBVTV_CoSoBan - Lien ket Thuoc va Co so ban
    /// </summary>
    public class ThuocBVTV_CoSoBan
{
 public int ThuocBVTVId { get; set; }
        public int CoSoBanId { get; set; }
    }

    /// <summary>
    /// Bang ThuocBVTV_CoSoSanXuat - Lien ket Thuoc va Co so san xuat
    /// </summary>
    public class ThuocBVTV_CoSoSanXuat
    {
        public int ThuocBVTVId { get; set; }
        public int CoSoSanXuatId { get; set; }
    }
}
