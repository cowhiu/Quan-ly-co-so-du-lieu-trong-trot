using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class TimKiemCoSoMuaBanPhanBonPage : Page
    {
        private ObservableCollection<CoSoMuaBan> _danhSach = new();
    public TimKiemCoSoMuaBanPhanBonPage() { InitializeComponent(); LoadData(); }
   private void LoadData()
        {
         _danhSach = new ObservableCollection<CoSoMuaBan>
  {
  new CoSoMuaBan { TenCoSo = "??i lý phân bón Tân Phú", DiaChi = "Bình D??ng", SoDienThoai = "0912345678" },
 new CoSoMuaBan { TenCoSo = "C?a hàng phân bón Minh H?ng", DiaChi = "??ng Nai", SoDienThoai = "0987654321" },
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
