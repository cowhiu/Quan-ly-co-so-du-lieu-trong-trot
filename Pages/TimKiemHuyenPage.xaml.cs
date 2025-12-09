using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemHuyenPage : Page
    {
     private ObservableCollection<Huyen> _danhSachHuyen = new();

 public TimKiemHuyenPage()
    {
        InitializeComponent();
        LoadData();
       }

private void LoadData()
        {
     _danhSachHuyen = new ObservableCollection<Huyen>
 {
     new Huyen { Id = 1, MaHuyen = "H001", TenHuyen = "Quan 1", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
   new Huyen { Id = 2, MaHuyen = "H002", TenHuyen = "Quan 2", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
  new Huyen { Id = 3, MaHuyen = "H003", TenHuyen = "Quan 3", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
   new Huyen { Id = 4, MaHuyen = "H004", TenHuyen = "Huyen Cu Chi", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
    new Huyen { Id = 5, MaHuyen = "H005", TenHuyen = "Quan Cau Giay", TenTinh = "TP. Ha Noi", TrangThai = true },
        };
       dgKetQua.ItemsSource = _danhSachHuyen;
        }

        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
    {
   var maHuyen = txtMaHuyen.Text.ToLower().Trim();
    var tenHuyen = txtTenHuyen.Text.ToLower().Trim();

    var ketQua = _danhSachHuyen.Where(h =>
         (string.IsNullOrEmpty(maHuyen) || h.MaHuyen.ToLower().Contains(maHuyen)) &&
    (string.IsNullOrEmpty(tenHuyen) || h.TenHuyen.ToLower().Contains(tenHuyen))
       ).ToList();

            dgKetQua.ItemsSource = ketQua;
       MessageBox.Show($"Tim thay {ketQua.Count} ket qua", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
     }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
   {
      txtMaHuyen.Text = string.Empty;
      txtTenHuyen.Text = string.Empty;
    dgKetQua.ItemsSource = _danhSachHuyen;
   }
    }
}
