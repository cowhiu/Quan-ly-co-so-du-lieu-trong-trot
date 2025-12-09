using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemCayTrongChinhPage : Page
  {
     private ObservableCollection<GiongCayTrongChinh> _danhSach = new();

        public TimKiemCayTrongChinhPage()
     {
       InitializeComponent();
    LoadData();
        }

  private void LoadData()
  {
     _danhSach = new ObservableCollection<GiongCayTrongChinh>
      {
    new GiongCayTrongChinh { Id = 1, MaGiong = "LUA001", TenGiong = "Lua", TenKhoaHoc = "Oryza sativa" },
         new GiongCayTrongChinh { Id = 2, MaGiong = "NGO001", TenGiong = "Ngo", TenKhoaHoc = "Zea mays" },
     };
  dgKetQua.ItemsSource = _danhSach;
        }

        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
   var ten = txtTenGiong.Text.ToLower().Trim();
   var ketQua = _danhSach.Where(x =>
   (string.IsNullOrEmpty(ten) || x.TenGiong.ToLower().Contains(ten))
   ).ToList();
   dgKetQua.ItemsSource = ketQua;
     }

    private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
 {
      txtTenGiong.Text = string.Empty;
      dgKetQua.ItemsSource = _danhSach;
        }
    }
}
