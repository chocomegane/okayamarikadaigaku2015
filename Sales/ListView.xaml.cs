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
using System.Windows.Shapes;

namespace Sales
{
    /// <summary>
    /// ListView.xaml の相互作用ロジック
    /// </summary>
    public partial class ListView : Window
    {
        public ListView()
        {
            DataContextChanged += (s, e) =>
                {
                    ListViewModel x = DataContext as ListViewModel;
                    if (x == null) throw new InvalidCastException();
                    x.ShowDialogBox = () => ShowDialog();
                    x.CloseDialogBox = Close;
                    x.ShowYesNoDialogBox = ExecuteShowYesNoDialogBox;

                };//なんで;がいるのか
            InitializeComponent();
        }

        private bool ExecuteShowYesNoDialogBox(string message)
        {
            MessageBoxResult r =
                MessageBox.Show(
                   message,
                   "Sales",
                   MessageBoxButton.YesNo,
                   MessageBoxImage.Question);
            return r == MessageBoxResult.Yes;
        }
    }
}
