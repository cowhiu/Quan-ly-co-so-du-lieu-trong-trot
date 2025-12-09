namespace test2.Models
{
    public class GiongCayTrong
    {
        public int Id { get; set; }
        public string MaGiong { get; set; } = string.Empty;
        public string TenGiong { get; set; } = string.Empty;
        public string? LoaiCay { get; set; }
        public string? XuatXu { get; set; }
        public string? DacDiem { get; set; }
        public string? ThoiGianSinhTruong { get; set; }
        public string? NangSuatDuKien { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model ??i di?n cho Gi?ng cây tr?ng chính
    /// </summary>
    public class GiongCayTrongChinh
    {
        public int Id { get; set; }
        public string MaGiong { get; set; } = string.Empty;
        public string TenGiong { get; set; } = string.Empty;
        public string? TenKhoaHoc { get; set; }
        public string? MoTa { get; set; }
        public string? HinhAnh { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model ??i di?n cho Gi?ng cây tr?ng t?i Vi?t Nam
    /// </summary>
    public class GiongCayTrongVN
    {
        public int Id { get; set; }
        public string MaGiong { get; set; } = string.Empty;
        public string TenGiong { get; set; } = string.Empty;
        public int? GiongCayTrongChinhId { get; set; }
        public string? TenGiongChinh { get; set; }
        public string? NguonGoc { get; set; }
        public string? DacDiem { get; set; }
        public string? VungTrong { get; set; }
        public int? NamCongNhan { get; set; }
        public string? CoQuanCongNhan { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Model ??i di?n cho Cây/V??n cây ??u dòng
    /// </summary>
    public class CayDauDong
    {
        public int Id { get; set; }
        public string MaCay { get; set; } = string.Empty;
        public string TenCay { get; set; } = string.Empty;
        public int? GiongCayTrongId { get; set; }
        public string? TenGiong { get; set; }
        public string? DiaChi { get; set; }
        public int? XaId { get; set; }
        public string? TenXa { get; set; }
        public string? ChuSoHuu { get; set; }
        public double? DienTich { get; set; }
        public int? NamTrong { get; set; }
        public string? TrangThaiPhatTrien { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}
