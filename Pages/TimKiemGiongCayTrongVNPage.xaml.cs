using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemGiongCayTrongVNPage : Page
    {
private ObservableCollection<GiongCayTrongVN> _danhSach = new();
  public TimKiemGiongCayTrongVNPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
  _danhSach = new ObservableCollection<GiongCayTrongVN>
   {
      new GiongCayTrongVN { MaGiong = "VN001", TenGiong = "Lua OM5451", VungTrong = "DBSCL" },
      new GiongCayTrongVN { MaGiong = "VN002", TenGiong = "Lua ST25", VungTrong = "DBSCL" },
      };
    dgKetQua.ItemsSource = _danhSach;
 }
        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
    var keyword = txtTenGiong.Text.ToLower().Trim();
        dgKetQua.ItemsSource = _danhSach.Where(x => string.IsNullOrEmpty(keyword) || x.TenGiong.ToLower().Contains(keyword)).ToList();
        }
  private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { txtTenGiong.Text = ""; dgKetQua.ItemsSource = _danhSach; }
    }
}
