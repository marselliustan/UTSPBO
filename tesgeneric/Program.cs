using System;

namespace tesgeneric
{
    public class Stack<T>{
        int position = 0;
        T[] Array = new T[10]; 
        public void Push(T a){
            Array[position] = a;
            position++;
        }
        public void Pop(){
            Console.WriteLine(Array[--position]);
        }
        public void printArray(){
            for(int i=0;i<Array.Length;i++){
                Console.Write("{0} ",Array[i]);
                
            }
            Console.WriteLine();
        }
    }
    public class Queue<T>{
        int position = 0;
        int positionde = 0;
        T[] Array = new T[10]; 
        public void Enqueue(T a){
            Array[position] = a;
            position++;
        }
        public void Dequeue(){
            Console.WriteLine(Array[positionde++]);
        }
        public void printArray(){
            for(int i=0;i<Array.Length;i++){
                Console.Write("{0} ",Array[i]);
                
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Stack<int>();
            a.Push(3);
            a.Push(4);
            a.Push(5);
            a.Pop();
            a.Push(6);
            a.printArray();

            var b = new Queue<string>();
            b.Enqueue("a");
            b.Enqueue("b");
            b.Enqueue("c");
            b.Dequeue();
            b.Enqueue("d");
            b.Dequeue();
            b.printArray();

        }
    }
}
