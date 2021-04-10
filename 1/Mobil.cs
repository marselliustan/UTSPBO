using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hitung
{
    class Mobil{
        public string nama;
        public string tipe;
        public int jarak;
        public int waktu;
        private int tes;

        public int settes{
            get{
                return tes;
            }
            set{
                tes = value;
            }
        }

        public float HitungKecepatan(int jarak, int waktu){
            Console.WriteLine("Nilai tes adalah {0}",tes);
            return (jarak/waktu);
        }
    }
}