using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class DanhMucXaPage : Page
    {
        private ObservableCollection<Xa> _danhSachXa = new();

        public DanhMucXaPage()
   {
  InitializeComponent();
  LoadData();
    }

   private void LoadData()
        {
    _danhSachXa = new ObservableCollection<Xa>
      {
    new Xa { Id = 1, MaXa = "X001", TenXa = "Phuong Ben Nghe", HuyenId = 1, TenHuyen = "Quan 1", TrangThai = true },
      new Xa { Id = 2, MaXa = "X002", TenXa = "Phuong Ben Thanh", HuyenId = 1, TenHuyen = "Quan 1", TrangThai = true },
    new Xa { Id = 3, MaXa = "X003", TenXa = "Phuong Cau Kho", HuyenId = 1, TenHuyen = "Quan 1", TrangThai = true },
       new Xa { Id = 4, MaXa = "X004", TenXa = "Xa Phu My Hung", HuyenId = 4, TenHuyen = "Huyen Cu Chi", TrangThai = true },
 };
dgXa.ItemsSource = _danhSachXa;
        }

     private void BtnThem_Click(object sender, RoutedEventArgs e)
  {
      MessageBox.Show("Mo dialog them xa moi", "Thong bao");
      }

      private void BtnSua_Click(object sender, RoutedEventArgs e)
     {
  if (dgXa.SelectedItem == null)
       MessageBox.Show("Vui long chon mot xa de sua!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
    }

 private void BtnXoa_Click(object sender, RoutedEventArgs e)
   {
         if (dgXa.SelectedItem is Xa xa)
      {
if (MessageBox.Show($"Ban co chac muon xoa xa '{xa.TenXa}'?", "Xac nhan",
     MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
     {
     _danhSachXa.Remove(xa);
  }
  }
}

     private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
   {
      LoadData();
      }
    }
}
