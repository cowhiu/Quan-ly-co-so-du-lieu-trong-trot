using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

   private void NavigateToPage(Page page, string breadcrumb)
    {
  WelcomeScreen.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(page);
      txtBreadcrumb.Text = breadcrumb;
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
    {
   if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", 
       MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
    {
    // Reset to welcome screen
         WelcomeScreen.Visibility = Visibility.Visible;
       MainFrame.Content = null;
          txtBreadcrumb.Text = "Trang chủ";
            }
        }

        #region Quản lý đơn vị hành chính
        private void MenuDanhMucHuyen_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.DanhMucHuyenPage(), "Quản lý đơn vị hành chính > Danh mục huyện");
}

        private void MenuTimKiemHuyen_Click(object sender, RoutedEventArgs e)
{
  NavigateToPage(new Pages.TimKiemHuyenPage(), "Quản lý đơn vị hành chính > Tìm kiếm huyện");
        }

        private void MenuDanhMucXa_Click(object sender, RoutedEventArgs e)
   {
            NavigateToPage(new Pages.DanhMucXaPage(), "Quản lý đơn vị hành chính > Danh mục xã");
    }

        private void MenuTimKiemXa_Click(object sender, RoutedEventArgs e)
        {
    NavigateToPage(new Pages.TimKiemXaPage(), "Quản lý đơn vị hành chính > Tìm kiếm xã");
  }
        #endregion

  #region Quản lý người dùng
private void MenuQuanLyNguoiDung_Click(object sender, RoutedEventArgs e)
      {
            NavigateToPage(new Pages.QuanLyNguoiDungPage(), "Quản lý người dùng > Danh sách người dùng");
        }

        private void MenuTimKiemNguoiDung_Click(object sender, RoutedEventArgs e)
        {
   NavigateToPage(new Pages.TimKiemNguoiDungPage(), "Quản lý người dùng > Tìm kiếm người dùng");
        }

        private void MenuTrangThaiNguoiDung_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.TrangThaiNguoiDungPage(), "Quản lý người dùng > Trạng thái người dùng");
        }

        private void MenuDinhNghiaQuyen_Click(object sender, RoutedEventArgs e)
        {
      NavigateToPage(new Pages.DinhNghiaQuyenPage(), "Quản lý người dùng > Định nghĩa quyền");
        }

     private void MenuNhomNguoiDung_Click(object sender, RoutedEventArgs e)
        {
       NavigateToPage(new Pages.NhomNguoiDungPage(), "Quản lý người dùng > Nhóm người dùng");
        }

        private void MenuTrangThaiNhomNguoiDung_Click(object sender, RoutedEventArgs e)
        {
  NavigateToPage(new Pages.TrangThaiNhomNguoiDungPage(), "Quản lý người dùng > Trạng thái nhóm");
        }

        private void MenuTraCuuNhomNguoiDung_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.TraCuuNhomNguoiDungPage(), "Quản lý người dùng > Tra cứu nhóm");
        }

        private void MenuPhanQuyenNhom_Click(object sender, RoutedEventArgs e)
        {
     NavigateToPage(new Pages.PhanQuyenNhomPage(), "Quản lý người dùng > Phân quyền nhóm");
        }

        private void MenuTraCuuPhanQuyenNhom_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.TraCuuPhanQuyenNhomPage(), "Quản lý người dùng > Tra cứu phân quyền nhóm");
  }

   private void MenuPhanQuyenNguoiDung_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.PhanQuyenNguoiDungPage(), "Quản lý người dùng > Phân quyền người dùng");
        }

