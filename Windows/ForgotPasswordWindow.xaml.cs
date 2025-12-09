using System.Windows;

namespace test2.Windows
{
  public partial class ForgotPasswordWindow : Window
    {
        public ForgotPasswordWindow() { InitializeComponent(); txtEmail.Focus(); }
  private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
  var email = txtEmail.Text.Trim();
if (string.IsNullOrEmpty(email) || !email.Contains("@"))
     {
  MessageBox.Show("Vui lòng nh?p email h?p l?!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
       return;
  }
     MessageBox.Show($"?ã g?i liên k?t ??t l?i m?t kh?u ??n {email}", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);
     Close();
   }
   private void BtnHuy_Click(object sender, RoutedEventArgs e) => Close();
   }
}
