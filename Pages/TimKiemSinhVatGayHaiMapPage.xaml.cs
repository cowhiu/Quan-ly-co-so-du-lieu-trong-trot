using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class TimKiemSinhVatGayHaiMapPage : Page
    {
 public TimKiemSinhVatGayHaiMapPage() { InitializeComponent(); LoadData(); }
  private void LoadData()
   {
    cboSinhVat.Items.Clear();
     cboSinhVat.Items.Add("T?t c?");
      cboSinhVat.Items.Add("Sâu cu?n lá nh?");
  cboSinhVat.Items.Add("R?y nâu");
            cboSinhVat.Items.Add("B?nh ??o ôn");
   cboSinhVat.SelectedIndex = 0;
    cboTinh.Items.Clear();
   cboTinh.Items.Add("T?t c?");
  cboTinh.Items.Add("An Giang");
    cboTinh.Items.Add("??ng Tháp");
cboTinh.Items.Add("Kiên Giang");
cboTinh.Items.Add("Long An");
cboTinh.SelectedIndex = 0;
        }
        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
MessageBox.Show($"Tìm ki?m sinh v?t gây h?i:\n- Sinh v?t: {cboSinhVat.SelectedItem}\n- T?nh: {cboTinh.SelectedItem}\n\n?ang hi?n th? trên b?n ??...", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
   {
          cboSinhVat.SelectedIndex = 0;
            cboTinh.SelectedIndex = 0;
   }
    }
}
