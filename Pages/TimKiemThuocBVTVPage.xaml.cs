using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
   public partial class TimKiemThuocBVTVPage : Page
   {
        private ObservableCollection<ThuocBVTV> _danhSach = new();
public TimKiemThuocBVTVPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
 {
   _danhSach = new ObservableCollection<ThuocBVTV>
  {
  new ThuocBVTV { MaThuoc = "BVTV001", TenThuoc = "Thu?c tr? sâu A", HoatChat = "Abamectin", CongDung = "Tr? sâu cu?n lá" },
new ThuocBVTV { MaThuoc = "BVTV002", TenThuoc = "Thu?c tr? b?nh B", HoatChat = "Carbendazim", CongDung = "Tr? n?m b?nh" },
    };
      dgKetQua.ItemsSource = _danhSach;
       }
      private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
          var keyword = txtTenThuoc.Text.ToLower().Trim();
   dgKetQua.ItemsSource = _danhSach.Where(x => string.IsNullOrEmpty(keyword) || x.TenThuoc.ToLower().Contains(keyword)).ToList();
        }
  private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { txtTenThuoc.Text = ""; dgKetQua.ItemsSource = _danhSach; }
 }
}
