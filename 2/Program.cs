using System;

namespace _2
{
    class People{
        private string name;
        public string Name{
            get=>name; 
            set=>name = value + "Lie";
        }
        public void Print(){
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new People();
            a.Name = "Sher";
            Console.WriteLine(a.Name);
        }
    }
}
