using System;
using tes;

namespace _15
{
    abstract class Car{
        public Car(int topSpeed){
            this.topSpeed = topSpeed;
        }
        public int topSpeed;
        public void printMessage(){
            Console.WriteLine("This is my car! Its top speed is {0}", this.topSpeed);
        }
        public virtual void tesMethod(){
            Console.WriteLine("This is virtual base class method");
        }
    }
    class HybridCar:Car{
        public HybridCar(int topSpeed) : base(topSpeed){
        }
        public new void printMessage(){
            Console.WriteLine("This is my hybrid car! Its top speed is {0}", this.topSpeed);
        }
        public sealed override void tesMethod(){
            Console.WriteLine("This is overriden method");
            base.tesMethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car = new HybridCar(100);
            car.printMessage();
            car.tesMethod();
            var tes = new tesClass();
            tes.abc();
        }
    }
}
