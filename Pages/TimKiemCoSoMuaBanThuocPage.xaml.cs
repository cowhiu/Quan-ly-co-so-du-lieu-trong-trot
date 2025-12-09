using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
   public partial class TimKiemCoSoMuaBanThuocPage : Page
    {
  private ObservableCollection<CoSoMuaBan> _danhSach = new();
      public TimKiemCoSoMuaBanThuocPage() { InitializeComponent(); LoadData(); }
     private void LoadData()
    {
   _danhSach = new ObservableCollection<CoSoMuaBan>
      {
      new CoSoMuaBan { TenCoSo = "C?a hàng v?t t? NN Hòa Bình", DiaChi = "Hòa Bình", SoDienThoai = "0912345678" },
        new CoSoMuaBan { TenCoSo = "??i lý thu?c BVTV Minh Phát", DiaChi = "Long An", SoDienThoai = "0987654321" },
     };
      dgKetQua.ItemsSource = _danhSach;
        }
    private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
    {
  var keyword = txtTenCoSo.Text.ToLower().Trim();
   dgKetQua.ItemsSource = _danhSach.Where(x => string.IsNullOrEmpty(keyword) || x.TenCoSo.ToLower().Contains(keyword)).ToList();
    }
   private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { txtTenCoSo.Text = ""; dgKetQua.ItemsSource = _danhSach; }
    }
}
