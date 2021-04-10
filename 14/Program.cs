using System;

namespace _14
{
    public interface Calculator_base{
        int Addition(int a, int b);
        int Substraction(int a, int b);
    }
    public interface Calculator_base2:Calculator_base{
        public int Multiplication(int a, int b)=>a*a*b*b;
    }
    class Calculator1:Calculator_base2{
        public int Addition(int a, int b)=>a+b+2*a+2*b;
        public int Substraction(int a, int b)=>a-10*a*b-b;
    }
    /* class Calculator2:Calculator_base2{
        public int Addition(int a, int b)=>2*a+2*b;
        public int Substraction(int a, int b)=>2*a-2*b;
        public int Multiplication(int a, int b)=>a*a*b*b;
    } */
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Calculator1();
            Console.WriteLine(a.Substraction(10,9)-a.Addition(1,2));
        }
    }
}
