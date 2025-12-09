using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class QuanLyNguoiDungPage : Page
    {
   private ObservableCollection<NguoiDung> _danhSach = new();

     public QuanLyNguoiDungPage()
   {
      InitializeComponent();
       LoadData();
  }

        private void LoadData()
        {
 _danhSach = new ObservableCollection<NguoiDung>
      {
     new NguoiDung { Id = 1, MaNguoiDung = "ND001", HoTen = "Nguy?n V?n A", Email = "a@email.com", SoDienThoai = "0901234567", TenNhomNguoiDung = "Admin", TrangThai = TrangThaiNguoiDungEnum.HoatDong },
 new NguoiDung { Id = 2, MaNguoiDung = "ND002", HoTen = "Tr?n Th? B", Email = "b@email.com", SoDienThoai = "0912345678", TenNhomNguoiDung = "User", TrangThai = TrangThaiNguoiDungEnum.HoatDong },
    };
      dgNguoiDung.ItemsSource = _danhSach;
 }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
       MessageBox.Show("Thêm ng??i dùng m?i", "Thông báo");
 }

        private void BtnSua_Click(object sender, RoutedEventArgs e)
  {
   if (dgNguoiDung.SelectedItem == null)
       MessageBox.Show("Vui lòng ch?n ng??i dùng!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
      }

 private void BtnXoa_Click(object sender, RoutedEventArgs e)
  {
   if (dgNguoiDung.SelectedItem is NguoiDung nd)
       {
    if (MessageBox.Show($"Xóa '{nd.HoTen}'?", "Xác nh?n", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
         _danhSach.Remove(nd);
            }
  }

     private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
