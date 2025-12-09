using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class CayDauDongPage : Page
    {
  private ObservableCollection<CayDauDong> _danhSach = new();
      public CayDauDongPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
            _danhSach = new ObservableCollection<CayDauDong>
 {
  new CayDauDong { Id = 1, MaCay = "CDD001", TenCay = "B??i ??u dòng", TenGiong = "B??i da xanh", DiaChi = "Ti?n Giang", ChuSoHuu = "Nguy?n V?n A" },
    new CayDauDong { Id = 2, MaCay = "CDD002", TenCay = "Xoài ??u dòng", TenGiong = "Xoài cát Hòa L?c", DiaChi = "??ng Tháp", ChuSoHuu = "Tr?n V?n B" },
};
       dgData.ItemsSource = _danhSach;
}
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm cây ??u dòng m?i");
   private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n cây!"); }
        private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is CayDauDong item && MessageBox.Show($"Xóa '{item.TenCay}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
 }
}
