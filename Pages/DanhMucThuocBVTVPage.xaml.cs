using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
  public partial class DanhMucThuocBVTVPage : Page
    {
 private ObservableCollection<ThuocBVTVCompat> _danhSach = new();
        public DanhMucThuocBVTVPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
    {
       _danhSach = new ObservableCollection<ThuocBVTVCompat>
 {
new ThuocBVTVCompat { Id = 1, MaThuoc = "BVTV001", TenThuoc = "Thuoc tri sau A", HoatChat = "Abamectin", CongDung = "Tri sau cuon la", NhaSanXuat = "Cong ty A" },
 new ThuocBVTVCompat { Id = 2, MaThuoc = "BVTV002", TenThuoc = "Thuoc tri benh B", HoatChat = "Carbendazim", CongDung = "Tri nam benh", NhaSanXuat = "Cong ty B" },
 };
   dgData.ItemsSource = _danhSach;
        }
private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them thuoc BVTV moi");
 private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui long chon thuoc!"); }
     private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is ThuocBVTVCompat item && MessageBox.Show($"Xoa '{item.TenThuoc}'?", "Xac nhan", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
 }
}
