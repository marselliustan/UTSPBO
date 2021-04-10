using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            normalMember member1 = new normalMember(1, 2015, 50000); 
            member1.calculateDiscount();
            member1.calculatePay();
            member1.Pay();

            VIPMember member2 = new VIPMember(2, 2015, 50000); 
            member2.calculateDiscount();
            member2.calculatePay();
            member2.Pay();
        }
    }
}
