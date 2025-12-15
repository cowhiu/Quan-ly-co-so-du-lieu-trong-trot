using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class DinhNghiaQuyenPage : Page
    {
        private ObservableCollection<QuyenCompat> _data = new();
        public DinhNghiaQuyenPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
        {
            _data = new ObservableCollection<QuyenCompat>
  {
        new QuyenCompat { Id = 1, MaQuyen = "Q01", TenQuyen = "Xem danh sach", Module = "Nguoi dung", MoTa = "Xem danh sach nguoi dung" },
      new QuyenCompat { Id = 2, MaQuyen = "Q02", TenQuyen = "Them moi", Module = "Nguoi dung", MoTa = "Them nguoi dung moi" },
new QuyenCompat { Id = 3, MaQuyen = "Q03", TenQuyen = "Sua", Module = "Nguoi dung", MoTa = "Sua thong tin nguoi dung" },
 new QuyenCompat { Id = 4, MaQuyen = "Q04", TenQuyen = "Xoa", Module = "Nguoi dung", MoTa = "Xoa nguoi dung" },
         new QuyenCompat { Id = 5, MaQuyen = "Q05", TenQuyen = "Xem danh sach", Module = "Cay trong", MoTa = "Xem danh sach cay trong" },
         };
         dgData.ItemsSource = _data;
      }

     private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Them quyen moi");
  private void BtnSua_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Sua quyen");
    private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is QuyenCompat s) _data.Remove(s); }
        private void BtnLamMoi_Click(object sender, RoutedEventArgs e) { LoadData(); }
    }
}
