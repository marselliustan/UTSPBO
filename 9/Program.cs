using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Naive Gauss Elimination");
            Console.WriteLine("=======================");
            Console.Write("Masukkan a11 = ");
            double a11 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan a12 = ");
            double a12 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan a13 = ");
            double a13 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan hasil1 = ");
            double hasil1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan a21 = ");
            double a21 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan a22 = ");
            double a22 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan a23 = ");
            double a23 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan hasil2 = ");
            double hasil2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan a31 = ");
            double a31 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan a32 = ");
            double a32 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan a33 = ");
            double a33 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan hasil3 = ");
            double hasil3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("=======================");
            Console.WriteLine("({0})x + ({1})y + ({2})z = {3}", a11, a12, a13, hasil1);
            Console.WriteLine("({0})x + ({1})y + ({2})z = {3}", a21, a22, a23, hasil1);
            Console.WriteLine("({0})x + ({1})y + ({2})z = {3}", a31, a32, a33, hasil1);

            double a212 = a21-((a21/a11)*a11);
            double a222 = a22-((a21/a11)*a12);
            double a232 =  a23-((a21/a11)*a13);
            double hasil22 = hasil1-((a21/a11)*hasil1);

            double a312 = a31-((a31/a21)*a21);
            double a322 = a32-((a31/a21)*a22);
            double a332 = a33-((a31/a21)*a23);
            double hasil32 = hasil1-((a31/a21)*hasil2);

            Console.WriteLine("=======================");
            Console.WriteLine("({0})x + ({1})y + ({2})z = {3}", a11, a12, a13, hasil1);
            Console.WriteLine("({0})x + ({1})y + ({2})z = {3}", a212, a222, a232, hasil22);
            Console.WriteLine("({0})x + ({1})y + ({2})z = {3}", a312, a322, a332, hasil32);

            double a323 = a322-((a31/a11)*a12);
            double a333 = a332-((a31/a11)*a13);
            double hasil33 = hasil22-((a31/a11)*hasil1);

            Console.WriteLine("=======================");
            Console.WriteLine("({0})x + ({1})y + ({2})z = {3}", a11, a12, a13, hasil1);
            Console.WriteLine("  0    + ({0})y + ({1})z = {2}", a222, a232, hasil22);
            Console.WriteLine("  0    + ({0})y + ({1})z = {2}", a323, a333, hasil33);
        }
    }
}
