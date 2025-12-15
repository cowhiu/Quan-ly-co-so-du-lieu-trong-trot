namespace test2.Models
{
    // ==================== MODELS TUONG THICH VOI PAGES CU ====================

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

    public enum TrangThaiNguoiDungEnum { HoatDong = 1, TamKhoa = 2, DaXoa = 3 }

    public class NguoiDung
    {
        public int Id { get; set; }
        public string MaNguoiDung { get; set; } = string.Empty;
     public string HoTen { get; set; } = string.Empty;
   public string TenNguoiDung { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
 public string SoDienThoai { get; set; } = string.Empty;
        public string? DiaChi { get; set; }
 public int? NhomNguoiDungId { get; set; }
  public string? TenNhomNguoiDung { get; set; }
        public string? TenTrangThai { get; set; }
     public TrangThaiNguoiDungEnum TrangThai { get; set; } = TrangThaiNguoiDungEnum.HoatDong;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    public class NhomNguoiDung
    {
   public int Id { get; set; }
     public string MaNhom { get; set; } = string.Empty;
     public string TenNhom { get; set; } = string.Empty;
    public string? TenTrangThai { get; set; }
        public string? MoTa { get; set; }
  public bool TrangThai { get; set; } = true;
     public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    public class TrangThaiNguoiDung
    {
     public int Id { get; set; }
 public string MaTrangThai { get; set; } = string.Empty;
     public string TenTrangThai { get; set; } = string.Empty;
        public string? MoTa { get; set; }
      public bool IsActive { get; set; } = true;
    }

    public class QuyenCompat
    {
   public int Id { get; set; }
        public string MaQuyen { get; set; } = string.Empty;
        public string TenQuyen { get; set; } = string.Empty;
  public string? Module { get; set; }
        public string? MoTa { get; set; }
  }

    public class GiongCayTrongChinh
    {
        public int Id { get; set; }
   public string MaGiong { get; set; } = string.Empty;
  public string TenGiong { get; set; } = string.Empty;
       public string? TenKhoaHoc { get; set; }
        public string? MoTa { get; set; }
        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
 }

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
        public bool TrangThai { get; set; } = true;
  public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    public class CayDauDong
    {
        public int Id { get; set; }
        public string MaCay { get; set; } = string.Empty;
    public string TenCay { get; set; } = string.Empty;
        public int? GiongCayTrongId { get; set; }
        public string? TenGiong { get; set; }
        public string? DiaChi { get; set; }
   public string? ChuSoHuu { get; set; }
  public double? DienTich { get; set; }
   public bool TrangThai { get; set; } = true;
  }

    public class CoSoMuaBan
  {
        public int Id { get; set; }
  public string MaCoSo { get; set; } = string.Empty;
     public string TenCoSo { get; set; } = string.Empty;
      public string? DiaChi { get; set; }
 public string? TenXa { get; set; }
        public string? ChuCoSo { get; set; }
        public string? SoDienThoai { get; set; }
   public bool DangHoatDong { get; set; } = true;
  public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    public class ToChucSanXuat
    {
public int Id { get; set; }
        public string MaToChuc { get; set; } = string.Empty;
    public string TenToChuc { get; set; } = string.Empty;
      public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
   public string? Email { get; set; }
        public string? SoGCN { get; set; }
        public bool DangHoatDong { get; set; } = true;
   public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    public class CoSoVietGap
    {
 public int Id { get; set; }
 public string MaCoSo { get; set; } = string.Empty;
        public string TenCoSo { get; set; } = string.Empty;
        public string? DiaChi { get; set; }
   public string? TenXa { get; set; }
 public string? ChuCoSo { get; set; }
      public string? SanPham { get; set; }
        public string? SoGCN { get; set; }
     public bool TrangThai { get; set; } = true;
   public DateTime NgayTao { get; set; } = DateTime.Now;
    }

    public class VungTrongCompat
    {
        public int Id { get; set; }
        public string MaVung { get; set; } = string.Empty;
        public string TenVung { get; set; } = string.Empty;
        public string? DiaDiem { get; set; }
        public double? DienTich { get; set; }
   public string? CayTrong { get; set; }
    public bool TrangThai { get; set; } = true;
    }

    public class SinhVatGayHaiCompat
    {
        public int Id { get; set; }
    public string MaSinhVat { get; set; } = string.Empty;
        public string TenSinhVat { get; set; } = string.Empty;
  public string? Loai { get; set; }
  public string? CayBiHai { get; set; }
        public string? MucDo { get; set; }
  public bool TrangThai { get; set; } = true;
    }

    public class ThuocBVTVCompat
    {
        public int Id { get; set; }
        public string MaThuoc { get; set; } = string.Empty;
        public string TenThuoc { get; set; } = string.Empty;
        public string? HoatChat { get; set; }
        public string? CongDung { get; set; }
     public string? NhaSanXuat { get; set; }
        public bool TrangThai { get; set; } = true;
    }

    public class PhanBonCompat
    {
        public int Id { get; set; }
        public string MaPhanBon { get; set; } = string.Empty;
  public string TenPhanBon { get; set; } = string.Empty;
        public string? ThanhPhan { get; set; }
     public string? LoaiPhan { get; set; }
        public string? NhaSanXuat { get; set; }
        public bool TrangThai { get; set; } = true;
  }
}
