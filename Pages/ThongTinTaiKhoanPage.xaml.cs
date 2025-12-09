using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class ThongTinTaiKhoanPage : Page
    {
        public ThongTinTaiKhoanPage()
        {
            InitializeComponent();
        }

        private void BtnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Da cap nhat thong tin tai khoan!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
