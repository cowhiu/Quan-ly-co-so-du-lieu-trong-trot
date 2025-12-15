using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemThuocBVTVPage : Page
    {
        private ObservableCollection<ThuocBVTVCompat> _danhSach = new();
        public TimKiemThuocBVTVPage() { InitializeComponent(); LoadData(); }
   private void LoadData()
  {
   _danhSach = new ObservableCollection<ThuocBVTVCompat>
{
     new ThuocBVTVCompat { MaThuoc = "BVTV001", TenThuoc = "Thuoc tri sau A", HoatChat = "Abamectin", CongDung = "Tri sau cuon la" },
      new ThuocBVTVCompat { MaThuoc = "BVTV002", TenThuoc = "Thuoc tri benh B", HoatChat = "Carbendazim", CongDung = "Tri nam benh" },
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
