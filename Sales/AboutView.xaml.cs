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
    /// AboutView.xaml の相互作用ロジック
    /// </summary>
    public partial class AboutView : Window
    {
        public AboutView()
        {
            DataContextChanged += (s, e) =>
                {
                    AboutViewModel x = DataContext as AboutViewModel;
                    if (x == null) throw new InvalidCastException();
                    x.ShowDialogBox = () => ShowDialog();
                };

            InitializeComponent();
        }
    }
}
