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
                new CoSoVietGap { Id = 1, MaCoSo = "VG001", TenCoSo = "HTX Rau sach Da Lat", DiaChi = "Da Lat, Lam Dong", SanPham = "Rau cu qua", SoGCN = "VG-2023-001" },
                new CoSoVietGap { Id = 2, MaCoSo = "VG002", TenCoSo = "Trang trai thanh long Binh Thuan", DiaChi = "Binh Thuan", SanPham = "Thanh long", SoGCN = "VG-2023-002" },
            };
            dgData.ItemsSource = _danhSach;
        }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them co so VietGap moi");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui long chon co so!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is CoSoVietGap item && MessageBox.Show($"Xoa '{item.TenCoSo}'?", "Xac nhan", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
