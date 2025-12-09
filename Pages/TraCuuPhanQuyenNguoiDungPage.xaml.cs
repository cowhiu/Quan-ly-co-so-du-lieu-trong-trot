using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class TraCuuPhanQuyenNguoiDungPage : Page
   {
        public class PhanQuyenNguoiDungInfo
 {
     public string TenNguoiDung { get; set; } = "";
    public string TenDangNhap { get; set; } = "";
      public string TenQuyen { get; set; } = "";
     public bool DuocPhep { get; set; }
        }
        private ObservableCollection<PhanQuyenNguoiDungInfo> _danhSach = new();
public TraCuuPhanQuyenNguoiDungPage() { InitializeComponent(); LoadData(); }
        private void LoadData()
    {
       cboNguoiDung.Items.Clear();
            cboNguoiDung.Items.Add("T?t c?");
       cboNguoiDung.Items.Add("Nguy?n V?n A");
     cboNguoiDung.Items.Add("Tr?n Th? B");
   cboNguoiDung.SelectedIndex = 0;
  cboQuyen.Items.Clear();
       cboQuyen.Items.Add("T?t c?");
    cboQuyen.Items.Add("Xem báo cáo");
 cboQuyen.Items.Add("Qu?n lý d? li?u");
 cboQuyen.Items.Add("Qu?n tr? h? th?ng");
  cboQuyen.SelectedIndex = 0;
       _danhSach = new ObservableCollection<PhanQuyenNguoiDungInfo>
         {
  new PhanQuyenNguoiDungInfo { TenNguoiDung = "Nguy?n V?n A", TenDangNhap = "nguyenvana", TenQuyen = "Xem báo cáo", DuocPhep = true },
 new PhanQuyenNguoiDungInfo { TenNguoiDung = "Nguy?n V?n A", TenDangNhap = "nguyenvana", TenQuyen = "Qu?n lý d? li?u", DuocPhep = true },
       new PhanQuyenNguoiDungInfo { TenNguoiDung = "Tr?n Th? B", TenDangNhap = "tranthib", TenQuyen = "Xem báo cáo", DuocPhep = true },
        };
   dgKetQua.ItemsSource = _danhSach;
 }
  private void BtnTraCuu_Click(object sender, RoutedEventArgs e)
    {
   var nguoiDung = cboNguoiDung.SelectedItem?.ToString() ?? "";
  var quyen = cboQuyen.SelectedItem?.ToString() ?? "";
     var ketQua = _danhSach.Where(x =>
  (nguoiDung == "T?t c?" || x.TenNguoiDung == nguoiDung) &&
    (quyen == "T?t c?" || x.TenQuyen == quyen)).ToList();
       dgKetQua.ItemsSource = ketQua;
  }
       private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
   cboNguoiDung.SelectedIndex = 0;
cboQuyen.SelectedIndex = 0;
       dgKetQua.ItemsSource = _danhSach;
   }
    }
}
