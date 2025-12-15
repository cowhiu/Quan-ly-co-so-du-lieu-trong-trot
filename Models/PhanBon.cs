namespace test2.Models
{
    /// <summary>
    /// Bang PhanBon - Phan bon
    /// </summary>
    public class PhanBon
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
 public string? ThanhPhan { get; set; }
        public string? PhanLoai { get; set; }
        public int? VTId { get; set; }
    }

    /// <summary>
    /// Bang CoSoBanPhanBon - Co so ban phan bon
    /// </summary>
    public class CoSoBanPhanBon
    {
 public int Id { get; set; }
        public string? Ten { get; set; }
        public string? DiaChi { get; set; }
        public int? BanDoId { get; set; }
        public int? LoaiId { get; set; }
    }

    /// <summary>
    /// Bang CoSoSanXuatPhanBon - Co so san xuat phan bon
    /// </summary>
    public class CoSoSanXuatPhanBon
    {
        public int Id { get; set; }
   public string? Ten { get; set; }
        public string? DiaChi { get; set; }
        public int? BanDoId { get; set; }
        public int? LoaiId { get; set; }
    }

    /// <summary>
    /// Bang PhanBon_CoSoBan - Lien ket Phan bon va Co so ban
    /// </summary>
    public class PhanBon_CoSoBan
    {
     public int PhanBonId { get; set; }
        public int CoSoBanId { get; set; }
  }

    /// <summary>
    /// Bang PhanBon_CoSoSanXuat - Lien ket Phan bon va Co so san xuat
    /// </summary>
    public class PhanBon_CoSoSanXuat
    {
  public int PhanBonId { get; set; }
        public int CoSoSanXuatId { get; set; }
    }
}
