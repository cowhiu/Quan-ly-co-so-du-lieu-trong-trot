using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class TrangThaiNguoiDungPage : Page
    {
        private ObservableCollection<TrangThaiNguoiDung> _data = new();
        public TrangThaiNguoiDungPage()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            _data = new ObservableCollection<TrangThaiNguoiDung>
            {
                new TrangThaiNguoiDung { Id = 1, MaTrangThai = "TT01", TenTrangThai = "Hoat dong", MoTa = "Tai khoan dang hoat dong", IsActive = true },
                new TrangThaiNguoiDung { Id = 2, MaTrangThai = "TT02", TenTrangThai = "Khoa", MoTa = "Tai khoan bi khoa", IsActive = true },
                new TrangThaiNguoiDung { Id = 3, MaTrangThai = "TT03", TenTrangThai = "Cho duyet", MoTa = "Tai khoan cho phe duyet", IsActive = true },
            };
            dgData.ItemsSource = _data;
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them trang thai moi");
        private void BtnSua_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Sua trang thai");
        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedItem is TrangThaiNguoiDung s) _data.Remove(s);
        }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { LoadData(); }
    }
}
