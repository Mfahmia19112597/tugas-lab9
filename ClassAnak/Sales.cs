using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.ClassAnak
{
    public class Sales : ClassInduk.Pegawai
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double jumlahpenjualan { get; set; }
        public double komisi { get; set; }
        public override double gaji()
        {
            return jumlahpenjualan * komisi;
        }
    }
}