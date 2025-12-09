using System.Windows;

namespace test2.Windows
{
    public partial class ChangePasswordWindow : Window
   {
        public ChangePasswordWindow() { InitializeComponent(); txtMatKhauCu.Focus(); }
        private void BtnDoiMatKhau_Click(object sender, RoutedEventArgs e)
 {
  var matKhauCu = txtMatKhauCu.Password;
    var matKhauMoi = txtMatKhauMoi.Password;
var xacNhan = txtXacNhan.Password;
    if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhan))
          {
   MessageBox.Show("Vui lòng ?i?n ??y ?? thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
       return;
    }
     if (matKhauMoi != xacNhan)
     {
       MessageBox.Show("M?t kh?u m?i và xác nh?n không kh?p!", "L?i", MessageBoxButton.OK, MessageBoxImage.Error);
   return;
    }
     if (matKhauMoi.Length < 6)
      {
     MessageBox.Show("M?t kh?u m?i ph?i có ít nh?t 6 ký t?!", "L?i", MessageBoxButton.OK, MessageBoxImage.Warning);
       return;
     }
       MessageBox.Show("??i m?t kh?u thành công!", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);
      Close();
        }
     private void BtnHuy_Click(object sender, RoutedEventArgs e) => Close();
    }
}
