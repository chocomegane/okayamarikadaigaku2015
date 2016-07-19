using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sales
{
    class SalesDatabaseContext : DbContext
    {
        public DbSet<Result> Results { get; set; }
    }
}
