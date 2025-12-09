using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class DanhMucThuocBVTVPage : Page
    {
 private ObservableCollection<ThuocBVTV> _danhSach = new();
      public DanhMucThuocBVTVPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
     {
     _danhSach = new ObservableCollection<ThuocBVTV>
    {
  new ThuocBVTV { Id = 1, MaThuoc = "BVTV001", TenThuoc = "Thu?c tr? sâu A", HoatChat = "Abamectin", CongDung = "Tr? sâu cu?n lá", NhaSanXuat = "Công ty A" },
   new ThuocBVTV { Id = 2, MaThuoc = "BVTV002", TenThuoc = "Thu?c tr? b?nh B", HoatChat = "Carbendazim", CongDung = "Tr? n?m b?nh", NhaSanXuat = "Công ty B" },
   };
dgData.ItemsSource = _danhSach;
 }
       private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm thu?c BVTV m?i");
  private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n thu?c!"); }
     private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is ThuocBVTV item && MessageBox.Show($"Xóa '{item.TenThuoc}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
      private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
 }
}
