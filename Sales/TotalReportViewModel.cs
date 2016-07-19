using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class TotalReportViewModel : ModelBase /*partialについて調べる*/
    {
        public int Year
        {
            get
            {
                return Years.Item;
            }
        }

        public string Section
        {
            get
            {
                return Sections.Item.Title;
            }
        }

        public IEnumerable<SalesMonthModel> Items
        {
            get
            {
                return SalesModel.MonthModels;
            }
        }

        public Action PrintView { get; set; }

        static public void ShowDialog()
        {
            TotalReportViewModel vm = new TotalReportViewModel();
            TotalReportView v = new TotalReportView();
            v.DataContext = vm;
            vm.PrintView();
        }
    }
}
