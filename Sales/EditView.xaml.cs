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
    /// EditView.xaml の相互作用ロジック
    /// </summary>
    public partial class EditView : Window
    {
        public EditView()
        {
            DataContextChanged += (s, e) =>
                {
                    EditViewModel x = DataContext as EditViewModel;
                    if (x == null) throw new InvalidCastException();
                    x.ShowDialogBox = () => ShowDialog() ?? false;
                    x.CloseDialogBox = p => DialogResult = p;
                };

            InitializeComponent();
        }
    }
}
