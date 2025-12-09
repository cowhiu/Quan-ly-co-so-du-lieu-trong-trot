using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class GiongCayTrongVNPage : Page
    {
    private ObservableCollection<GiongCayTrongVN> _danhSach = new();
        public GiongCayTrongVNPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
      {
      _danhSach = new ObservableCollection<GiongCayTrongVN>
            {
      new GiongCayTrongVN { Id = 1, MaGiong = "VN001", TenGiong = "Lúa OM5451", NguonGoc = "Vi?t Nam", VungTrong = "?BSCL", NamCongNhan = 2015 },
        new GiongCayTrongVN { Id = 2, MaGiong = "VN002", TenGiong = "Lúa ST25", NguonGoc = "Vi?t Nam", VungTrong = "?BSCL", NamCongNhan = 2019 },
      };
       dgData.ItemsSource = _danhSach;
   }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm gi?ng m?i");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n gi?ng!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is GiongCayTrongVN item && MessageBox.Show($"Xóa '{item.TenGiong}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
      private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
  }
}
