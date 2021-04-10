using System;

namespace tesdelegate
{
    class Program
    {
        delegate string Print(string a, string b);
        static string Gabung(string a, string b){
            return a+" "+b;
        }
        static void Put(string[] Array, Print a, string string2){
            for(int i=0;i<Array.Length;i++){
                string stringku = a(Array[i], string2);
                Console.Write(stringku);
                Console.WriteLine();
            }
        }
        static void Main(string[] args){
            string[] Array = {"I am", "You are","Tim was"};
            Put(Array, Gabung, "an engineer");

            
        }
    
    }
}




