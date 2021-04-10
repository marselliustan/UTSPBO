using System;

namespace _17
{
    class User{
        string nama;
        string noKtp;
        public string Nama{
            get{
                return nama;
            }
            set{
                nama = value;
            }
        }
    }
    class Customer:User{

    }
    class Mobil{
        protected int seatCount;
        public int SeatCount{
            get{
                return seatCount;
            }
            set{
                seatCount = value;
            }
        }
    }
    class MobilTersedia:Mobil{
        public int stock;
        public string nama;
        public MobilTersedia(string nama,int seatCount, int stock){
            this.nama = nama;
            this.seatCount = seatCount;
            this.stock = stock;
        }
    }
    class SetStock{        
        public static void setStock(int seatCount){
            MobilTersedia[] listMobil = new MobilTersedia[5];
            listMobil[0] = new MobilTersedia("AAA",3,10);
            listMobil[1] = new MobilTersedia("BBB",3,10);
            listMobil[2] = new MobilTersedia("CCC",2,10);
            CariMobil.cariMobil(listMobil,seatCount);
        }
    }
    class CariMobil{
        public static void cariMobil(MobilTersedia[] listMobil, int seatCount){
            Console.WriteLine("Nama Mobil\tTersedia");
            for(int i=0;i<3;i++){
                if(listMobil[i].SeatCount == seatCount){
                    Console.WriteLine("Mobil {0}\t{1}",listMobil[i].nama,listMobil[i].stock);
                }
            }
            Sewa.tampilkanPaket(listMobil);
        }
    }
    class DetailSewa{
        string nama;
        string paket;
        int tarif;
        int jumlah;
        string tanggal;
        public string Nama{
            get{
                return nama;
            }
            set{
                nama = value;
            }
        }
        public string Paket{
            get{
                return paket;
            }
            set{
                paket = value;
            }
        }
        public int Tarif{
            get{
                return tarif;
            }
            set{
                tarif = value;
            }
        }
        public int Jumlah{
            get{
                return jumlah;
            }
            set{
                jumlah = value;
            }
        }
        public void tampilkan(){
            int total = jumlah*tarif;
            Console.WriteLine("====================================");
            Console.WriteLine("Mobil            : {0}",nama);
            Console.WriteLine("Paket            : {0}",paket);
            Console.WriteLine("Tarif per paket  : Rp. {0},00",tarif);
            Console.WriteLine("jumlah paket     : {0}",jumlah);
            Console.WriteLine("====================================");
            Console.WriteLine("Total            : Rp.{0},00",total);
            Pembayaran.bayar(total);
        }
    }
    class Paket{
        public int tarif;
        public string nama;
        public Paket(string nama,int tarif){
            this.tarif = tarif;
            this.nama = nama;
        }
    }
    class Sewa{
        public static void tampilkanPaket(MobilTersedia[] listMobil){
            Console.WriteLine("==================================================================");
            Paket[] listPaket = new Paket[3];
            listPaket[0] = new Paket("Per jam",200000);
            listPaket[1] = new Paket("Per hari",190000);
            listPaket[2] = new Paket("Per minggu",180000);
            Console.WriteLine("Jenis Paket\tTarif");
            for(int i=0;i<listPaket.Length;i++){
                Console.WriteLine("{0}\t{1}",listPaket[i].nama,listPaket[i].tarif);
            }
            Sewa.pilih(listMobil,listPaket);
        }
        public static void pilih(MobilTersedia[] listMobil, Paket[] listPaket){
            Console.Write("Masukkan pilihan mobil: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan pilihan paket: ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan jumlah: ");
            int jlh = Convert.ToInt32(Console.ReadLine());
            DetailSewa sewa = new DetailSewa();
            sewa.Nama = listMobil[i-1].nama;
            sewa.Paket = listPaket[j-1].nama;
            sewa.Tarif = listPaket[j-1].tarif;
            sewa.Jumlah = jlh;
            sewa.tampilkan();
        }
    }
    class Pembayaran{
        public static void bayar(int total){
            Console.Write("Masukkan jumlah uang: ");
            int uang = Convert.ToInt32(Console.ReadLine());
            if(uang>=total){
                Console.Write("Kembalian           : {0}", uang-total);
                Console.WriteLine("Terima Kasih!");
            }
            else{
                Console.Write("Maaf, uang Anda tidak mencukupi");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Selamat Datang!");
            Console.WriteLine("===============");
            Customer customer1 = new Customer();
            Console.Write("Nama: ");
            customer1.Nama = Console.ReadLine();
            Mobil mobil1 = new Mobil(); 
            Console.Write("Masukkan jumlah tempat duduk mobi: ");
            mobil1.SeatCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==================================================================");
            SetStock.setStock(mobil1.SeatCount);
            
            

        }
    }
}
