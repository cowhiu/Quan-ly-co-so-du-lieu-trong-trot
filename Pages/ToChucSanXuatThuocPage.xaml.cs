using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
  public partial class ToChucSanXuatThuocPage : Page
    {
        private ObservableCollection<ToChucSanXuat> _danhSach = new();
        public ToChucSanXuatThuocPage() { InitializeComponent(); LoadData(); }
      private void LoadData()
{
         _danhSach = new ObservableCollection<ToChucSanXuat>
  {
       new ToChucSanXuat { Id = 1, MaToChuc = "TC001", TenToChuc = "Cong ty CP Thuoc BVTV An Giang", DiaChi = "An Giang", SoGCN = "GCN001", DangHoatDong = true },
     new ToChucSanXuat { Id = 2, MaToChuc = "TC002", TenToChuc = "Cong ty TNHH Bayer Vietnam", DiaChi = "TP.HCM", SoGCN = "GCN002", DangHoatDong = true },
       };
        dgData.ItemsSource = _danhSach;
        }
 private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them to chuc moi");
 private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui long chon to chuc!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is ToChucSanXuat item && MessageBox.Show($"Xoa '{item.TenToChuc}'?", "Xac nhan", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
