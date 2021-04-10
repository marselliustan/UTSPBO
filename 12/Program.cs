using System;

namespace _12
{
    class Calculator{
        public Calculator(){
            Console.WriteLine("General Calculator");
        }
        public int Addition(int a, int b)=>a+b;
        public int Substraction(int a, int b)=>a-b;
        public int Multiplication(int a, int b)=>a*b;
        public double Division(int a, int b)=>a/b;
    }
    class Power:Calculator{
        int i;
        double total = 1;
        public Power(){
            Console.WriteLine("Power Calculator");
        }
        public double Calculate(int x, int a){
            for(i=1;i<=a;i++){
                total = total*x;
            }
            return total;
        }
    }
    struct Coordinate{
        int x;
        int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.WriteLine("Choose your calculator!");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1){
                var Gen_Calculator = new Calculator();
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("operation = ");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op==1){
                    result = Gen_Calculator.Addition(a,b);
                    Console.WriteLine(result);
                }
                else if (op==2){
                    result = Gen_Calculator.Substraction(a,b);
                    Console.WriteLine(result);
                }
                else if (op==3){
                    result = Gen_Calculator.Multiplication(a,b);
                    Console.WriteLine(result);
                }
                else if(op==4){
                    result = Gen_Calculator.Division(a,b);
                    Console.WriteLine(result);
                }
                else{
                    Console.WriteLine("Invalid");
                }
            }
            else if(choice==2){
                var Pow_Calculator = new Power();
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("power = ");
                int power = Convert.ToInt32(Console.ReadLine());
                result = Pow_Calculator.Calculate(a, power);
                Console.WriteLine(result);
            }
        }
    }
}
