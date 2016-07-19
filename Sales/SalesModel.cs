using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Sales
{
    using ItemsType = ObservableCollection<SalesMonthModel>;
    static  class SalesModel
    {
        private static SalesDatabaseContext
            _dataContext = new SalesDatabaseContext();      //参照先

        private static readonly ItemsType _monthItems = new ItemsType();

        public static ItemsType MonthModels
        {
            get
            {
                return _monthItems;

            }
        }
        
        public static void Renew()
        {
            _monthItems.Clear();
            SalesMonthModel prev = null;
            for (byte month = 1; month <= 4; month++)   //メモ：読み込みの時に出てくる数字（書き方を後々書き換える）
            {
                SalesMonthModel item = new SalesMonthModel(_dataContext, month, prev);
                _monthItems.Add(item);
                prev = item;
            }
        }

        public static void Import(string filename)
        {
            CsvFile.Import(_dataContext, filename);
        }

        public static void Export(string filename)
        {
            CsvFile.Export(_dataContext, filename);
        }
    }
}
