using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap5.DAL.Entity
{
    public class sinhvien
    {
        public int msv { get; set; }
        public string hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        public int malop { get; set; }
        [ForeignKey("malop")]
        public virtual sinhvien Sinhvien { get; set; }
    }
}
