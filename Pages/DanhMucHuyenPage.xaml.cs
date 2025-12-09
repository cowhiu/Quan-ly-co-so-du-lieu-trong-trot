using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class DanhMucHuyenPage : Page
    {
   private ObservableCollection<Huyen> _danhSachHuyen = new();
        private int _trangHienTai = 1;
   private int _tongTrang = 1;

        public DanhMucHuyenPage()
      {
       InitializeComponent();
   LoadData();
        }

        private void LoadData()
  {
   _danhSachHuyen = new ObservableCollection<Huyen>
       {
    new Huyen { Id = 1, MaHuyen = "H001", TenHuyen = "Quan 1", MaTinh = "T01", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
  new Huyen { Id = 2, MaHuyen = "H002", TenHuyen = "Quan 2", MaTinh = "T01", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
         new Huyen { Id = 3, MaHuyen = "H003", TenHuyen = "Quan 3", MaTinh = "T01", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
       new Huyen { Id = 4, MaHuyen = "H004", TenHuyen = "Huyen Cu Chi", MaTinh = "T01", TenTinh = "TP. Ho Chi Minh", TrangThai = true },
  new Huyen { Id = 5, MaHuyen = "H005", TenHuyen = "Quan Cau Giay", MaTinh = "T02", TenTinh = "TP. Ha Noi", TrangThai = true },
       };
  dgHuyen.ItemsSource = _danhSachHuyen;
            UpdatePagination();
        }

   private void UpdatePagination()
      {
       txtTrang.Text = $"Trang {_trangHienTai}/{_tongTrang}";
  }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
     {
 var dialog = new Dialogs.HuyenDialog();
if (dialog.ShowDialog() == true)
         {
   var huyen = dialog.Huyen;
  huyen.Id = _danhSachHuyen.Count + 1;
       _danhSachHuyen.Add(huyen);
     MessageBox.Show("Them huyen thanh cong!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
         }
      }

    private void BtnSua_Click(object sender, RoutedEventArgs e)
   {
 if (dgHuyen.SelectedItem is Huyen huyen)
    {
        var dialog = new Dialogs.HuyenDialog(huyen);
     if (dialog.ShowDialog() == true)
 {
     var index = _danhSachHuyen.IndexOf(huyen);
     if (index >= 0)
   {
        _danhSachHuyen[index] = dialog.Huyen;
    }
 dgHuyen.Items.Refresh();
       MessageBox.Show("Cap nhat thanh cong!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
  }
  }
    else
  {
      MessageBox.Show("Vui long chon mot huyen de sua!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
   }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
   if (dgHuyen.SelectedItem is Huyen huyen)
            {
           if (MessageBox.Show($"Ban co chac muon xoa huyen '{huyen.TenHuyen}'?", "Xac nhan xoa",
  MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
     {
 _danhSachHuyen.Remove(huyen);
      MessageBox.Show("Xoa thanh cong!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
      }
    }
    else
    {
      MessageBox.Show("Vui long chon mot huyen de xoa!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
        }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
{
     LoadData();
   }

     private void BtnTrangTruoc_Click(object sender, RoutedEventArgs e)
        {
     if (_trangHienTai > 1)
      {
             _trangHienTai--;
        UpdatePagination();
    }
     }

        private void BtnTrangSau_Click(object sender, RoutedEventArgs e)
 {
       if (_trangHienTai < _tongTrang)
       {
       _trangHienTai++;
        UpdatePagination();
      }
        }
    }
}
