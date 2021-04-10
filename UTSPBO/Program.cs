using System;
using System.IO;

namespace _UTS
{
    abstract class User{
        protected string nama;
        
    }
    class Customer:User{
        public string Nama{
            get{
                return nama;
            }
            set{
                nama = value;
            }
        }
    }
    class Mobil{
        public int seatCount;
        public string nama;
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
        
        public MobilTersedia(string nama,int seatCount, int stock){
            this.nama = nama;
            this.seatCount = seatCount;
            this.stock = stock;
        }
    }
    class SetStock{        
        public static void readStock(MobilTersedia[] listMobil){
            int[] array = new int[10];
            int i = 0;
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()+"\\Stock.txt");
            string line = sr.ReadLine();
            while(line!=null){
                array[i] = Convert.ToInt32(line);
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
            //MobilTersedia[] listMobil = new MobilTersedia[5];
            listMobil[0] = new MobilTersedia("AAA",7,array[0]);
            listMobil[1] = new MobilTersedia("BBB",3,array[1]);
            listMobil[2] = new MobilTersedia("CCC",4,array[2]);
            listMobil[3] = new MobilTersedia("DDD",3,array[3]);
            listMobil[4] = new MobilTersedia("EEE",6,array[4]);
        }
        public static void writeStock(MobilTersedia[] listMobil){
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory()+"\\Stock.txt");
            sw.Flush();
            for(int i=0;i<listMobil.Length;i++){
                sw.WriteLine(listMobil[i].stock);
            }
            sw.Close();
        }
    }
    class CariMobil{
        public static void cariMobil(MobilTersedia[] listMobil, int seatCount){
            Console.WriteLine("No\tNama Mobil\tTersedia");
            for(int i=0;i<listMobil.Length;i++){
                if(listMobil[i].SeatCount == seatCount){
                    Console.WriteLine("{0}\tMobil {1}\t{2}",i+1,listMobil[i].nama,listMobil[i].stock);
                }
            }
        }
    }
    class DetailSewa{
        string nama;
        string paket;
        int tarif;
        int jumlah;
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
        public int tampilkan(){
            int total = jumlah*tarif;
            Console.WriteLine("====================================");
            Console.WriteLine("Detail Pesanan");
            Console.WriteLine("Mobil            : {0}",nama);
            Console.WriteLine("Paket            : {0}",paket);
            Console.WriteLine("Tarif per paket  : Rp. {0},00",tarif);
            Console.WriteLine("Jumlah mobil     : {0}",jumlah);
            Console.WriteLine("====================================");
            Console.WriteLine("Total            : Rp.{0},00",total);
            return total;
        }
        public void setLog(string namaCustomer){
            using(StreamWriter sw2 = File.AppendText(Directory.GetCurrentDirectory()+"\\Log.txt")){
                sw2.WriteLine("");
                sw2.WriteLine("Nama            :"+Convert.ToString(namaCustomer));
                sw2.WriteLine("Mobil           :"+Convert.ToString(nama));
                sw2.WriteLine("Paket           :"+Convert.ToString(paket));
                sw2.WriteLine("Tarif per paket :"+Convert.ToString(tarif));
                sw2.WriteLine("Jumlah mobil    :"+Convert.ToString(jumlah));
                sw2.WriteLine("Tanggal pesan   :"+DateTime.Now);
                sw2.Close();
            }

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
    class TampilPaket{
        public static void tampilkanPaket(MobilTersedia[] listMobil, Paket[] listPaket){
            Console.WriteLine("====================================");
            //Paket[] listPaket = new Paket[3];
            listPaket[0] = new Paket("Per jam",200000);
            listPaket[1] = new Paket("Per hari",190000);
            listPaket[2] = new Paket("Per minggu",180000);
            Console.WriteLine("No\tJenis Paket\tTarif");
            for(int i=0;i<listPaket.Length;i++){
                Console.WriteLine("{0}\t{1}\t{2}",i+1,listPaket[i].nama,listPaket[i].tarif);
            }
        }
    }
    class Pembayaran{
        public static void bayar(int total){
            Console.WriteLine("====================================");
            Console.Write("Masukkan jumlah uang: ");
            int uang = Convert.ToInt32(Console.ReadLine());
            if(uang>=total){
                Console.WriteLine("Kembalian           : {0}", uang-total);
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
            Console.WriteLine("====================================");
            Customer customer1 = new Customer();
            Console.Write("Nama: ");
            customer1.Nama = Console.ReadLine();
            Mobil mobil1 = new Mobil(); 
            Console.Write("Masukkan jumlah kursi mobil yang diinginkan: ");
            mobil1.SeatCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====================================");
            MobilTersedia[] listMobil = new MobilTersedia[5];
            SetStock.readStock(listMobil);
            CariMobil.cariMobil(listMobil,mobil1.SeatCount);
            Paket[] listPaket = new Paket[3];
            TampilPaket.tampilkanPaket(listMobil,listPaket);
            Console.WriteLine("====================================");
            Console.Write("Masukkan pilihan mobil: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan pilihan paket: ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan jumlah mobil : ");
            int jlh = Convert.ToInt32(Console.ReadLine());
            DetailSewa sewa = new DetailSewa();
            sewa.Nama = listMobil[i-1].nama;
            sewa.Paket = listPaket[j-1].nama;
            sewa.Tarif = listPaket[j-1].tarif;
            sewa.Jumlah = jlh;
            int total = sewa.tampilkan();
            Console.Write("Buat pesanan? [ya/tidak]: ");
            string konf = Console.ReadLine();
            if(konf=="ya"){
                Pembayaran.bayar(total);
            }
            listMobil[i-1].stock = (listMobil[i-1].stock) - jlh;
            SetStock.writeStock(listMobil);
            sewa.setLog(customer1.Nama);
        }
    }
}

