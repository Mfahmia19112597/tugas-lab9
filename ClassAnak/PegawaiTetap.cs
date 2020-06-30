using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.ClassAnak
{
    public class PegawaiTetap : ClassInduk.Pegawai
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double gajibulanan { get; set; }
        public override double gaji()
        {
            return gajibulanan;
        }
    }
}