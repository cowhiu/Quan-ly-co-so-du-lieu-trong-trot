using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class SinhVatGayHaiPage : Page
    {
        private ObservableCollection<SinhVatGayHaiCompat> _danhSach = new();
        public SinhVatGayHaiPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
            _danhSach = new ObservableCollection<SinhVatGayHaiCompat>
            {
                new SinhVatGayHaiCompat { Id = 1, MaSinhVat = "SV001", TenSinhVat = "Sau cuon la nho", Loai = "Sau", CayBiHai = "Lua", MucDo = "Nang" },
                new SinhVatGayHaiCompat { Id = 2, MaSinhVat = "SV002", TenSinhVat = "Ray nau", Loai = "Ray", CayBiHai = "Lua", MucDo = "Trung binh" },
                new SinhVatGayHaiCompat { Id = 3, MaSinhVat = "SV003", TenSinhVat = "Benh dao on", Loai = "Nam", CayBiHai = "Lua", MucDo = "Nang" },
            };
            dgData.ItemsSource = _danhSach;
        }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them sinh vat gay hai moi");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui long chon sinh vat!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is SinhVatGayHaiCompat item && MessageBox.Show($"Xoa '{item.TenSinhVat}'?", "Xac nhan", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
