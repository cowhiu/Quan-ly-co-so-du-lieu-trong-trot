using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class SinhVatGayHaiPage : Page
    {
        private ObservableCollection<SinhVatGayHai> _danhSach = new();
        public SinhVatGayHaiPage() { InitializeComponent(); LoadData(); }
   private void LoadData()
    {
            _danhSach = new ObservableCollection<SinhVatGayHai>
          {
          new SinhVatGayHai { Id = 1, MaSinhVat = "SV001", TenSinhVat = "Sâu cu?n lá nh?", Loai = "Sâu", CayBiHai = "Lúa", MucDo = "N?ng" },
  new SinhVatGayHai { Id = 2, MaSinhVat = "SV002", TenSinhVat = "R?y nâu", Loai = "R?y", CayBiHai = "Lúa", MucDo = "Trung bình" },
 new SinhVatGayHai { Id = 3, MaSinhVat = "SV003", TenSinhVat = "B?nh ??o ôn", Loai = "N?m", CayBiHai = "Lúa", MucDo = "N?ng" },
   };
            dgData.ItemsSource = _danhSach;
        }
      private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm sinh v?t gây h?i m?i");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n sinh v?t!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is SinhVatGayHai item && MessageBox.Show($"Xóa '{item.TenSinhVat}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
     private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
