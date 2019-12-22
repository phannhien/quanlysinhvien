using LuyenTap5.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap5.DAL
{
    public class ModelContext:DbContext
    {
        public ModelContext()
            :base("Data Source=.;Initial Catalog=LuyenTap5;User ID=sa; Password=123")
        {

        }
        public DbSet<lop> lopDbset { get; set; }
    }
}
