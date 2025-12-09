using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class DanhMucPhanBonPage : Page
    {
        private ObservableCollection<PhanBon> _danhSach = new();
     public DanhMucPhanBonPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
       _danhSach = new ObservableCollection<PhanBon>
 {
       new PhanBon { Id = 1, MaPhanBon = "PB001", TenPhanBon = "Phân NPK 20-20-15", LoaiPhan = "NPK", ThanhPhan = "N20-P20-K15", NhaSanXuat = "Công ty Phân bón A" },
          new PhanBon { Id = 2, MaPhanBon = "PB002", TenPhanBon = "Phân Ure", LoaiPhan = "??m", ThanhPhan = "N46%", NhaSanXuat = "Công ty Phân bón B" },
            };
    dgData.ItemsSource = _danhSach;
        }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm phân bón m?i");
  private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n phân bón!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is PhanBon item && MessageBox.Show($"Xóa '{item.TenPhanBon}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
  private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
 }
}
