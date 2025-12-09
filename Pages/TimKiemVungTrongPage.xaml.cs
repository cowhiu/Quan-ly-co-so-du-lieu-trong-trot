using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
   public partial class TimKiemVungTrongPage : Page
   {
        private ObservableCollection<VungTrong> _danhSach = new();
       public TimKiemVungTrongPage() { InitializeComponent(); LoadData(); }
      private void LoadData()
        {
    _danhSach = new ObservableCollection<VungTrong>
   {
        new VungTrong { TenVung = "Vùng tr?ng lúa ?BSCL", DiaDiem = "An Giang", CayTrong = "Lúa" },
        new VungTrong { TenVung = "Vùng tr?ng cà phê Tây Nguyên", DiaDiem = "??k L?k", CayTrong = "Cà phê" },
   };
    dgKetQua.ItemsSource = _danhSach;
        }
        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
    {
            var keyword = txtTenVung.Text.ToLower().Trim();
       dgKetQua.ItemsSource = _danhSach.Where(x => string.IsNullOrEmpty(keyword) || x.TenVung.ToLower().Contains(keyword)).ToList();
        }
private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { txtTenVung.Text = ""; dgKetQua.ItemsSource = _danhSach; }
    }
}
