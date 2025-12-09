using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace test2.Pages
{
    public partial class DangNhapPage : Page
    {
  public DangNhapPage()
        {
            InitializeComponent();
 }

        private void BtnDangNhap_Click(object sender, RoutedEventArgs e)
        {
  var username = txtUsername.Text;
            var password = txtPassword.Password;

   if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
       {
   MessageBox.Show("Vui long nhap ten dang nhap va mat khau!", "Canh bao", MessageBoxButton.OK, MessageBoxImage.Warning);
     return;
      }

    MessageBox.Show("Dang nhap thanh cong!", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Information);
      }

        private void QuenMatKhau_Click(object sender, MouseButtonEventArgs e)
     {
         if (this.NavigationService != null)
      {
   this.NavigationService.Navigate(new QuenMatKhauPage());
            }
        }
    }
}
