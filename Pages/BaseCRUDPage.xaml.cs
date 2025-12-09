using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class BaseCRUDPage : Page
    {
        public BaseCRUDPage()
        {
   InitializeComponent();
     }

        protected virtual void BtnThem_Click(object sender, RoutedEventArgs e)
        {
      MessageBox.Show("Them moi", "Thong bao");
        }

 protected virtual void BtnSua_Click(object sender, RoutedEventArgs e)
     {
   MessageBox.Show("Sua", "Thong bao");
     }

        protected virtual void BtnXoa_Click(object sender, RoutedEventArgs e)
      {
   MessageBox.Show("Xoa", "Thong bao");
  }

   protected virtual void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lam moi", "Thong bao");
        }
 }
}
