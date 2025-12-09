using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace test2.Pages
{
    public partial class PhanQuyenNguoiDungPage : Page
{
        public PhanQuyenNguoiDungPage()
        {
            InitializeComponent();
 LoadData();
}

private void LoadData()
        {
    cboNguoiDung.Items.Add("Nguyen Van A");
            cboNguoiDung.Items.Add("Tran Thi B");
     cboNguoiDung.Items.Add("Le Van C");
         cboNguoiDung.SelectedIndex = 0;
        }

    private void BtnLuu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Da luu phan quyen cho nguoi dung!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
