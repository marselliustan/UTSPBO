using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("False Position Method Fungsi Kuadrat");
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

            double Xr, ea, es = 0.05, temp = 0;
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
                //Console.WriteLine("ea ke-{0} = {1}", iter,ea);
                temp = Xr;
                //Console.WriteLine("Xr ke-{0} = {1}", iter,Xr);
                double kali = ((a*Xr*Xr) + (b*Xr) + c)*fXl;
                if(ea < es){
                    Console.WriteLine("akar di antara x = {0} dan x = {1} adalah x = {2} dengan error {3} %", bawah, atas, Xr, ea);
                    break;
                }
                else if(kali<0){
                    Xu = Xr;
                }
                else if(kali>0){
                    Xl = Xr;
                }
                else if(kali==0){
                    Console.WriteLine("akar di antara x = {0} dan x = {1} adalah x = {2}", bawah, atas, Xr);
                    break;
                }
                iter += 1;
            } while (iter <= 50);

            //Console.WriteLine("Iterasi = {0} {1}", iter,ea);
        }
    }
}
