using System;

namespace _16
{
    class convert{
        public static int convert1(int a){
            return a*10;
        }
        public int convert2(int a){
            return a*20;
        }
    }
    static class currencyConverter{
        public static double toDollar(double rp){
            return rp/14000;
        }
        public static double toRupiah(double dollar){
            return dollar*14000;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new convert();
            Console.WriteLine(convert.convert1(10));
            Console.WriteLine(a.convert2(10));
        }
    }
}
