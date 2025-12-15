namespace test2.Models
{
    /// <summary>
    /// Bang TaiKhoan - Tai khoan dang nhap
    /// </summary>
    public class TaiKhoan
    {
        public string Ten { get; set; } = string.Empty; // Primary Key
        public string? MatKhau { get; set; }
        public int? QuyenID { get; set; }
        public int? HoSoId { get; set; }
    }

    /// <summary>
    /// Bang Quyen - Quyen han
    /// </summary>
    public class Quyen
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
        public string? Ext { get; set; }
    }

    /// <summary>
    /// Bang HoSo - Ho so nguoi dung
    /// </summary>
    public class HoSo
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? Ext { get; set; }
    }
}
