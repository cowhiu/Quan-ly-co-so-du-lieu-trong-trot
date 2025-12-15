using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemCoSoVietGapPage : Page
    {
        private ObservableCollection<CoSoVietGap> _danhSach = new();
        public TimKiemCoSoVietGapPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
  _danhSach = new ObservableCollection<CoSoVietGap>
   {
       new CoSoVietGap { TenCoSo = "HTX Rau sach Da Lat", SanPham = "Rau cu qua", SoGCN = "VG-2023-001" },
       new CoSoVietGap { TenCoSo = "Trang trai thanh long Binh Thuan", SanPham = "Thanh long", SoGCN = "VG-2023-002" },
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
