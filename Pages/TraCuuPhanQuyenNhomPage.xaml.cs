using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace test2.Pages
{
    public partial class TraCuuPhanQuyenNhomPage : Page
    {
        public class PhanQuyenView { public string TenNhom { get; set; } = ""; public string MaQuyen { get; set; } = ""; public string TenQuyen { get; set; } = ""; public bool ChoPhep { get; set; } public bool DuocPhep { get; set; } }
        public TraCuuPhanQuyenNhomPage()
        {
         InitializeComponent();
   cboNhom.Items.Add("Quan tri vien");
            cboNhom.Items.Add("Nhan vien");
   cboNhom.Items.Add("Khach");
   cboNhom.SelectedIndex = 0;
     
    cboQuyen.Items.Add("Tat ca");
    cboQuyen.Items.Add("Xem");
    cboQuyen.Items.Add("Them");
  cboQuyen.Items.Add("Sua");
        cboQuyen.Items.Add("Xoa");
 cboQuyen.SelectedIndex = 0;
        }

        private void BtnTraCuu_Click(object sender, RoutedEventArgs e)
  {
 var nhom = cboNhom.SelectedItem?.ToString() ?? "";
     dgKetQua.ItemsSource = new List<PhanQuyenView>
            {
   new PhanQuyenView { TenNhom = nhom, MaQuyen = "Q01", TenQuyen = "Xem danh sach", DuocPhep = true },
   new PhanQuyenView { TenNhom = nhom, MaQuyen = "Q02", TenQuyen = "Them moi", DuocPhep = nhom == "Quan tri vien" },
           new PhanQuyenView { TenNhom = nhom, MaQuyen = "Q03", TenQuyen = "Sua", DuocPhep = nhom == "Quan tri vien" },
    new PhanQuyenView { TenNhom = nhom, MaQuyen = "Q04", TenQuyen = "Xoa", DuocPhep = nhom == "Quan tri vien" },
        };
      }

  private void BtnLamMoi_Click(object sender, RoutedEventArgs e)
        {
   cboNhom.SelectedIndex = 0;
    cboQuyen.SelectedIndex = 0;
       dgKetQua.ItemsSource = null;
        }
    }
}
