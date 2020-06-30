using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolyDanCol
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }

        public override double Gaji()
        {
            return (JumlahPenjualan * Komisi);
        }
    }
}
