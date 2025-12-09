using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class DanhMucGiongCayTrongPage : Page
{
        private ObservableCollection<GiongCayTrongChinh> _danhSach = new();

      public DanhMucGiongCayTrongPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
      {
       _danhSach = new ObservableCollection<GiongCayTrongChinh>
   {
 new GiongCayTrongChinh { Id = 1, MaGiong = "LUA001", TenGiong = "Lúa", TenKhoaHoc = "Oryza sativa", MoTa = "Cây l??ng th?c chính", TrangThai = true },
      new GiongCayTrongChinh { Id = 2, MaGiong = "NGO001", TenGiong = "Ngô", TenKhoaHoc = "Zea mays", MoTa = "Cây l??ng th?c", TrangThai = true },
          new GiongCayTrongChinh { Id = 3, MaGiong = "RAU001", TenGiong = "Rau mu?ng", TenKhoaHoc = "Ipomoea aquatica", MoTa = "Rau ?n lá", TrangThai = true },
    new GiongCayTrongChinh { Id = 4, MaGiong = "CAP001", TenGiong = "Cà phê", TenKhoaHoc = "Coffea", MoTa = "Cây công nghi?p", TrangThai = true },
     };
  dgData.ItemsSource = _danhSach;
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
     MessageBox.Show("Thêm gi?ng cây tr?ng m?i", "Thông báo");
        }

   private void BtnSua_Click(object sender, RoutedEventArgs e)
    {
 if (dgData.SelectedItem == null)
  MessageBox.Show("Vui lòng ch?n gi?ng cây tr?ng!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
      }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
   {
            if (dgData.SelectedItem is GiongCayTrongChinh item)
            {
        if (MessageBox.Show($"Xóa '{item.TenGiong}'?", "Xác nh?n", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
          _danhSach.Remove(item);
            }
        }

   private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
