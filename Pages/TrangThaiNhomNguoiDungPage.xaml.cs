using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class TrangThaiNhomNguoiDungPage : Page
    {
        private ObservableCollection<TrangThaiNguoiDung> _data = new();
        public TrangThaiNhomNguoiDungPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _data = new ObservableCollection<TrangThaiNguoiDung>
            {
                new TrangThaiNguoiDung { Id = 1, MaTrangThai = "TTNH01", TenTrangThai = "Ho?t ??ng", MoTa = "Nhóm ?ang ho?t ??ng", IsActive = true },
                new TrangThaiNguoiDung { Id = 2, MaTrangThai = "TTNH02", TenTrangThai = "Khóa", MoTa = "Nhóm b? khóa", IsActive = false },
            };
            dgData.ItemsSource = _data;
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm tr?ng thái m?i");
        private void BtnSua_Click(object sender, RoutedEventArgs e) => MessageBox.Show("S?a tr?ng thái");
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is TrangThaiNguoiDung s) _data.Remove(s); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { LoadData(); }
    }
}
