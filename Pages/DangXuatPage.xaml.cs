using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class DangXuatPage : Page
    {
     public DangXuatPage() { InitializeComponent(); }
   private void BtnDangXuat_Click(object sender, RoutedEventArgs e)
  {
   MessageBox.Show("?ã ??ng xu?t thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
Application.Current.Shutdown();
        }
    private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
     NavigationService?.GoBack();
   }
    }
}
