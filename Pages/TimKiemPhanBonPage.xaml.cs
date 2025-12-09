using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class TimKiemPhanBonPage : Page
{
        private ObservableCollection<PhanBon> _danhSach = new();
        public TimKiemPhanBonPage() { InitializeComponent(); LoadData(); }
  private void LoadData()
 {
      _danhSach = new ObservableCollection<PhanBon>
            {
       new PhanBon { MaPhanBon = "PB001", TenPhanBon = "Phân NPK 20-20-15", LoaiPhan = "NPK", ThanhPhan = "N20-P20-K15" },
           new PhanBon { MaPhanBon = "PB002", TenPhanBon = "Phân Ure", LoaiPhan = "??m", ThanhPhan = "N46%" },
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
