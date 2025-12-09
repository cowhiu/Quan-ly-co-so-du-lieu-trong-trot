using System.Windows;
using test2.Models;

namespace test2.Dialogs
{
    public partial class HuyenDialog : Window
    {
 public Huyen Huyen { get; private set; }

      public HuyenDialog()
      {
   InitializeComponent();
       Huyen = new Huyen();
      }

        public HuyenDialog(Huyen huyen)
        {
      InitializeComponent();
         Huyen = new Huyen
      {
        Id = huyen.Id,
    MaHuyen = huyen.MaHuyen,
           TenHuyen = huyen.TenHuyen,
MoTa = huyen.MoTa,
      TrangThai = huyen.TrangThai,
  NgayTao = huyen.NgayTao
         };
     
     txtMaHuyen.Text = huyen.MaHuyen;
     txtTenHuyen.Text = huyen.TenHuyen;
     txtMoTa.Text = huyen.MoTa;
           chkTrangThai.IsChecked = huyen.TrangThai;
   }

 private void BtnSave_Click(object sender, RoutedEventArgs e)
 {
      if (string.IsNullOrWhiteSpace(txtMaHuyen.Text))
      {
  MessageBox.Show("Vui long nhap ma huyen!", "Canh bao", MessageBoxButton.OK, MessageBoxImage.Warning);
              return;
     }

    if (string.IsNullOrWhiteSpace(txtTenHuyen.Text))
       {
     MessageBox.Show("Vui long nhap ten huyen!", "Canh bao", MessageBoxButton.OK, MessageBoxImage.Warning);
           return;
       }

  Huyen.MaHuyen = txtMaHuyen.Text.Trim();
      Huyen.TenHuyen = txtTenHuyen.Text.Trim();
        Huyen.MoTa = txtMoTa.Text.Trim();
    Huyen.TrangThai = chkTrangThai.IsChecked ?? true;

   DialogResult = true;
   Close();
      }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
  DialogResult = false;
Close();
        }
    }
}
