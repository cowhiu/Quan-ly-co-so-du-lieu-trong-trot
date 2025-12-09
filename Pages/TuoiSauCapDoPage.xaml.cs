using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace test2.Pages
{
    public partial class TuoiSauCapDoPage : Page
    {
  public class TuoiSauCapDo
{
  public int Id { get; set; }
       public string Ma { get; set; } = "";
     public string Ten { get; set; } = "";
  public string Loai { get; set; } = "";
            public string MoTa { get; set; } = "";
        }
        private ObservableCollection<TuoiSauCapDo> _danhSach = new();
  public TuoiSauCapDoPage() { InitializeComponent(); LoadData(); }
      private void LoadData()
 {
       _danhSach = new ObservableCollection<TuoiSauCapDo>
        {
     new TuoiSauCapDo { Id = 1, Ma = "T1", Ten = "Tu?i 1", Loai = "Tu?i sâu", MoTa = "Sâu non m?i n?" },
  new TuoiSauCapDo { Id = 2, Ma = "T2", Ten = "Tu?i 2", Loai = "Tu?i sâu", MoTa = "Sâu phát tri?n giai ?o?n 2" },
    new TuoiSauCapDo { Id = 3, Ma = "CD1", Ten = "C?p 1 - Nh?", Loai = "C?p ??", MoTa = "M?t ?? th?p, ít gây h?i" },
              new TuoiSauCapDo { Id = 4, Ma = "CD2", Ten = "C?p 2 - Trung bình", Loai = "C?p ??", MoTa = "M?t ?? trung bình" },
   new TuoiSauCapDo { Id = 5, Ma = "CD3", Ten = "C?p 3 - N?ng", Loai = "C?p ??", MoTa = "M?t ?? cao, gây h?i nghiêm tr?ng" },
      };
            dgData.ItemsSource = _danhSach;
    }
        private void BtnThem_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Thêm tu?i sâu/c?p ?? m?i");
        private void BtnSua_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem == null) MessageBox.Show("Vui lòng ch?n m?c!"); }
      private void BtnXoa_Click(object sender, RoutedEventArgs e) { if (dgData.SelectedItem is TuoiSauCapDo item && MessageBox.Show($"Xóa '{item.Ten}'?", "Xác nh?n", MessageBoxButton.YesNo) == MessageBoxResult.Yes) _danhSach.Remove(item); }
     private void BtnLamMoi_Click(object sender, RoutedEventArgs e) => LoadData();
    }
}
