using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            nonMember customer1 = new nonMember(2018, 50000);
            Console.WriteLine(customer1.memberSince);
            customer1.calculateDiscount();
            Console.WriteLine(customer1.discount);
            //double a = customer1.discount;
            //Console.WriteLine({0}, a);
        }
    }
}
