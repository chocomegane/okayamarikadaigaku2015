
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Properties;

namespace Sales
{
    static class Sections
    {
        private static Section _item = Items[0];
        public static Section Item
        {
            get
            {
                return _item;

            }
            set
            {
                if (_item == value) return;
                if (!Items.Contains(value))
                {
                    throw new Exception("値が不正です");

                }
                _item = value;
            }
        }
        private static Section[] _items;
        public static Section[] Items
        {
            get
            {
                if (_items == null) _items = CreateItems();
                return _items;
            }
        }


        private static Section[] CreateItems()
        {
            string[] records = GetRecords();
            char[] separator = { ':' };

            Section[] r = new Section[records.Length];
            for (int i = 0; i < records.Length; i++)
            {
                string[] field = records[i].Split(separator);
                if (field.Length != 2)
                {
                    throw new Exception("セクションの指定が間違っています");

                }
                Section section = new Section();
                section.Id = byte.Parse(field[0]);
                section.Title = field[1];

                r[i] = section;


            }
            return r;
        }

        private static string[] GetRecords()
        {
            char[] separator = { '|' };
            string text = Settings.Default.Sections;
            string[] records = text.Split(separator);
            return records;
            
        }
    }
}
