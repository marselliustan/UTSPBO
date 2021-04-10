using System;

namespace _8
{
    class Function{
        public double a, b, c;
        public double fx(double x){
            return (a*x*x) + (b*x)+c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Function f1 = new Function();
            f1.a = 2;
            f1.b = 2;
            f1.c = 1;
            Function f2 = new Function();
            f2.a = 2;
            f2.b = 6;
            f2.c = -7;
            Console.WriteLine("Hello World!");
            Console.WriteLine("===================");
            Console.Write("Masukkan n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan fungsi ke berapa = ");
            int pil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================");
            if(pil==1){
                Console.WriteLine("f(x) = {0}x^2 + {1}x + {2}", f1.a, f1.b, f1.c);
                for(int i=0;i<n;i++){
                    Console.WriteLine("y = {0} untuk x = {1}", f1.fx(i),i);
                }
            }
            else if(pil==2){
                Console.WriteLine("f(x) = {0}x^2 + {1}x + {2}", f2.a, f2.b, f2.c);
                for(int i=0;i<n;i++){
                    Console.WriteLine("y = {0} untuk x = {1}", f1.fx(i),i);
                }
            }
            else{
                Console.WriteLine("Tidak valid");
            }
        }
    }
}
