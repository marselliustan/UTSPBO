using System;
using System.IO;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i = 0;
            string path = Path.Combine(Directory.GetCurrentDirectory());
            StreamReader sr = new StreamReader(path+"\\fileName.txt");
            string line = sr.ReadLine();
            while(line!=null){
                array[i] = Convert.ToInt32(line);
                line = sr.ReadLine();
                i++;
            }
            for(int j=0;j<array.Length;j++){
                Console.Write("{0} ",array[j]);
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(path+"\\fileName.txt"); 
            sw.Flush();
            sw.WriteLine("Hello world");
            sw.WriteLine("Hello world");
            sw.WriteLine("Hello world");
            sw.Close();

        }
    }
}
