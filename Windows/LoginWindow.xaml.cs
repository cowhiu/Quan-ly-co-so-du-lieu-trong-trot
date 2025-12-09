using System.Windows;

namespace test2.Windows
{
    public partial class LoginWindow : Window
    {
   public LoginWindow() { InitializeComponent(); txtUsername.Focus(); }
        private void BtnDangNhap_Click(object sender, RoutedEventArgs e)
    {
        var username = txtUsername.Text.Trim();
       var password = txtPassword.Password;
  if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
           {
         MessageBox.Show("Vui lòng nh?p ??y ?? thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
      return;
      }
    if (username == "admin" && password == "123456")
            {
   MessageBox.Show("??ng nh?p thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
      DialogResult = true;
Close();
  }
     else
  {
    MessageBox.Show("Tên ??ng nh?p ho?c m?t kh?u không ?úng!", "L?i", MessageBoxButton.OK, MessageBoxImage.Error);
  }
        }
        private void BtnHuy_Click(object sender, RoutedEventArgs e) => Close();
    }
}
