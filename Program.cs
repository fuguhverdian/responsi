using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4331
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            Karyawan karyawan1 = new Karyawan(12323212, "fahrul", 6000000);
            Karyawan karyawan2 = new Karyawan(12321321, "fuguh", 9000000);
            Karyawan karyawan3 = new Karyawan(12323123, "veridan", -400000);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\n\nAsikkkkk dpt kenaikan gaji nih!!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);


            Console.ReadKey();
        }
    }
}
