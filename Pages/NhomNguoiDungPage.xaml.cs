using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class NhomNguoiDungPage : Page
    {
        private ObservableCollection<NhomNguoiDung> _data = new();
        public NhomNguoiDungPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
            _data = new ObservableCollection<NhomNguoiDung>
            {
                new NhomNguoiDung { Id = 1, MaNhom = "NH01", TenNhom = "Quan tri vien", TenTrangThai = "Hoat dong", MoTa = "Nhom quan tri he thong" },
                new NhomNguoiDung { Id = 2, MaNhom = "NH02", TenNhom = "Nhan vien", TenTrangThai = "Hoat dong", MoTa = "Nhom nhan vien thuong" },
                new NhomNguoiDung { Id = 3, MaNhom = "NH03", TenNhom = "Khach", TenTrangThai = "Hoat dong", MoTa = "Nhom khach truy cap" },
            };
            dgData.ItemsSource = _data;
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them nhom moi");
        private void BtnSua_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Sua nhom");
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is NhomNguoiDung s) _data.Remove(s); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { LoadData(); }
    }
}
