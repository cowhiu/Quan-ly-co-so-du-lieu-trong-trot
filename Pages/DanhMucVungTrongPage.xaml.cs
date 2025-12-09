using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class DanhMucVungTrongPage : Page
    {
      private ObservableCollection<VungTrong> _danhSach = new();
        public DanhMucVungTrongPage() { InitializeComponent(); LoadData(); }
     private void LoadData()
        {
       _danhSach = new ObservableCollection<VungTrong>
    {
    new VungTrong { Id = 1, MaVung = "VT001", TenVung = "Vùng tr?ng lúa ?BSCL", DiaDiem = "An Giang", DienTich = 5000, CayTrong = "Lúa" },
       new VungTrong { Id = 2, MaVung = "VT002", TenVung = "Vùng tr?ng cà phê Tây Nguyên", DiaDiem = "??k L?k", DienTich = 3000, CayTrong = "Cà phê" },
     };
            dgData.ItemsSource = _danhSach;
        }
   private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm vùng tr?ng m?i");
private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n vùng tr?ng!"); }
   private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is VungTrong item && MessageBox.Show($"Xóa '{item.TenVung}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
       private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
