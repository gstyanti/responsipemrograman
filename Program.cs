using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi_syifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "joni", 2000000);


            Console.WriteLine("NIK \t Nama \t\t Gaji");
            Console.WriteLine("-------------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine(" Asyiiiiik kenaikan gaji 10!!");

            Console.WriteLine("NIK \t Nama \t\t Gaji");
            Console.WriteLine("-------------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }
}
