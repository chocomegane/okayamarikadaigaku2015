using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Section
    {
        private string _title;
        public string Title　　　　//privateの使い方は要注意　保護レベルが高い　使い分けがいまいちわからない
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public byte Id { get; set; }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            int a = GetHashCode();
            int b = obj.GetHashCode();
            bool r = (a == b);
            return r;
        }


        public override string ToString()
        {
            return Title;
        }

        static public bool operator ==(Section a, Section b)
        {
            if ((object)a == null) return ((object)b == null);
            return a.Equals(b);

        }

        static public bool operator !=(Section a, Section b)
        {
            if ((object)a == null) return !((object)b == null);
            return !a.Equals(b);

        }
    }
}
