using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap5.DAL.Entity
{
    public class lop
    {
        [Key]
        public int malop { get; set; }
        public string tenlop { get; set; }

    }
}
