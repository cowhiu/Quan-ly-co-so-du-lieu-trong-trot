namespace test2.Models
{
    /// <summary>
    /// Model ??i di?n cho Huy?n/Qu?n
    /// </summary>
    public class Huyen
    {
        public int Id { get; set; }
        public string MaHuyen { get; set; } = string.Empty;
        public string TenHuyen { get; set; } = string.Empty;
        public string? MaTinh { get; set; }
        public string? TenTinh { get; set; }
        public string? MoTa { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
    }

    /// <summary>
    /// Model ??i di?n cho Xã/Ph??ng
    /// </summary>
    public class Xa
    {
        public int Id { get; set; }
        public string MaXa { get; set; } = string.Empty;
        public string TenXa { get; set; } = string.Empty;
        public int HuyenId { get; set; }
        public string? TenHuyen { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime? NgayCapNhat { get; set; }
    }
}
