using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class DanhMucVungTrongPage : Page
    {
        private ObservableCollection<VungTrongCompat> _danhSach = new();
        public DanhMucVungTrongPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
            _danhSach = new ObservableCollection<VungTrongCompat>
         {
            new VungTrongCompat { Id = 1, MaVung = "VT001", TenVung = "Vung trong lua DBSCL", DiaDiem = "An Giang", DienTich = 5000, CayTrong = "Lua" },
    new VungTrongCompat { Id = 2, MaVung = "VT002", TenVung = "Vung trong ca phe Tay Nguyen", DiaDiem = "Dak Lak", DienTich = 3000, CayTrong = "Ca phe" },
      };
            dgData.ItemsSource = _danhSach;
        }
       private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them vung trong moi");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui long chon vung trong!"); }
  private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is VungTrongCompat item && MessageBox.Show($"Xoa '{item.TenVung}'?", "Xac nhan", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
   private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
