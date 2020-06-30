using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.ClassInduk
{
    public abstract class Pegawai
    {
        public abstract string nik { get; set; }
        public abstract string nama { get; set; }
        public abstract double gaji();
    }
}