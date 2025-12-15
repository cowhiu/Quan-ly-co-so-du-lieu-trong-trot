using test2.Models;

namespace test2.Data.Repositories
{
    // ==================== HANH CHINH ====================
    public class BanDoPhanBoRepository : Repository<BanDoPhanBo>
    {
        public BanDoPhanBoRepository(AppDbContext context) : base(context) { }
    }

    public class HanhChinhRepository : Repository<HanhChinh>
    {
        public HanhChinhRepository(AppDbContext context) : base(context) { }
    }

    public class DonViRepository : Repository<DonVi>
    {
        public DonViRepository(AppDbContext context) : base(context) { }
    }

    public class VungTrongRepository : Repository<VungTrong>
    {
        public VungTrongRepository(AppDbContext context) : base(context) { }
    }

    public class PhanLoaiRepository : Repository<PhanLoai>
    {
        public PhanLoaiRepository(AppDbContext context) : base(context) { }
    }

    // ==================== TAI KHOAN ====================
    public class TaiKhoanRepository : Repository<TaiKhoan>
    {
        public TaiKhoanRepository(AppDbContext context) : base(context) { }
    }

    public class QuyenRepository : Repository<Quyen>
    {
        public QuyenRepository(AppDbContext context) : base(context) { }
    }

    public class HoSoRepository : Repository<HoSo>
    {
        public HoSoRepository(AppDbContext context) : base(context) { }
    }

    // ==================== GIONG CAY ====================
    public class GiongCayChinhRepository : Repository<GiongCayChinh>
    {
        public GiongCayChinhRepository(AppDbContext context) : base(context) { }
    }

    public class GiongCayLuuHanhRepository : Repository<GiongCayLuuHanh>
    {
        public GiongCayLuuHanhRepository(AppDbContext context) : base(context) { }
    }

    public class GiongCayDauDongRepository : Repository<GiongCayDauDong>
    {
        public GiongCayDauDongRepository(AppDbContext context) : base(context) { }
    }

    // ==================== THUOC BVTV ====================
    public class ThuocBVTVRepository : Repository<ThuocBVTV>
    {
        public ThuocBVTVRepository(AppDbContext context) : base(context) { }
    }

    public class CoSoBanThuocBVTVRepository : Repository<CoSoBanThuocBVTV>
    {
        public CoSoBanThuocBVTVRepository(AppDbContext context) : base(context) { }
    }

    public class CoSoSanXuatThuocBVTVRepository : Repository<CoSoSanXuatThuocBVTV>
    {
        public CoSoSanXuatThuocBVTVRepository(AppDbContext context) : base(context) { }
    }

    // ==================== PHAN BON ====================
    public class PhanBonRepository : Repository<PhanBon>
    {
        public PhanBonRepository(AppDbContext context) : base(context) { }
    }

    public class CoSoBanPhanBonRepository : Repository<CoSoBanPhanBon>
    {
        public CoSoBanPhanBonRepository(AppDbContext context) : base(context) { }
    }

    public class CoSoSanXuatPhanBonRepository : Repository<CoSoSanXuatPhanBon>
    {
        public CoSoSanXuatPhanBonRepository(AppDbContext context) : base(context) { }
    }

    // ==================== SINH VAT GAY HAI ====================
    public class SinhVatGayHaiRepository : Repository<SinhVatGayHai>
    {
        public SinhVatGayHaiRepository(AppDbContext context) : base(context) { }
    }

    public class CapNhat_SVGHRepository : Repository<CapNhat_SVGH>
    {
        public CapNhat_SVGHRepository(AppDbContext context) : base(context) { }
    }

    public class TuoiSauRepository : Repository<TuoiSau>
    {
        public TuoiSauRepository(AppDbContext context) : base(context) { }
    }

    public class CS_VGRepository : Repository<CS_VG>
    {
        public CS_VGRepository(AppDbContext context) : base(context) { }
    }
}
