using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hitung
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            Console.WriteLine("Selamat Datang");
            Console.WriteLine("===================");
            Console.Write("Masukkan nama mobil: ");
            mobil1.nama = Console.ReadLine();
            Console.Write("Masukkan tipe mobil: ");
            mobil1.tipe = Console.ReadLine();
            Console.Write("Masukkan jarak: ");
            mobil1.jarak = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan waktu: ");
            mobil1.waktu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai tes: ");
            mobil1.settes = Convert.ToInt32(Console.ReadLine());
            
            float a = mobil1.HitungKecepatan(mobil1.jarak, mobil1.waktu);
            Console.WriteLine("Kecepatan adalah {0:F3} m/s", a);
        }
    }
}
