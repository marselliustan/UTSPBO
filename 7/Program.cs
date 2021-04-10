using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple-Fixed Point Method Fungsi Kuadrat");
            Console.WriteLine("========================================");
            Console.Write("Masukkan x : ");
            double Xi = double.Parse(Console.ReadLine());
            double atas = Xi;
            Console.Write("Masukkan a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan c : ");
            int c = Convert.ToInt32(Console.ReadLine());

            double Xr, ea, es = 0.05, temp = 0;
            int iter = 0;
            do
            {
                //Console.WriteLine("es = {0}", es);
                //Console.WriteLine("Xl = {0}, Xu = {1}", Xl, Xu);
                Xr = (-(a*Xi*Xi)-c)/b;
                ea = ((Xr-temp)*100)/Xr;
                if(ea<0){
                    ea = ea *(-1);
                }
                temp = Xr;
                if(ea < es){
                    Console.WriteLine("akar adalah x = {0} dengan error {1} %", Xr, ea);
                    Console.WriteLine("konvergen pada iterasi ke-{0}", iter);
                    break;
                }
                Xi = Xr;
                iter += 1;
            } while (iter <= 50);

            //Console.WriteLine("Iterasi = {0} {1}", iter,ea);
        }
    }
}
