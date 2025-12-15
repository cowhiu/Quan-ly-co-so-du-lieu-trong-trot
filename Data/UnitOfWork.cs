using test2.Data.Repositories;

namespace test2.Data
{
    /// <summary>
    /// Unit of Work - Quan ly tat ca cac repository cho database KTPM
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;

     // Hanh chinh
        private BanDoPhanBoRepository? _banDoPhanBoRepo;
      private HanhChinhRepository? _hanhChinhRepo;
        private DonViRepository? _donViRepo;
      private VungTrongRepository? _vungTrongRepo;
 private PhanLoaiRepository? _phanLoaiRepo;

        // Tai khoan
        private TaiKhoanRepository? _taiKhoanRepo;
 private QuyenRepository? _quyenRepo;
        private HoSoRepository? _hoSoRepo;

        // Giong cay
        private GiongCayChinhRepository? _giongCayChinhRepo;
   private GiongCayLuuHanhRepository? _giongCayLuuHanhRepo;
        private GiongCayDauDongRepository? _giongCayDauDongRepo;

      // Thuoc BVTV
    private ThuocBVTVRepository? _thuocBVTVRepo;
      private CoSoBanThuocBVTVRepository? _coSoBanThuocBVTVRepo;
    private CoSoSanXuatThuocBVTVRepository? _coSoSanXuatThuocBVTVRepo;

  // Phan bon
        private PhanBonRepository? _phanBonRepo;
        private CoSoBanPhanBonRepository? _coSoBanPhanBonRepo;
    private CoSoSanXuatPhanBonRepository? _coSoSanXuatPhanBonRepo;

      // Sinh vat gay hai
     private SinhVatGayHaiRepository? _sinhVatGayHaiRepo;
        private CapNhat_SVGHRepository? _capNhatSVGHRepo;
        private TuoiSauRepository? _tuoiSauRepo;
   private CS_VGRepository? _csVGRepo;

      public UnitOfWork()
        {
 _context = new AppDbContext();
     }

        public UnitOfWork(AppDbContext context)
      {
     _context = context;
     }

        // ==================== HANH CHINH ====================
        public BanDoPhanBoRepository BanDoPhanBos => _banDoPhanBoRepo ??= new BanDoPhanBoRepository(_context);
        public HanhChinhRepository HanhChinhs => _hanhChinhRepo ??= new HanhChinhRepository(_context);
        public DonViRepository DonVis => _donViRepo ??= new DonViRepository(_context);
        public VungTrongRepository VungTrongs => _vungTrongRepo ??= new VungTrongRepository(_context);
        public PhanLoaiRepository PhanLoais => _phanLoaiRepo ??= new PhanLoaiRepository(_context);

    // ==================== TAI KHOAN ====================
        public TaiKhoanRepository TaiKhoans => _taiKhoanRepo ??= new TaiKhoanRepository(_context);
        public QuyenRepository Quyens => _quyenRepo ??= new QuyenRepository(_context);
        public HoSoRepository HoSos => _hoSoRepo ??= new HoSoRepository(_context);

        // ==================== GIONG CAY ====================
        public GiongCayChinhRepository GiongCayChinhs => _giongCayChinhRepo ??= new GiongCayChinhRepository(_context);
        public GiongCayLuuHanhRepository GiongCayLuuHanhs => _giongCayLuuHanhRepo ??= new GiongCayLuuHanhRepository(_context);
        public GiongCayDauDongRepository GiongCayDauDongs => _giongCayDauDongRepo ??= new GiongCayDauDongRepository(_context);

    // ==================== THUOC BVTV ====================
        public ThuocBVTVRepository ThuocBVTVs => _thuocBVTVRepo ??= new ThuocBVTVRepository(_context);
        public CoSoBanThuocBVTVRepository CoSoBanThuocBVTVs => _coSoBanThuocBVTVRepo ??= new CoSoBanThuocBVTVRepository(_context);
        public CoSoSanXuatThuocBVTVRepository CoSoSanXuatThuocBVTVs => _coSoSanXuatThuocBVTVRepo ??= new CoSoSanXuatThuocBVTVRepository(_context);

        // ==================== PHAN BON ====================
        public PhanBonRepository PhanBons => _phanBonRepo ??= new PhanBonRepository(_context);
        public CoSoBanPhanBonRepository CoSoBanPhanBons => _coSoBanPhanBonRepo ??= new CoSoBanPhanBonRepository(_context);
        public CoSoSanXuatPhanBonRepository CoSoSanXuatPhanBons => _coSoSanXuatPhanBonRepo ??= new CoSoSanXuatPhanBonRepository(_context);

        // ==================== SINH VAT GAY HAI ====================
        public SinhVatGayHaiRepository SinhVatGayHais => _sinhVatGayHaiRepo ??= new SinhVatGayHaiRepository(_context);
        public CapNhat_SVGHRepository CapNhat_SVGHs => _capNhatSVGHRepo ??= new CapNhat_SVGHRepository(_context);
        public TuoiSauRepository TuoiSaus => _tuoiSauRepo ??= new TuoiSauRepository(_context);
        public CS_VGRepository CS_VGs => _csVGRepo ??= new CS_VGRepository(_context);

        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
        public int SaveChanges() => _context.SaveChanges();

        protected virtual void Dispose(bool disposing)
        {
     if (!_disposed)
   {
         if (disposing) _context.Dispose();
 _disposed = true;
    }
        }

        public void Dispose()
        {
   Dispose(true);
    GC.SuppressFinalize(this);
        }
    }
}
