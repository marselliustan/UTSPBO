using System;

namespace _13
{
    enum Borderlines:byte{
        Left=1,Top=3,Right=6,Bottom=9
    }
    class Program
    {
        static void Main(string[] args)
        {
            int left = (int) Borderlines.Left;
            Console.WriteLine(left);
        }
    }
}
