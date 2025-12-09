using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemXaPage : Page
    {
        private ObservableCollection<Xa> _danhSachXa = new();

        public TimKiemXaPage()
        {
        InitializeComponent();
            LoadData();
        }

   private void LoadData()
   {
        _danhSachXa = new ObservableCollection<Xa>
        {
          new Xa { Id = 1, MaXa = "X001", TenXa = "Phuong Ben Nghe", TenHuyen = "Quan 1", TrangThai = true },
        new Xa { Id = 2, MaXa = "X002", TenXa = "Phuong Ben Thanh", TenHuyen = "Quan 1", TrangThai = true },
     new Xa { Id = 3, MaXa = "X003", TenXa = "Phuong Cau Kho", TenHuyen = "Quan 1", TrangThai = true },
   };
 dgKetQua.ItemsSource = _danhSachXa;
 }

  private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
    {
    var tenXa = txtTenXa.Text.ToLower().Trim();

           var ketQua = _danhSachXa.Where(x =>
  (string.IsNullOrEmpty(tenXa) || x.TenXa.ToLower().Contains(tenXa))
       ).ToList();

       dgKetQua.ItemsSource = ketQua;
   }

private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
       txtTenXa.Text = string.Empty;
dgKetQua.ItemsSource = _danhSachXa;
        }
    }
}