private void MenuTraCuuPhanQuyenNguoiDung_Click(object sender, RoutedEventArgs e)
        {
       NavigateToPage(new Pages.TraCuuPhanQuyenNguoiDungPage(), "Quản lý người dùng > Tra cứu phân quyền");
        }
     #endregion

        #region Quản lý tài khoản
        private void MenuDangNhap_Click(object sender, RoutedEventArgs e)
        {
  var loginWindow = new Windows.LoginWindow();
loginWindow.ShowDialog();
        }

        private void MenuQuenMatKhau_Click(object sender, RoutedEventArgs e)
        {
   var forgotPasswordWindow = new Windows.ForgotPasswordWindow();
            forgotPasswordWindow.ShowDialog();
     }

        private void MenuThongTinTaiKhoan_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.ThongTinTaiKhoanPage(), "Quản lý tài khoản > Thông tin tài khoản");
        }

    private void MenuDoiMatKhau_Click(object sender, RoutedEventArgs e)
     {
   var changePasswordWindow = new Windows.ChangePasswordWindow();
         changePasswordWindow.ShowDialog();
        }

   private void MenuDangXuat_Click(object sender, RoutedEventArgs e)
        {
      BtnLogout_Click(sender, e);
        }
        #endregion

        #region Quản lý giống cây trồng
        private void MenuDanhMucGiongCayTrong_Click(object sender, RoutedEventArgs e)
        {
 NavigateToPage(new Pages.DanhMucGiongCayTrongPage(), "Quản lý giống cây trồng > Danh mục giống");
   }

        private void MenuTimKiemCayTrongChinh_Click(object sender, RoutedEventArgs e)
        {
         NavigateToPage(new Pages.TimKiemCayTrongChinhPage(), "Quản lý giống cây trồng > Tìm kiếm cây trồng chính");
        }

        private void MenuGiongCayTrongVN_Click(object sender, RoutedEventArgs e)
        {
        NavigateToPage(new Pages.GiongCayTrongVNPage(), "Quản lý giống cây trồng > Giống cây trồng tại VN");
        }

      private void MenuTimKiemGiongCayTrongVN_Click(object sender, RoutedEventArgs e)
        {
       NavigateToPage(new Pages.TimKiemGiongCayTrongVNPage(), "Quản lý giống cây trồng > Tìm kiếm giống tại VN");
   }

        private void MenuCayDauDong_Click(object sender, RoutedEventArgs e)
        {
 NavigateToPage(new Pages.CayDauDongPage(), "Quản lý giống cây trồng > Cây/Vườn cây đầu dòng");
        }

  private void MenuTimKiemCayDauDong_Click(object sender, RoutedEventArgs e)
        {
NavigateToPage(new Pages.TimKiemCayDauDongPage(), "Quản lý giống cây trồng > Tìm kiếm cây đầu dòng");
        }
        #endregion

        #region Quản lý thuốc BVTV
        private void MenuDanhMucThuocBVTV_Click(object sender, RoutedEventArgs e)
    {
         NavigateToPage(new Pages.DanhMucThuocBVTVPage(), "Quản lý thuốc BVTV > Danh mục thuốc");
        }

        private void MenuTimKiemThuocBVTV_Click(object sender, RoutedEventArgs e)
    {
            NavigateToPage(new Pages.TimKiemThuocBVTVPage(), "Quản lý thuốc BVTV > Tìm kiếm thuốc");
   }

 private void MenuToChucSanXuatThuoc_Click(object sender, RoutedEventArgs e)
        {
     NavigateToPage(new Pages.ToChucSanXuatThuocPage(), "Quản lý thuốc BVTV > Tổ chức sản xuất thuốc");
      }

        private void MenuCoSoMuaBanThuoc_Click(object sender, RoutedEventArgs e)
        {
       NavigateToPage(new Pages.CoSoMuaBanThuocPage(), "Quản lý thuốc BVTV > Cơ sở mua bán thuốc");
        }

        private void MenuTimKiemCoSoMuaBanThuoc_Click(object sender, RoutedEventArgs e)
        {
        NavigateToPage(new Pages.TimKiemCoSoMuaBanThuocPage(), "Quản lý thuốc BVTV > Tìm kiếm cơ sở mua bán");
   }
      #endregion

#region Quản lý phân bón
      private void MenuDanhMucPhanBon_Click(object sender, RoutedEventArgs e)
    {
     NavigateToPage(new Pages.DanhMucPhanBonPage(), "Quản lý phân bón > Danh mục phân bón");
        }

        private void MenuTimKiemPhanBon_Click(object sender, RoutedEventArgs e)
  {
    NavigateToPage(new Pages.TimKiemPhanBonPage(), "Quản lý phân bón > Tìm kiếm phân bón");
      }

        private void MenuToChucSanXuatPhanBon_Click(object sender, RoutedEventArgs e)
 {
            NavigateToPage(new Pages.ToChucSanXuatPhanBonPage(), "Quản lý phân bón > Tổ chức sản xuất phân bón");
        }

        private void MenuCoSoMuaBanPhanBon_Click(object sender, RoutedEventArgs e)
        {
     NavigateToPage(new Pages.CoSoMuaBanPhanBonPage(), "Quản lý phân bón > Cơ sở mua bán phân bón");
        }

        private void MenuTimKiemCoSoMuaBanPhanBon_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.TimKiemCoSoMuaBanPhanBonPage(), "Quản lý phân bón > Tìm kiếm cơ sở mua bán");
        }
        #endregion

 #region Quản lý sản xuất trồng trọt
        private void MenuCoSoVietGap_Click(object sender, RoutedEventArgs e)
        {
NavigateToPage(new Pages.CoSoVietGapPage(), "Quản lý sản xuất > Cơ sở đủ ATTP VietGap");
}

private void MenuTimKiemCoSoVietGap_Click(object sender, RoutedEventArgs e)
        {
      NavigateToPage(new Pages.TimKiemCoSoVietGapPage(), "Quản lý sản xuất > Tìm kiếm cơ sở VietGap");
        }

        private void MenuDanhMucVungTrong_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.DanhMucVungTrongPage(), "Quản lý sản xuất > Danh mục vùng trồng");
        }

        private void MenuTimKiemVungTrong_Click(object sender, RoutedEventArgs e)
  {
      NavigateToPage(new Pages.TimKiemVungTrongPage(), "Quản lý sản xuất > Tìm kiếm vùng trồng");
        }

        private void MenuSinhVatGayHai_Click(object sender, RoutedEventArgs e)
     {
 NavigateToPage(new Pages.SinhVatGayHaiPage(), "Quản lý sản xuất > Sinh vật gây hại");
    }

        private void MenuCapNhatSinhVatGayHai_Click(object sender, RoutedEventArgs e)
        {
      NavigateToPage(new Pages.CapNhatSinhVatGayHaiPage(), "Quản lý sản xuất > Cập nhật sinh vật gây hại");
        }

        private void MenuTuoiSauCapDo_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(new Pages.TuoiSauCapDoPage(), "Quản lý sản xuất > Tuổi sâu, cấp độ phổ biến");
        }

        private void MenuTimKiemSinhVatGayHaiMap_Click(object sender, RoutedEventArgs e)
        {
NavigateToPage(new Pages.TimKiemSinhVatGayHaiMapPage(), "Quản lý sản xuất > Bản đồ sinh vật gây hại");
        }
        #endregion
    }
}