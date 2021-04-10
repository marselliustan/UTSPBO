using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secant Method Fungsi Kuadrat");
            Console.WriteLine("================");
            Console.Write("Masukkan x atas : ");
            double Xu = double.Parse(Console.ReadLine());
            double atas = Xu;
            //Console.WriteLine("Xu = {0}", Xu);
            Console.Write("Masukkan x bawah : ");
            double Xl = double.Parse(Console.ReadLine());
            double bawah = Xl;
            //Console.WriteLine("Xl = {0}", Xl);
            Console.Write("Masukkan a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan c : ");
            int c = Convert.ToInt32(Console.ReadLine());

            double Xr, ea, es = 0.05, temp = 0, tempx;
            int iter = 0;
            do
            {
                //Console.WriteLine("es = {0}", es);
                //Console.WriteLine("Xl = {0}, Xu = {1}", Xl, Xu);
                double fXu = (a*Xu*Xu) + (b*Xu) + c;
                double fXl = (a*Xl*Xl) + (b*Xl) + c;
                Xr = Xu - (fXu*(Xl-Xu))/(fXl-fXu);
                ea = ((Xr-temp)*100)/Xr;
                if(ea<0){
                    ea = ea *(-1);
                }
                temp = Xr;
                if(ea < es){
                    Console.WriteLine("akar di antara x = {0} dan x = {1} adalah x = {2} dengan error {3} %", bawah, atas, Xr, ea);
                    break;
                }
                tempx = Xu;
                Xu = Xr;
                Xl = tempx;
                iter += 1;
            } while (iter <= 50);

            //Console.WriteLine("Iterasi = {0} {1}", iter,ea);
        }
    }
}
