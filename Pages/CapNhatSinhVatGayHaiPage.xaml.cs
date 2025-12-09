using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class CapNhatSinhVatGayHaiPage : Page
  {
        public class BaoCaoSinhVat
{
            public DateTime NgayBaoCao { get; set; }
            public string TenSinhVat { get; set; } = "";
            public string VungTrong { get; set; } = "";
    public string MucDo { get; set; } = "";
  public double DienTich { get; set; }
      }
        private ObservableCollection<BaoCaoSinhVat> _danhSach = new();
public CapNhatSinhVatGayHaiPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
      {
   cboSinhVat.Items.Clear();
cboSinhVat.Items.Add("Sâu cu?n lá nh?");
         cboSinhVat.Items.Add("R?y nâu");
     cboSinhVat.Items.Add("B?nh ??o ôn");
            cboVungTrong.Items.Clear();
  cboVungTrong.Items.Add("An Giang");
            cboVungTrong.Items.Add("??ng Tháp");
   cboVungTrong.Items.Add("Kiên Giang");
  dpNgayBaoCao.SelectedDate = DateTime.Today;
     _danhSach = new ObservableCollection<BaoCaoSinhVat>
            {
     new BaoCaoSinhVat { NgayBaoCao = DateTime.Today.AddDays(-1), TenSinhVat = "Sâu cu?n lá nh?", VungTrong = "An Giang", MucDo = "N?ng", DienTich = 150 },
       new BaoCaoSinhVat { NgayBaoCao = DateTime.Today.AddDays(-2), TenSinhVat = "R?y nâu", VungTrong = "??ng Tháp", MucDo = "Trung bình", DienTich = 80 },
     };
       dgData.ItemsSource = _danhSach;
      }
    private void BtnLuu_Click(object sender, RoutedEventArgs e)
   {
 if (cboSinhVat.SelectedItem == null || cboVungTrong.SelectedItem == null || cboMucDo.SelectedItem == null)
      {
         MessageBox.Show("Vui lòng ?i?n ??y ?? thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
     }
    _danhSach.Insert(0, new BaoCaoSinhVat
  {
    NgayBaoCao = dpNgayBaoCao.SelectedDate ?? DateTime.Today,
       TenSinhVat = cboSinhVat.SelectedItem.ToString()!,
    VungTrong = cboVungTrong.SelectedItem.ToString()!,
                MucDo = ((ComboBoxItem)cboMucDo.SelectedItem).Content.ToString()!,
     DienTich = double.TryParse(txtDienTich.Text, out var dt) ? dt : 0
         });
      MessageBox.Show("L?u báo cáo thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
 }
}
