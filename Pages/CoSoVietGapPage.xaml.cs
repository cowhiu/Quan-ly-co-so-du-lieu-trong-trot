using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class CoSoVietGapPage : Page
   {
        private ObservableCollection<CoSoVietGap> _danhSach = new();
        public CoSoVietGapPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
     {
  _danhSach = new ObservableCollection<CoSoVietGap>
   {
    new CoSoVietGap { Id = 1, MaCoSo = "VG001", TenCoSo = "HTX Rau s?ch ?à L?t", DiaChi = "?à L?t, Lâm ??ng", SanPham = "Rau c? qu?", SoGCN = "VG-2023-001" },
      new CoSoVietGap { Id = 2, MaCoSo = "VG002", TenCoSo = "Trang tr?i thanh long Bình Thu?n", DiaChi = "Bình Thu?n", SanPham = "Thanh long", SoGCN = "VG-2023-002" },
         };
            dgData.ItemsSource = _danhSach;
  }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm c? s? VietGap m?i");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n c? s?!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is CoSoVietGap item && MessageBox.Show($"Xóa '{item.TenCoSo}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
