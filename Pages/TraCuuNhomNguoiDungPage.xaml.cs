using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TraCuuNhomNguoiDungPage : Page
    {
        private readonly ObservableCollection<NhomNguoiDung> _data = new();
        public TraCuuNhomNguoiDungPage()
     {
    InitializeComponent();
            _data.Add(new NhomNguoiDung { MaNhom = "NH01", TenNhom = "Quan tri vien", MoTa = "Nhom quan tri" });
     _data.Add(new NhomNguoiDung { MaNhom = "NH02", TenNhom = "Nhan vien", MoTa = "Nhom nhan vien" });
    dgKetQua.ItemsSource = _data;
        }

     private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
     {
   var keyword = txtTenNhom.Text.ToLower();
dgKetQua.ItemsSource = _data.Where(n => n.TenNhom.ToLower().Contains(keyword)).ToList();
      }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtTenNhom.Text = string.Empty;
         dgKetQua.ItemsSource = _data;
        }
 }
}
