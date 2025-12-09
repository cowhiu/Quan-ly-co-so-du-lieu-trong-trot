using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
  public partial class CoSoMuaBanThuocPage : Page
    {
      private ObservableCollection<CoSoMuaBan> _danhSach = new();
      public CoSoMuaBanThuocPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
     {
    _danhSach = new ObservableCollection<CoSoMuaBan>
      {
      new CoSoMuaBan { Id = 1, MaCoSo = "CS001", TenCoSo = "C?a hàng v?t t? NN Hòa Bình", DiaChi = "Hòa Bình", SoDienThoai = "0912345678", DangHoatDong = true },
        new CoSoMuaBan { Id = 2, MaCoSo = "CS002", TenCoSo = "??i lý thu?c BVTV Minh Phát", DiaChi = "Long An", SoDienThoai = "0987654321", DangHoatDong = true },
};
    dgData.ItemsSource = _danhSach;
        }
   private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm c? s? m?i");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n c? s?!"); }
  private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is CoSoMuaBan item && MessageBox.Show($"Xóa '{item.TenCoSo}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
   private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
