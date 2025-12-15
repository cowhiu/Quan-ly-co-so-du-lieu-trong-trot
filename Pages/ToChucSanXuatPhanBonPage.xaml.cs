using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class ToChucSanXuatPhanBonPage : Page
    {
        private ObservableCollection<ToChucSanXuat> _danhSach = new();
        public ToChucSanXuatPhanBonPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
            _danhSach = new ObservableCollection<ToChucSanXuat>
            {
                new ToChucSanXuat { Id = 1, MaToChuc = "TC001", TenToChuc = "Cong ty CP Phan bon Binh Dien", DiaChi = "Long An", SoGCN = "GCN001", DangHoatDong = true },
                new ToChucSanXuat { Id = 2, MaToChuc = "TC002", TenToChuc = "Cong ty CP Phan bon Viet Nhat", DiaChi = "Binh Duong", SoGCN = "GCN002", DangHoatDong = true },
            };
            dgData.ItemsSource = _danhSach;
        }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them to chuc moi");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui long chon to chuc!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is ToChucSanXuat item && MessageBox.Show($"Xoa '{item.TenToChuc}'?", "Xac nhan", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
