using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemPhanBonPage : Page
    {
        private ObservableCollection<PhanBonCompat> _danhSach = new();
        public TimKiemPhanBonPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
            _danhSach = new ObservableCollection<PhanBonCompat>
            {
                new PhanBonCompat { MaPhanBon = "PB001", TenPhanBon = "Phan NPK 20-20-15", LoaiPhan = "NPK", ThanhPhan = "N20-P20-K15" },
                new PhanBonCompat { MaPhanBon = "PB002", TenPhanBon = "Phan Ure", LoaiPhan = "Dam", ThanhPhan = "N46%" },
            };
            dgKetQua.ItemsSource = _danhSach;
        }
        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            var keyword = txtTenPhanBon.Text.ToLower().Trim();
            dgKetQua.ItemsSource = _danhSach.Where(x => string.IsNullOrEmpty(keyword) || x.TenPhanBon.ToLower().Contains(keyword)).ToList();
        }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { txtTenPhanBon.Text = ""; dgKetQua.ItemsSource = _danhSach; }
    }
}
