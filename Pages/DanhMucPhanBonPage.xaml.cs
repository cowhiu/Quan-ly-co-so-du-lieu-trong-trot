using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class DanhMucPhanBonPage : Page
    {
        private ObservableCollection<PhanBonCompat> _danhSach = new();
     public DanhMucPhanBonPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
{
     _danhSach = new ObservableCollection<PhanBonCompat>
   {
new PhanBonCompat { Id = 1, MaPhanBon = "PB001", TenPhanBon = "Phan NPK 20-20-15", LoaiPhan = "NPK", ThanhPhan = "N20-P20-K15", NhaSanXuat = "Cong ty Phan bon A" },
   new PhanBonCompat { Id = 2, MaPhanBon = "PB002", TenPhanBon = "Phan Ure", LoaiPhan = "Dam", ThanhPhan = "N46%", NhaSanXuat = "Cong ty Phan bon B" },
     };
   dgData.ItemsSource = _danhSach;
        }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them phan bon moi");
       private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui long chon phan bon!"); }
   private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is PhanBonCompat item && MessageBox.Show($"Xoa '{item.TenPhanBon}'?", "Xac nhan", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
      private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
