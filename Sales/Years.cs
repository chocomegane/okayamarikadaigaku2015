using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Properties;

namespace Sales
{
    static class Years
    {
        private static short _item = Items[0];
        public static short Item
        {
            get
            {
                return _item;
            }
            set
            {
                if (_item == value) return;
                if (!Items.Contains(value)) throw new Exception("値が不正です");
                _item = value;

            }
        }


        private static short[] _items;
        public static short[] Items
        {
            get
            {
                if (_items == null) _items = CreateItems();
                return _items;


            }
        }

        private static short[] CreateItems()
        {
            int minYear = Settings.Default.StartYear;
            int maxYear = DateTime.Now.Year;
            int length = maxYear - minYear + 1;
            short[] r = new short[length];
            for (int i = 0; i < length; i++)
            {
                int year = minYear + i;
                r[i] = (short)year;

            }
            return r;

        }
    }
}
/*カプセル化　継承の理解が危うい
 多態性　抽象クラス　インターフェース*/