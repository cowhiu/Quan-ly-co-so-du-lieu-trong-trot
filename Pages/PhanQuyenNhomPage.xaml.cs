using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using test2.Models;

namespace test2.Pages
{
    public partial class PhanQuyenNhomPage : Page
    {
        public class QuyenItem { public bool ChoPhep { get; set; } public string MaQuyen { get; set; } = ""; public string TenQuyen { get; set; } = ""; public string? MoTa { get; set; } public bool DuocPhep { get; set; } }
        private readonly ObservableCollection<QuyenItem> _quyenList = new();
        public PhanQuyenNhomPage()
        {
            InitializeComponent();
            _quyenList.Add(new QuyenItem { MaQuyen = "Q01", TenQuyen = "Xem danh sach nguoi dung" });
            _quyenList.Add(new QuyenItem { MaQuyen = "Q02", TenQuyen = "Them nguoi dung" });
            _quyenList.Add(new QuyenItem { MaQuyen = "Q03", TenQuyen = "Sua nguoi dung" });
            _quyenList.Add(new QuyenItem { MaQuyen = "Q04", TenQuyen = "Xoa nguoi dung" });
            _quyenList.Add(new QuyenItem { MaQuyen = "Q05", TenQuyen = "Quan ly cay trong" });
            dgQuyen.ItemsSource = _quyenList;

            cboNhom.Items.Add("Admin");
            cboNhom.Items.Add("User");
            cboNhom.Items.Add("Guest");
            cboNhom.SelectedIndex = 0;
        }

        private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Da luu phan quyen!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
