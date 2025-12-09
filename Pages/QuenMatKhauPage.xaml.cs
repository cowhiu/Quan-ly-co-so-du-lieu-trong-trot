using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class QuenMatKhauPage : Page
    {
        public QuenMatKhauPage() { InitializeComponent(); }
private void BtnGuiYeuCau_Click(object sender, RoutedEventArgs e)
      {
            var email = txtEmail.Text.Trim();
    if (string.IsNullOrEmpty(email))
            {
     MessageBox.Show("Vui lòng nh?p email!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
    return;
  }
if (!email.Contains("@"))
  {
      MessageBox.Show("Email không h?p l?!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
       return;
 }
     MessageBox.Show($"?ã g?i liên k?t ??t l?i m?t kh?u ??n {email}.\nVui lòng ki?m tra h?p th?!", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);
        }
   private void BtnQuayLai_Click(object sender, RoutedEventArgs e)
        {
       NavigationService?.GoBack();
      }
    }
}
