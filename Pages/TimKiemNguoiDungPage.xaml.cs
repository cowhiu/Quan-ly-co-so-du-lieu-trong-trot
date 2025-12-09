using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;
using System.Linq;

namespace test2.Pages
{
    public partial class TimKiemNguoiDungPage : Page
    {
        private readonly ObservableCollection<NguoiDung> _allData = new();

   public TimKiemNguoiDungPage()
{
      InitializeComponent();
            LoadData();
    }

        private void LoadData()
        {
   cboTrangThai.Items.Add("-- Tat ca --");
            cboTrangThai.Items.Add("Hoat dong");
     cboTrangThai.Items.Add("Khoa");
 cboTrangThai.SelectedIndex = 0;

     _allData.Add(new NguoiDung { MaNguoiDung = "ND001", HoTen = "Nguyen Van A", Email = "a@example.com", 
        SoDienThoai = "0901234567", TenNhomNguoiDung = "Quan tri", TenTrangThai = "Hoat dong" });
            _allData.Add(new NguoiDung { MaNguoiDung = "ND002", HoTen = "Tran Thi B", Email = "b@example.com", 
      SoDienThoai = "0902345678", TenNhomNguoiDung = "Nhan vien", TenTrangThai = "Hoat dong" });
    dgKetQua.ItemsSource = _allData;
        }

 private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            var filtered = _allData.Where(n =>
           (string.IsNullOrEmpty(txtTenNguoiDung.Text) || n.HoTen.ToLower().Contains(txtTenNguoiDung.Text.ToLower())) &&
         (cboTrangThai.SelectedIndex == 0 || n.TenTrangThai == cboTrangThai.SelectedItem?.ToString())
            ).ToList();
            dgKetQua.ItemsSource = filtered;
     }

        private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
    txtTenNguoiDung.Text = "";
            cboTrangThai.SelectedIndex = 0;
     dgKetQua.ItemsSource = _allData;
        }
    }
}
