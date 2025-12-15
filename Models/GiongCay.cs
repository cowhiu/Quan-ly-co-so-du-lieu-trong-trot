namespace test2.Models
{
    /// <summary>
    /// Bang GiongCayChinh - Giong cay chinh
    /// </summary>
    public class GiongCayChinh
    {
  public int Id { get; set; }
  public string? Ten { get; set; }
        public string? PhanLoai { get; set; }
        public string? MuaVu { get; set; }
public int? SanLuong { get; set; }
}

    /// <summary>
    /// Bang GiongCayLuuHanh - Giong cay luu hanh tai Viet Nam
    /// </summary>
    public class GiongCayLuuHanh
    {
        public int Id { get; set; }
        public string LoaiCay { get; set; } = string.Empty;
        public string? NoiPhoBien { get; set; }
        public string? CongDung { get; set; }
        public string? DacDiem { get; set; }
}

    /// <summary>
/// Bang GiongCayDauDong - Giong cay dau dong
    /// </summary>
    public class GiongCayDauDong
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
  public string? NguonGoc { get; set; }
        public string? DacTinh { get; set; }
        public int? ThoiGianThuHoach { get; set; }
        public int? GiongId { get; set; }
        public int? VTId { get; set; }
    }
}
