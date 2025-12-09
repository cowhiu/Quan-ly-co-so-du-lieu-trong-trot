using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class TimKiemCayDauDongPage : Page
    {
  private ObservableCollection<CayDauDong> _danhSach = new();
  public TimKiemCayDauDongPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
 {
   _danhSach = new ObservableCollection<CayDauDong>
    {
     new CayDauDong { MaCay = "CDD001", TenCay = "B??i ??u dòng", TenGiong = "B??i da xanh", ChuSoHuu = "Nguy?n V?n A" },
      new CayDauDong { MaCay = "CDD002", TenCay = "Xoài ??u dòng", TenGiong = "Xoài cát Hòa L?c", ChuSoHuu = "Tr?n V?n B" },
  };
         dgKetQua.ItemsSource = _danhSach;
        }
      private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
  {
     var keyword = txtTenCay.Text.ToLower().Trim();
 dgKetQua.ItemsSource = _danhSach.Where(x => string.IsNullOrEmpty(keyword) || x.TenCay.ToLower().Contains(keyword)).ToList();
    }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { txtTenCay.Text = ""; dgKetQua.ItemsSource = _danhSach; }
    }
}
