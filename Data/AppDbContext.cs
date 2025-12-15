using Microsoft.EntityFrameworkCore;
using test2.Models;

namespace test2.Data
{
    /// <summary>
    /// DbContext ket noi toi database KTPM
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // ==================== HANH CHINH ====================
        public DbSet<BanDoPhanBo> BanDoPhanBos { get; set; }
        public DbSet<HanhChinh> HanhChinhs { get; set; }
    public DbSet<DonVi> DonVis { get; set; }
   public DbSet<VungTrong> VungTrongs { get; set; }
        public DbSet<PhanLoai> PhanLoais { get; set; }

        // ==================== TAI KHOAN ====================
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
     public DbSet<Quyen> Quyens { get; set; }
        public DbSet<HoSo> HoSos { get; set; }

        // ==================== GIONG CAY ====================
        public DbSet<GiongCayChinh> GiongCayChinhs { get; set; }
        public DbSet<GiongCayLuuHanh> GiongCayLuuHanhs { get; set; }
     public DbSet<GiongCayDauDong> GiongCayDauDongs { get; set; }

   // ==================== THUOC BVTV ====================
     public DbSet<ThuocBVTV> ThuocBVTVs { get; set; }
        public DbSet<CoSoBanThuocBVTV> CoSoBanThuocBVTVs { get; set; }
     public DbSet<CoSoSanXuatThuocBVTV> CoSoSanXuatThuocBVTVs { get; set; }
    public DbSet<ThuocBVTV_CoSoBan> ThuocBVTV_CoSoBans { get; set; }
        public DbSet<ThuocBVTV_CoSoSanXuat> ThuocBVTV_CoSoSanXuats { get; set; }

        // ==================== PHAN BON ====================
        public DbSet<PhanBon> PhanBons { get; set; }
        public DbSet<CoSoBanPhanBon> CoSoBanPhanBons { get; set; }
        public DbSet<CoSoSanXuatPhanBon> CoSoSanXuatPhanBons { get; set; }
        public DbSet<PhanBon_CoSoBan> PhanBon_CoSoBans { get; set; }
        public DbSet<PhanBon_CoSoSanXuat> PhanBon_CoSoSanXuats { get; set; }

        // ==================== SINH VAT GAY HAI ====================
        public DbSet<SinhVatGayHai> SinhVatGayHais { get; set; }
   public DbSet<CapNhat_SVGH> CapNhat_SVGHs { get; set; }
   public DbSet<TuoiSau> TuoiSaus { get; set; }
        public DbSet<CS_VG> CS_VGs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       if (!optionsBuilder.IsConfigured)
            {
var connectionString = System.Configuration.ConfigurationManager
      .ConnectionStrings["DefaultConnection"]?.ConnectionString
   ?? "Server=localhost;Database=KTPM;Trusted_Connection=True;TrustServerCertificate=True;";
     optionsBuilder.UseSqlServer(connectionString);
}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      base.OnModelCreating(modelBuilder);

   // ==================== CAU HINH TEN BANG ====================
        modelBuilder.Entity<BanDoPhanBo>().ToTable("BanDoPhanBo");
            modelBuilder.Entity<HanhChinh>().ToTable("HanhChinh");
            modelBuilder.Entity<DonVi>().ToTable("DonVi");
   modelBuilder.Entity<VungTrong>().ToTable("VungTrong");
            modelBuilder.Entity<PhanLoai>().ToTable("PhanLoai");

         modelBuilder.Entity<TaiKhoan>().ToTable("TaiKhoan");
    modelBuilder.Entity<Quyen>().ToTable("Quyen");
          modelBuilder.Entity<HoSo>().ToTable("HoSo");

       modelBuilder.Entity<GiongCayChinh>().ToTable("GiongCayChinh");
      modelBuilder.Entity<GiongCayLuuHanh>().ToTable("GiongCayLuuHanh");
        modelBuilder.Entity<GiongCayDauDong>().ToTable("GiongCayDauDong");

         modelBuilder.Entity<ThuocBVTV>().ToTable("ThuocBVTV");
            modelBuilder.Entity<CoSoBanThuocBVTV>().ToTable("CoSoBanThuocBVTV");
  modelBuilder.Entity<CoSoSanXuatThuocBVTV>().ToTable("CoSoSanXuatThuocBVTV");
        modelBuilder.Entity<ThuocBVTV_CoSoBan>().ToTable("ThuocBVTV_CoSoBan");
     modelBuilder.Entity<ThuocBVTV_CoSoSanXuat>().ToTable("ThuocBVTV_CoSoSanXuat");

            modelBuilder.Entity<PhanBon>().ToTable("PhanBon");
            modelBuilder.Entity<CoSoBanPhanBon>().ToTable("CoSoBanPhanBon");
            modelBuilder.Entity<CoSoSanXuatPhanBon>().ToTable("CoSoSanXuatPhanBon");
            modelBuilder.Entity<PhanBon_CoSoBan>().ToTable("PhanBon_CoSoBan");
     modelBuilder.Entity<PhanBon_CoSoSanXuat>().ToTable("PhanBon_CoSoSanXuat");

            modelBuilder.Entity<SinhVatGayHai>().ToTable("SinhVatGayHai");
       modelBuilder.Entity<CapNhat_SVGH>().ToTable("CapNhat_SVGH");
       modelBuilder.Entity<TuoiSau>().ToTable("TuoiSau");
   modelBuilder.Entity<CS_VG>().ToTable("CS_VG");

            // ==================== CAU HINH KHOA CHINH ====================
// TaiKhoan co khoa chinh la Ten (varchar)
    modelBuilder.Entity<TaiKhoan>().HasKey(t => t.Ten);

// Bang lien ket co khoa chinh kep
            modelBuilder.Entity<ThuocBVTV_CoSoBan>().HasKey(t => new { t.ThuocBVTVId, t.CoSoBanId });
        modelBuilder.Entity<ThuocBVTV_CoSoSanXuat>().HasKey(t => new { t.ThuocBVTVId, t.CoSoSanXuatId });
 modelBuilder.Entity<PhanBon_CoSoBan>().HasKey(p => new { p.PhanBonId, p.CoSoBanId });
    modelBuilder.Entity<PhanBon_CoSoSanXuat>().HasKey(p => new { p.PhanBonId, p.CoSoSanXuatId });

            // Cau hinh cot TuoiSau trong bang TuoiSau
    modelBuilder.Entity<TuoiSau>()
      .Property(t => t.TuoiSauValue)
         .HasColumnName("TuoiSau");
        }
    }
}
