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
using System.Windows.Markup;
using System.Printing;

namespace Sales
{
    /// <summary>
    /// TotalReportView.xaml の相互作用ロジック
    /// </summary>
    public partial class TotalReportView : UserControl
    {
        private const double _printMargin = 96;
        public TotalReportView()
        {
            DataContextChanged += (s, e) =>
                {
                    TotalReportViewModel x = DataContext as TotalReportViewModel;
                    if (x == null) throw new InvalidCastException();
                    x.PrintView = ExecutePrintThis;
                };
            InitializeComponent();
        }
        private void ExecutePrintThis()
        {
            PrintDialog dialog = new PrintDialog();
            dialog.MinPage = 1;
            dialog.MaxPage = 1;
            dialog.UserPageRangeEnabled = true;
            dialog.PrintTicket.PageMediaSize =
                new PageMediaSize(PageMediaSizeName.ISOA4);
            dialog.PrintTicket.PageOrientation = PageOrientation.Landscape;
            bool r =dialog.ShowDialog() ?? false;
            if (!r) return;

            double w = dialog.PrintableAreaWidth;
            double h = dialog.PrintableAreaHeight;
            Width = w - (_printMargin * 2);
            Height = h - (_printMargin * 2);
            FixedDocument document = CreateDocument(this, w, h);
            dialog.PrintDocument(document.DocumentPaginator, "Sales");

        }

        private static FixedDocument CreateDocument(
            UIElement uiElement, double width, double height)
        {
            FixedPage fp = new FixedPage();
            fp.Width = width;
            fp.Height = height;
            fp.Children.Add(uiElement);
            FixedPage.SetLeft(uiElement, _printMargin);
            FixedPage.SetTop(uiElement, _printMargin);

            PageContent page = new PageContent();
            IAddChild p = page as IAddChild;
            p.AddChild(fp);

            FixedDocument fd = new FixedDocument();
            fd.Pages.Add(page);
            return fd;
        }
    }
}
