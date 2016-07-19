using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Sales
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string CSV_FILTER = "CSV ファイル(*.csv)|*.csv|" +
            "テキスト ファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";

        public MainWindow()
        {
            DataContextChanged += (s, e) =>
                {
                    MainWindowViewModel x = DataContext as MainWindowViewModel;
                    if (x == null) throw new InvalidCastException();
                    x.ShowOpenFileDialog = ShowOpenFileDialog;
                    x.ShowSaveFileDialog = ShowSaveFileDialog;
                    x.ShowInformationDialog = ShowInformationDialog;
                    x.ShowErrorDialog = ShowErrorDialogBox;
                };

            InitializeComponent();
           /* using (SalesDatabaseContext db = new SalesDatabaseContext())
            { 
            {
                db.Results.Add(new Result { Title = "A" });
                db.Results.Add(new Result { Title = "B" });
                db.Results.Add(new Result { Title = "C" });
                db.SaveChanges();
            }*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private string ShowOpenFileDialog()
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = CSV_FILTER;
            d.Title = "インポートしたいファイルを選択してください";
            d.CheckPathExists = true;
            d.CheckFileExists = true;

            bool r = d.ShowDialog(this) ?? false;
            return r ? d.FileName : null;
        }

        private string ShowSaveFileDialog()
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = CSV_FILTER;
            d.Title = "エクスポートしたいファイルを指定してください";
            d.CheckPathExists = true;

            bool r = d.ShowDialog(this) ?? false;
            return r ? d.FileName : null;
        }

        private void ShowInformationDialog(string message)
        {
            MessageBox.Show(
                message,
                "Sales",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void ShowErrorDialogBox(string message)
        {
            MessageBox.Show(
                message,
                "Sales",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }
}
